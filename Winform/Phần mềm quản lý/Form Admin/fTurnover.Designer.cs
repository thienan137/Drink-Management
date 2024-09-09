
namespace Phần_mềm_quản_lý
{
    partial class fTurnover
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fTurnover));
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnStatistical = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvBill);
            this.panel3.Location = new System.Drawing.Point(2, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(848, 330);
            this.panel3.TabIndex = 5;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AllowUserToOrderColumns = true;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(3, 8);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.RowHeadersWidth = 50;
            this.dtgvBill.Size = new System.Drawing.Size(842, 319);
            this.dtgvBill.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnStatistical);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dtpkToDate);
            this.panel2.Controls.Add(this.dtpkFromDate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(848, 109);
            this.panel2.TabIndex = 4;
            // 
            // btnStatistical
            // 
            this.btnStatistical.BackColor = System.Drawing.Color.ForestGreen;
            this.btnStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistical.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistical.ForeColor = System.Drawing.Color.White;
            this.btnStatistical.Location = new System.Drawing.Point(364, 57);
            this.btnStatistical.Name = "btnStatistical";
            this.btnStatistical.Size = new System.Drawing.Size(117, 38);
            this.btnStatistical.TabIndex = 3;
            this.btnStatistical.Text = "Thống kê";
            this.btnStatistical.UseVisualStyleBackColor = false;
            this.btnStatistical.Click += new System.EventHandler(this.btnStatistical_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.ForestGreen;
            this.label3.Location = new System.Drawing.Point(653, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(135, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Từ ngày";
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Location = new System.Drawing.Point(568, 64);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(226, 22);
            this.dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Location = new System.Drawing.Point(58, 64);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(226, 22);
            this.dtpkFromDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Jokerman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(309, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ DOANH THU";
            // 
            // fTurnover
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 440);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fTurnover";
            this.Text = "fTurnover";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStatistical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Label label1;
    }
}