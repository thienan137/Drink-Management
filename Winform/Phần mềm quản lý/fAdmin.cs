using Phần_mềm_quản_lý.Form_Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phần_mềm_quản_lý
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnTurnover_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTurnover());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCategory());
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fFood());
        }

        private void btnTableFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fTableFood());
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fAccount());
        }

    }
}
