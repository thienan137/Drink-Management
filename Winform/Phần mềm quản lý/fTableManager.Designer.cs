
namespace Phần_mềm_quản_lý
{
    partial class fTableManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableManager));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDiscount = new System.Windows.Forms.Button();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.txtbTotalPrice = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.cbbSwitchTable = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1285, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddFood);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbFood);
            this.panel1.Controls.Add(this.cbbCategory);
            this.panel1.Location = new System.Drawing.Point(795, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 123);
            this.panel1.TabIndex = 2;
            // 
            // btnAddFood
            // 
            this.btnAddFood.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFood.ForeColor = System.Drawing.Color.White;
            this.btnAddFood.Location = new System.Drawing.Point(28, 78);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(425, 41);
            this.btnAddFood.TabIndex = 4;
            this.btnAddFood.Text = "THÊM MÓN";
            this.btnAddFood.UseVisualStyleBackColor = false;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(364, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số lượng";
            // 
            // numCount
            // 
            this.numCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCount.Location = new System.Drawing.Point(344, 42);
            this.numCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numCount.Name = "numCount";
            this.numCount.Size = new System.Drawing.Size(127, 26);
            this.numCount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(4, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên món:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên danh mục:";
            // 
            // cbbFood
            // 
            this.cbbFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.ItemHeight = 20;
            this.cbbFood.Location = new System.Drawing.Point(145, 41);
            this.cbbFood.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(189, 28);
            this.cbbFood.TabIndex = 2;
            this.cbbFood.SelectedIndexChanged += new System.EventHandler(this.cbbFood_SelectedIndexChanged);
            // 
            // cbbCategory
            // 
            this.cbbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.ItemHeight = 20;
            this.cbbCategory.Location = new System.Drawing.Point(145, 4);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(189, 28);
            this.cbbCategory.TabIndex = 1;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvBill);
            this.panel2.Location = new System.Drawing.Point(795, 164);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 372);
            this.panel2.TabIndex = 3;
            // 
            // lvBill
            // 
            this.lvBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvBill.HideSelection = false;
            this.lvBill.Location = new System.Drawing.Point(4, 4);
            this.lvBill.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvBill.Name = "lvBill";
            this.lvBill.Size = new System.Drawing.Size(465, 362);
            this.lvBill.TabIndex = 0;
            this.lvBill.UseCompatibleStateImageBehavior = false;
            this.lvBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 170;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 120;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDiscount);
            this.panel3.Controls.Add(this.numDiscount);
            this.panel3.Controls.Add(this.btnCheckOut);
            this.panel3.Location = new System.Drawing.Point(795, 577);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 98);
            this.panel3.TabIndex = 4;
            // 
            // btnDiscount
            // 
            this.btnDiscount.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDiscount.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscount.ForeColor = System.Drawing.Color.White;
            this.btnDiscount.Location = new System.Drawing.Point(273, 4);
            this.btnDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDiscount.Name = "btnDiscount";
            this.btnDiscount.Size = new System.Drawing.Size(115, 47);
            this.btnDiscount.TabIndex = 8;
            this.btnDiscount.Text = "Giảm giá";
            this.btnDiscount.UseVisualStyleBackColor = false;
            // 
            // numDiscount
            // 
            this.numDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDiscount.Location = new System.Drawing.Point(92, 14);
            this.numDiscount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(160, 26);
            this.numDiscount.TabIndex = 7;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCheckOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckOut.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(28, 48);
            this.btnCheckOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(425, 44);
            this.btnCheckOut.TabIndex = 10;
            this.btnCheckOut.Text = "THANH TOÁN";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // txtbTotalPrice
            // 
            this.txtbTotalPrice.BackColor = System.Drawing.SystemColors.Control;
            this.txtbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTotalPrice.ForeColor = System.Drawing.Color.DarkRed;
            this.txtbTotalPrice.Location = new System.Drawing.Point(992, 538);
            this.txtbTotalPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbTotalPrice.Name = "txtbTotalPrice";
            this.txtbTotalPrice.ReadOnly = true;
            this.txtbTotalPrice.Size = new System.Drawing.Size(276, 30);
            this.txtbTotalPrice.TabIndex = 5;
            this.txtbTotalPrice.Text = "0";
            this.txtbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.btnSwitchTable);
            this.panel4.Controls.Add(this.cbbSwitchTable);
            this.panel4.Location = new System.Drawing.Point(16, 33);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(771, 123);
            this.panel4.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Phần_mềm_quản_lý.Properties.Resources.eac099b493bfa415de4a34371f81dd81;
            this.pictureBox1.Location = new System.Drawing.Point(611, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Phần_mềm_quản_lý.Properties.Resources._14297d848462bfd9ef59a3b66b688419;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(203, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSwitchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchTable.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSwitchTable.ForeColor = System.Drawing.Color.White;
            this.btnSwitchTable.Location = new System.Drawing.Point(429, 33);
            this.btnSwitchTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(145, 46);
            this.btnSwitchTable.TabIndex = 6;
            this.btnSwitchTable.Text = "Chuyển bàn";
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // cbbSwitchTable
            // 
            this.cbbSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSwitchTable.FormattingEnabled = true;
            this.cbbSwitchTable.Location = new System.Drawing.Point(231, 42);
            this.cbbSwitchTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbSwitchTable.Name = "cbbSwitchTable";
            this.cbbSwitchTable.Size = new System.Drawing.Size(189, 28);
            this.cbbSwitchTable.TabIndex = 5;
            // 
            // flpTable
            // 
            this.flpTable.BackgroundImage = global::Phần_mềm_quản_lý.Properties.Resources.leaf_icons_vector_design_leaves_green_concept_illustration_isolated_nature_premium_png_2880831;
            this.flpTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flpTable.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.flpTable.Location = new System.Drawing.Point(16, 164);
            this.flpTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(771, 512);
            this.flpTable.TabIndex = 1;
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1285, 690);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtbTotalPrice);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Table Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox txtbTotalPrice;
        private System.Windows.Forms.Button btnDiscount;
        private System.Windows.Forms.NumericUpDown numDiscount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.ComboBox cbbSwitchTable;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvBill;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}