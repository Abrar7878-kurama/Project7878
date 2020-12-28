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
    public partial class UserDetails : MetroForm
    {
        private DataAccess Da { set; get; }
        private DataSet Ds { set; get; }

        public UserDetails()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            string query = "select * from LOGIN";
            this.PopulateGridView(query);
        }

        private void PopulateGridView(string sql)
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvUserDetail.AutoGenerateColumns = false;
            this.dgvUserDetail.DataSource = this.Ds.Tables[0];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            UserCustomisation userCustomisation = new UserCustomisation();
            userCustomisation.Visible = true;
        }
    }
}
