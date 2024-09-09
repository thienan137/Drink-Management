CREATE DATABASE QL_BEER
GO

USE QL_BEER
GO

CREATE TABLE Account(
	displayName NVARCHAR(100) NOT NULL,
	userName NVARCHAR(100) PRIMARY KEY ,
	passWord NVARCHAR(100)NOT NULL DEFAULT 0,
	type INT NOT NULL DEFAULT 0
)
GO


CREATE TABLE TableFood(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	status NVARCHAR(100) DEFAULT N'Trống' NOT NULL
)
GO

CREATE TABLE FoodCategory(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL 
)
GO

CREATE TABLE Food(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL ,
	idCategory INT NOT NULL,
	Price FLOAT NOT NULL

	FOREIGN KEY(idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

CREATE TABLE Bill(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE,
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0

	FOREIGN KEY(idTable) REFERENCES dbo.TableFood(id)
)
GO

CREATE TABLE BillInfo(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	Count INT NOT NULL DEFAULT 0

	FOREIGN KEY(idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY(idFood) REFERENCES dbo.Food(id),

)
GO

-- Thêm giá trị cho Account
INSERT INTO Account VALUES
(N'Bùi Huy Tường', N'huytuong','1',1),
(N'Nguyễn Hoàng Thiên Ân', N'thienan','1',1),
(N'Huỳnh Ngọc Phương Anh', N'phuonganh','1',1),
(N'Trần Nhật Nam', N'nhatnam','1',1)
GO

-- Thêm giá trị cho TableFood
UPDATE TableFood SET STATUS = N'Có người' WHERE id = 3 OR id = 7 OR id = 8 OR id = 10

DECLARE @i INT = 1
WHILE @i <= 10
BEGIN
	INSERT TableFood(name) VALUES (N'Bàn ' + CAST(@i AS nvarchar(100)))
	SET @i = @i + 1
END
GO

--Thêm giá trị Category
INSERT INTO FoodCategory VALUES
(N'Signature'),
(N'Rượu'),
(N'Thức ăn'),
(N'Đồ uống khác')

--Thêm món ăn
INSERT INTO Food VALUES
(N'Bia hơi',1,12000),

(N'Macallan',2,1400000),
(N'Chivas',2,1180000),
(N'Glenfiddich',2,1100000),
(N'Vang',2,300000),
(N'Vodka',2,650000),
(N'Singleton',2,1190000),
(N'Johnnie Walker Black Label',2,670000),

(N'Khô gà lá chanh',3,40000),
(N'Khô bò',3,50000),
(N'Đậu phộng mực cay',3,40000),
(N'Mực nướng',3,20000),
(N'Hột vịt lộn',3,10000),
(N'Hột gà nướng',3,7000),

(N'Coffee',4,20000),
(N'Bạc xỉu',4,20000),
(N'Trà sữa trân châu',4,35000),
(N'Hồng trà',4,20000)

--Thêm Bill
INSERT INTO Bill VALUES
(getdate(),null,3,0),
(getdate(),null,7,0),
(getdate(),getdate(),8,0),
(getdate(),getdate(),10,0)

--Thêm giá trị BillInfo
INSERT INTO BillInfo VALUES
(1,1,10),
(1,9,2),
(1,15,1),
(2,5,2),
(2,13,7),
(3,1,12),
(3,14,5),
(4,2,1),
(4,17,2)

--Tạo PROC Login
CREATE PROC USP_Login
@userName nvarchar(100), @passWord nvarchar(100)
AS
BEGIN
	SELECT * FROM Account WHERE userName = @userName AND passWord = @passWord
END 
GO

--Tạo PROC GetAccount
CREATE PROC USP_GetAccountByUserName
@username nvarchar(100)
AS
BEGIN
	SELECT * FROM Account WHERE UserName = @username
END
GO

--Tạo PROC GetTable
CREATE PROC USP_GetTableList
AS SELECT * FROM TableFood
GO

--Tạo PROC Insert Bill
ALTER PROC USP_InsertBill
@idTable INT
AS
BEGIN
	INSERT Bill VALUES
	(GETDATE(), NULL, @idTable,0,0,0)
END
GO

--Tạo PROC Insert BillInfo
CREATE PROC USP_InsertBillInfo
@idBill INT, @idFood INT, @count INT
AS
BEGIN

	DECLARE @isExitsBillInfo INT
	DECLARE @foodcount INT = 1

	SELECT @isExitsBillInfo = id, @foodCount = count 
	FROM BillInfo 
	WHERE idBill = @idBill AND idFood = @idFood

	IF(@isExitsBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount >0)
			UPDATE BillInfo SET count = @foodCount + @count WHERE idFood = @idFood
		ELSE
			DELETE BillInfo WHERE idBill = @idBill AND idFood = @idFood
	END
	ELSE
	BEGIN
		INSERT BillInfo VALUES
		(@idBill, @idFood, @count)
	END

END
GO

CREATE TRIGGER UTG_UpdateBillInfo
ON BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = idBill FROM Inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Bill WHERE id = @idBill AND status = 0
	UPDATE TableFood SET status = N'Có người' WHERE id = @idTable
END
GO

CREATE TRIGGER UTG_UpdateBill
ON Bill FOR UPDATE
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = id FROM Inserted
	DECLARE @idTable INT
	SELECT @idTable = idTable FROM Bill WHERE id = @idBill 
	DECLARE @count INT = 0
	SELECT @count  = COUNT(*) FROM Bill WHERE idTable = @idTable AND status = 0
	IF(@count = 0)
		UPDATE TableFood SET status = N'Trống' WHERE id = @idTable

END
GO

ALTER TABLE Bill
ADD discount INT

UPDATE Bill SET discount = 0
UPDATE Bill SET totalPrice = 0
UPDATE Bill SET dateCheckOut = GETDATE(), status = 1, discount = 10, totalPrice =100000 WHERE id = 7
--Doanh thu
Alter table Bill ADD totalPrice FLOAT

ALTER PROC USP_GetListBillByDate
@checkIn date, @checkOut date
AS 
BEGIN
	SELECT t.name , b.totalPrice , DateCheckIn , DateCheckOut , discount 
	FROM dbo.Bill AS b,dbo.TableFood AS t
	WHERE DateCheckIn >= @checkIn AND DateCheckOut <= @checkOut AND b.status = 1 AND t.id = b.idTable
END
GO

SELECT T.name AS N'Tên bàn', B.DateCheckIn AS N'Từ ngày', B.DateCheckOut AS N'Đến ngày',(Bi.count * F.price) AS 'Tổng tiền'
FROM TableFood T, Bill B, BillInfo Bi, Food F
WHERE T.id = b.idTable AND b.id = Bi.idBill AND Bi.idFood = F.id AND B.DateCheckIn >= '2022-04-01' AND B.DateCheckOut <= '2022-04-30' AND B.status = 1

-- Xóa Bill
CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idBillInfo INT
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill = Deleted.idBill FROM Deleted

	DECLARE @idTable INT
	SELECT @idTable = idTable FROM dbo.Bill WHERE id = @idBill

	DECLARE @count INT = 0

	SELECT @count = COUNT(*) FROM dbo.BillInfo AS bi, dbo.Bill AS b WHERE b.id = bi.idBill AND b.id = @idBill AND b.status = 0

	IF (@count = 0)
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idTable
END
GO

-- Thay đổi Account
CREATE PROC USP_UpdateAccount
@userName NVARCHAR(100), @displayName NVARCHAR(100), @password NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT
	SELECT @isRightPass = COUNT(*) FROM Account WHERE userName = @userName AND passWord = @password

	IF(@isRightPass = 1)
	BEGIN
		IF(@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE Account SET displayName = @displayName WHERE userName = @userName
		END
		ELSE
			UPDATE Account SET displayName = @displayName, passWord = @password WHERE userName = @userName
	END
END
GO





-- Khối lệnh SELECT
SELECT * FROM Account
SELECT * FROM TableFood
SELECT * FROM Bill
SELECT * FROM BillInfo
SELECT * FROM Food
SELECT * FROM FoodCategory