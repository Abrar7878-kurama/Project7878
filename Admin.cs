using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace WindowsFormsApp1
{
    public partial class Admin : MetroForm
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void tleCustomiseUser_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserCustomisation userCustomise = new UserCustomisation();
            userCustomise.Visible = true;
        }
    }
}
