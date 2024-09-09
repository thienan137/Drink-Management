
namespace Phần_mềm_quản_lý.Form_Admin
{
    partial class fFood
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFood));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowFood = new System.Windows.Forms.Button();
            this.btnEditFood = new System.Windows.Forms.Button();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.cbbFoodCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtbFoodName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtbFoodID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtbSearch = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnShowFood);
            this.panel2.Controls.Add(this.btnEditFood);
            this.panel2.Controls.Add(this.btnDeleteFood);
            this.panel2.Controls.Add(this.btnNew);
            this.panel2.Controls.Add(this.btnAddFood);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 109);
            this.panel2.TabIndex = 5;
            // 
            // btnShowFood
            // 
            this.btnShowFood.BackColor = System.Drawing.Color.ForestGreen;
            this.btnShowFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFood.ForeColor = System.Drawing.Color.White;
            this.btnShowFood.Location = new System.Drawing.Point(583, 61);
            this.btnShowFood.Name = "btnShowFood";
            this.btnShowFood.Size = new System.Drawing.Size(83, 34);
            this.btnShowFood.TabIndex = 1;
            this.btnShowFood.Text = "Xem";
            this.btnShowFood.UseVisualStyleBackColor = false;
            this.btnShowFood.Click += new System.EventHandler(this.btnShowFood_Click);
            // 
            // btnEditFood
            // 
            this.btnEditFood.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFood.ForeColor = System.Drawing.Color.White;
            this.btnEditFood.Location = new System.Drawing.Point(490, 61);
            this.btnEditFood.Name = "btnEditFood";
            this.btnEditFood.Size = new System.Drawing.Size(83, 34);
            this.btnEditFood.TabIndex = 1;
            this.btnEditFood.Text = "Sửa";
            this.btnEditFood.UseVisualStyleBackColor = false;
            this.btnEditFood.Click += new System.EventHandler(this.btnEditFood_Click);
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDeleteFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFood.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFood.Location = new System.Drawing.Point(397, 61);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(83, 34);
            this.btnDeleteFood.TabIndex = 1;
            this.btnDeleteFood.Text = "Xóa";
            this.btnDeleteFood.UseVisualStyleBackColor = false;
            this.btnDeleteFood.Click += new System.EventHandler(this.btnDeleteFood_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(177, 61);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(117, 34);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Thêm mới";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.Location = new System.Drawing.Point(304, 61);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(83, 34);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(333, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ MÓN ĂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvFood);
            this.panel1.Location = new System.Drawing.Point(1, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 322);
            this.panel1.TabIndex = 6;
            // 
            // dtgvFood
            // 
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.idCategory,
            this.Price});
            this.dtgvFood.Location = new System.Drawing.Point(3, 3);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.Size = new System.Drawing.Size(496, 316);
            this.dtgvFood.TabIndex = 0;
            this.dtgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên món";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // idCategory
            // 
            this.idCategory.DataPropertyName = "idCategory";
            this.idCategory.HeaderText = "Danh mục";
            this.idCategory.Name = "idCategory";
            this.idCategory.Width = 60;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Đơn giá";
            this.Price.Name = "Price";
            this.Price.Width = 150;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel10);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.txtbSearch);
            this.panel3.Location = new System.Drawing.Point(509, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 322);
            this.panel3.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtbPrice);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Location = new System.Drawing.Point(11, 186);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(319, 35);
            this.panel10.TabIndex = 9;
            // 
            // txtbPrice
            // 
            this.txtbPrice.BackColor = System.Drawing.Color.White;
            this.txtbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbPrice.Location = new System.Drawing.Point(104, 4);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(201, 24);
            this.txtbPrice.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.ForestGreen;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giá";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.cbbFoodCategory);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(11, 145);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(319, 35);
            this.panel9.TabIndex = 8;
            // 
            // cbbFoodCategory
            // 
            this.cbbFoodCategory.BackColor = System.Drawing.Color.White;
            this.cbbFoodCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFoodCategory.FormattingEnabled = true;
            this.cbbFoodCategory.Location = new System.Drawing.Point(104, 4);
            this.cbbFoodCategory.Name = "cbbFoodCategory";
            this.cbbFoodCategory.Size = new System.Drawing.Size(201, 26);
            this.cbbFoodCategory.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Danh mục";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtbFoodName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(11, 104);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(319, 35);
            this.panel8.TabIndex = 7;
            // 
            // txtbFoodName
            // 
            this.txtbFoodName.BackColor = System.Drawing.Color.White;
            this.txtbFoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFoodName.Location = new System.Drawing.Point(104, 6);
            this.txtbFoodName.Name = "txtbFoodName";
            this.txtbFoodName.Size = new System.Drawing.Size(201, 24);
            this.txtbFoodName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtbFoodID);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(11, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 35);
            this.panel7.TabIndex = 6;
            // 
            // txtbFoodID
            // 
            this.txtbFoodID.BackColor = System.Drawing.Color.White;
            this.txtbFoodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbFoodID.Location = new System.Drawing.Point(104, 6);
            this.txtbFoodID.Name = "txtbFoodID";
            this.txtbFoodID.ReadOnly = true;
            this.txtbFoodID.Size = new System.Drawing.Size(201, 24);
            this.txtbFoodID.TabIndex = 2;
            this.txtbFoodID.TextChanged += new System.EventHandler(this.txtbFoodID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID ";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(235, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(95, 34);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtbSearch
            // 
            this.txtbSearch.BackColor = System.Drawing.Color.White;
            this.txtbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.Location = new System.Drawing.Point(11, 12);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.Size = new System.Drawing.Size(218, 24);
            this.txtbSearch.TabIndex = 0;
            // 
            // fFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fFood";
            this.Text = "fFood";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnShowFood;
        private System.Windows.Forms.Button btnEditFood;
        private System.Windows.Forms.Button btnDeleteFood;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ComboBox cbbFoodCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtbFoodName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtbFoodID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtbSearch;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}