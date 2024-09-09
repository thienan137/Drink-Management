
namespace Phần_mềm_quản_lý.Form_Admin
{
    partial class fCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCategory));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtbCategory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtbCategoryID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnShowCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnNewCategory = new System.Windows.Forms.Button();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(509, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 322);
            this.panel3.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtbCategory);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(11, 58);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(319, 35);
            this.panel8.TabIndex = 7;
            // 
            // txtbCategory
            // 
            this.txtbCategory.BackColor = System.Drawing.Color.White;
            this.txtbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCategory.Location = new System.Drawing.Point(115, 5);
            this.txtbCategory.Name = "txtbCategory";
            this.txtbCategory.Size = new System.Drawing.Size(201, 24);
            this.txtbCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên danh mục";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtbCategoryID);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(11, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 35);
            this.panel7.TabIndex = 6;
            // 
            // txtbCategoryID
            // 
            this.txtbCategoryID.BackColor = System.Drawing.Color.White;
            this.txtbCategoryID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbCategoryID.Location = new System.Drawing.Point(115, 8);
            this.txtbCategoryID.Name = "txtbCategoryID";
            this.txtbCategoryID.ReadOnly = true;
            this.txtbCategoryID.Size = new System.Drawing.Size(201, 24);
            this.txtbCategoryID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "ID ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvCategory);
            this.panel1.Location = new System.Drawing.Point(1, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 322);
            this.panel1.TabIndex = 9;
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name});
            this.dtgvCategory.Location = new System.Drawing.Point(3, 3);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.Size = new System.Drawing.Size(496, 316);
            this.dtgvCategory.TabIndex = 0;
            this.dtgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategory_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Tên danh mục";
            this.name.Name = "name";
            this.name.Width = 360;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnShowCategory);
            this.panel2.Controls.Add(this.btnEditCategory);
            this.panel2.Controls.Add(this.btnDeleteCategory);
            this.panel2.Controls.Add(this.btnNewCategory);
            this.panel2.Controls.Add(this.btnAddCategory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 109);
            this.panel2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(328, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DANH MỤC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnShowCategory
            // 
            this.btnShowCategory.BackColor = System.Drawing.Color.ForestGreen;
            this.btnShowCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCategory.ForeColor = System.Drawing.Color.White;
            this.btnShowCategory.Location = new System.Drawing.Point(602, 57);
            this.btnShowCategory.Name = "btnShowCategory";
            this.btnShowCategory.Size = new System.Drawing.Size(83, 34);
            this.btnShowCategory.TabIndex = 2;
            this.btnShowCategory.Text = "Xem";
            this.btnShowCategory.UseVisualStyleBackColor = false;
            this.btnShowCategory.Click += new System.EventHandler(this.btnShowCategory_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCategory.ForeColor = System.Drawing.Color.White;
            this.btnEditCategory.Location = new System.Drawing.Point(509, 57);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(83, 34);
            this.btnEditCategory.TabIndex = 3;
            this.btnEditCategory.Text = "Sửa";
            this.btnEditCategory.UseVisualStyleBackColor = false;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDeleteCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.ForeColor = System.Drawing.Color.White;
            this.btnDeleteCategory.Location = new System.Drawing.Point(416, 57);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(83, 34);
            this.btnDeleteCategory.TabIndex = 4;
            this.btnDeleteCategory.Text = "Xóa";
            this.btnDeleteCategory.UseVisualStyleBackColor = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnNewCategory
            // 
            this.btnNewCategory.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewCategory.ForeColor = System.Drawing.Color.White;
            this.btnNewCategory.Location = new System.Drawing.Point(196, 57);
            this.btnNewCategory.Name = "btnNewCategory";
            this.btnNewCategory.Size = new System.Drawing.Size(117, 34);
            this.btnNewCategory.TabIndex = 5;
            this.btnNewCategory.Text = "Thêm mới";
            this.btnNewCategory.UseVisualStyleBackColor = false;
            this.btnNewCategory.Click += new System.EventHandler(this.btnNewCategory_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Location = new System.Drawing.Point(323, 57);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(83, 34);
            this.btnAddCategory.TabIndex = 6;
            this.btnAddCategory.Text = "Thêm";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click_1);
            // 
            // fCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCategory";
            this.Text = "fCategory";
            this.panel3.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtbCategoryID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button btnShowCategory;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.Button btnNewCategory;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Label label1;
    }
}