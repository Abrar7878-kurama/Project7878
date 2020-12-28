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
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class UserCustomisation : MetroForm
    {
        private DataAccess Da { set; get; }
        private DataSet Ds { set; get; }
        private string Querry { set; get; }

        public UserCustomisation()
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.PopulateGridView();
            this.IdGenerate();
        }

        private bool IsValidToAdd()
        {
            if (String.IsNullOrEmpty(this.txtUserId.Text) || String.IsNullOrEmpty(this.txtUserName.Text) || String.IsNullOrEmpty(this.txtPassword.Text) || String.IsNullOrEmpty(this.txtAddress.Text) || String.IsNullOrEmpty(this.cmbRole.Text))

            {
                return false;
            }

            else
            {
                return true;
            }
                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                bool decision = this.IsValidToAdd();

                if (decision)
                {
                    this.Querry = @"insert into LOGIN values ('" + this.txtUserId.Text + "','" + this.txtUserName.Text + "','" + this.txtPassword.Text + "','" + this.txtAddress.Text + "','" + this.cmbRole.Text + "');";
                    int row = this.Da.ExecuteUpdateQuery(this.Querry);

                    if (row == 1)
                        MessageBox.Show("User is created");
                    else
                        MessageBox.Show("Something went wrong");

                    this.PopulateGridView(this.Querry);
                }
                else { MessageBox.Show("Fill all the fields"); }
            }


            catch (Exception exe)
            {
                MessageBox.Show("Error:" + exe.Message.ToString());
            }
        }

       private void IdGenerate()
        {
            string query = "select * from LOGIN order by id desc";
            this.Ds = this.Da.ExecuteQuery(query);

            string previousId = this.Ds.Tables[0].Rows[0][0].ToString();
            string[] temp = previousId.Split('A');
            int serialNo = Convert.ToInt32(temp[1]);
            string nextId = "A" + (++serialNo).ToString("000");
            this.txtUserId.Text = nextId;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Admin admin = new Admin();
            admin.Visible = true;
        }

        private void btnShowDetail_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            UserDetails userDetail = new UserDetails();
            userDetail.Visible = true;
        }

        private void PopulateGridView(string sql= "select * from LOGIN;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);
            this.dgvDelete.AutoGenerateColumns = false;
            this.dgvDelete.DataSource = this.Ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.Querry = @"select * from LOGIN where id = '" + this.txtSearch.Text + "';";
            this.PopulateGridView(this.Querry);
         }

        private void txtAutoSearch_TextChanged(object sender, EventArgs e)
        {
            this.Querry = @"select * from LOGIN where name like '" + this.txtAutoSearch.Text + "%';";
            this.PopulateGridView(this.Querry);
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvDelete.CurrentRow.Cells[0].Value.ToString();
                string name = this.dgvDelete.CurrentRow.Cells[1].Value.ToString();
                     
                this.Querry = @"delete from LOGIN where id = '"+ id +"';";
                int row = this.Da.ExecuteUpdateQuery(this.Querry);

                if (row == 1)
                    MessageBox.Show(name + "has been deleted successfully");
                else
                    MessageBox.Show("Deletion failed");

                this.PopulateGridView();
            }
            catch(Exception exe)
            {
                MessageBox.Show("Error:" + exe.Message);
            }
        }

        private void dgvDelete_DoubleClick(object sender, EventArgs e)
        {
            this.txtIdUpdate.Text = this.dgvDelete.CurrentRow.Cells["id"].Value.ToString();
            this.txtNameUpdate.Text = this.dgvDelete.CurrentRow.Cells["name"].Value.ToString();
            this.txtPasswordUpdate.Text = this.dgvDelete.CurrentRow.Cells["password"].Value.ToString();
            this.cmbRoleUpdate.Text = this.dgvDelete.CurrentRow.Cells["role"].Value.ToString();
            this.txtAddressUpdate.Text = this.dgvDelete.CurrentRow.Cells["address"].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool decition = this.IsValidToAdd();
                if(decition)
                {
                    this.Querry = @"select * from LOGIN where id = '" + this.txtIdUpdate.Text + "';";
                    DataTable dt = this.Da.ExecuteQueryTable(this.Querry);
                     if(dt.Rows.Count==1)
                    {
                        this.Querry = @"update LOGIN set name ='" + this.txtNameUpdate.Text + "', password ='" + this.txtPasswordUpdate.Text + "', address = '" + this.txtAddressUpdate.Text + "', role = '" + this.cmbRoleUpdate.Text + "');";

                        int row = this.Da.ExecuteUpdateQuery(this.Querry);

                        if (row == 1)
                            MessageBox.Show("Account updated successfully");
                        else
                            MessageBox.Show("Update failed");

                        this.PopulateGridView();
                    }
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show("Error:" + exe.Message);
            }
        }

        
    }
}
