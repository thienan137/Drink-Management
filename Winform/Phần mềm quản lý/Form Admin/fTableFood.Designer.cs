
namespace Phần_mềm_quản_lý.Form_Admin
{
    partial class fTableFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTableFood));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtbTableName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtbTableID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvTableFood = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowTable = new System.Windows.Forms.Button();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnNewTable = new System.Windows.Forms.Button();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbStatus = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTableFood)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.panel8);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Location = new System.Drawing.Point(509, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 322);
            this.panel3.TabIndex = 10;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtbStatus);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(11, 95);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(319, 35);
            this.panel9.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Trạng thái";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtbTableName);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Location = new System.Drawing.Point(11, 54);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(319, 35);
            this.panel8.TabIndex = 7;
            // 
            // txtbTableName
            // 
            this.txtbTableName.BackColor = System.Drawing.Color.White;
            this.txtbTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTableName.Location = new System.Drawing.Point(104, 6);
            this.txtbTableName.Name = "txtbTableName";
            this.txtbTableName.Size = new System.Drawing.Size(201, 24);
            this.txtbTableName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bàn";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtbTableID);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(11, 13);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(319, 35);
            this.panel7.TabIndex = 6;
            // 
            // txtbTableID
            // 
            this.txtbTableID.BackColor = System.Drawing.Color.White;
            this.txtbTableID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTableID.Location = new System.Drawing.Point(104, 6);
            this.txtbTableID.Name = "txtbTableID";
            this.txtbTableID.ReadOnly = true;
            this.txtbTableID.Size = new System.Drawing.Size(201, 24);
            this.txtbTableID.TabIndex = 2;
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
            this.panel1.Controls.Add(this.dtgvTableFood);
            this.panel1.Location = new System.Drawing.Point(1, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 322);
            this.panel1.TabIndex = 9;
            // 
            // dtgvTableFood
            // 
            this.dtgvTableFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTableFood.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.status});
            this.dtgvTableFood.Location = new System.Drawing.Point(3, 3);
            this.dtgvTableFood.Name = "dtgvTableFood";
            this.dtgvTableFood.Size = new System.Drawing.Size(496, 316);
            this.dtgvTableFood.TabIndex = 0;
            this.dtgvTableFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTableFood_CellClick);
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
            this.name.HeaderText = "Tên bàn";
            this.name.Name = "name";
            this.name.Width = 210;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Tình trạng";
            this.status.Name = "status";
            this.status.Width = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnShowTable);
            this.panel2.Controls.Add(this.btnEditTable);
            this.panel2.Controls.Add(this.btnDeleteTable);
            this.panel2.Controls.Add(this.btnNewTable);
            this.panel2.Controls.Add(this.btnAddTable);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 109);
            this.panel2.TabIndex = 8;
            // 
            // btnShowTable
            // 
            this.btnShowTable.BackColor = System.Drawing.Color.ForestGreen;
            this.btnShowTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowTable.ForeColor = System.Drawing.Color.White;
            this.btnShowTable.Location = new System.Drawing.Point(602, 57);
            this.btnShowTable.Name = "btnShowTable";
            this.btnShowTable.Size = new System.Drawing.Size(83, 34);
            this.btnShowTable.TabIndex = 2;
            this.btnShowTable.Text = "Xem";
            this.btnShowTable.UseVisualStyleBackColor = false;
            this.btnShowTable.Click += new System.EventHandler(this.btnShowTable_Click);
            // 
            // btnEditTable
            // 
            this.btnEditTable.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEditTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditTable.ForeColor = System.Drawing.Color.White;
            this.btnEditTable.Location = new System.Drawing.Point(509, 57);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(83, 34);
            this.btnEditTable.TabIndex = 3;
            this.btnEditTable.Text = "Sửa";
            this.btnEditTable.UseVisualStyleBackColor = false;
            this.btnEditTable.Click += new System.EventHandler(this.btnEditTable_Click);
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.BackColor = System.Drawing.Color.ForestGreen;
            this.btnDeleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTable.ForeColor = System.Drawing.Color.White;
            this.btnDeleteTable.Location = new System.Drawing.Point(416, 57);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(83, 34);
            this.btnDeleteTable.TabIndex = 4;
            this.btnDeleteTable.Text = "Xóa";
            this.btnDeleteTable.UseVisualStyleBackColor = false;
            this.btnDeleteTable.Click += new System.EventHandler(this.btnDeleteTable_Click);
            // 
            // btnNewTable
            // 
            this.btnNewTable.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNewTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewTable.ForeColor = System.Drawing.Color.White;
            this.btnNewTable.Location = new System.Drawing.Point(196, 57);
            this.btnNewTable.Name = "btnNewTable";
            this.btnNewTable.Size = new System.Drawing.Size(117, 34);
            this.btnNewTable.TabIndex = 5;
            this.btnNewTable.Text = "Thêm mới";
            this.btnNewTable.UseVisualStyleBackColor = false;
            this.btnNewTable.Click += new System.EventHandler(this.btnNewTable_Click);
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.ForeColor = System.Drawing.Color.White;
            this.btnAddTable.Location = new System.Drawing.Point(323, 57);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(83, 34);
            this.btnAddTable.TabIndex = 6;
            this.btnAddTable.Text = "Thêm";
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(333, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ BÀN ĂN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtbStatus
            // 
            this.txtbStatus.BackColor = System.Drawing.Color.White;
            this.txtbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbStatus.Location = new System.Drawing.Point(104, 5);
            this.txtbStatus.Name = "txtbStatus";
            this.txtbStatus.Size = new System.Drawing.Size(201, 24);
            this.txtbStatus.TabIndex = 2;
            // 
            // fTableFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTableFood";
            this.Text = "fTableFood";
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTableFood)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtbTableName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtbTableID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvTableFood;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnShowTable;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnNewTable;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.TextBox txtbStatus;
    }
}