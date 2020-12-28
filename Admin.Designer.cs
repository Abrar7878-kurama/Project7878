namespace WindowsFormsApp1
{
    partial class Admin
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.tleProductDetail = new MetroFramework.Controls.MetroTile();
            this.tleUserDetail = new MetroFramework.Controls.MetroTile();
            this.tleCustomiseProduct = new MetroFramework.Controls.MetroTile();
            this.tleCustomiseUser = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnLogout);
            this.metroPanel1.Controls.Add(this.tleProductDetail);
            this.metroPanel1.Controls.Add(this.tleUserDetail);
            this.metroPanel1.Controls.Add(this.tleCustomiseProduct);
            this.metroPanel1.Controls.Add(this.tleCustomiseUser);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 57);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(754, 370);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(3, 3);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 35);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            // 
            // tleProductDetail
            // 
            this.tleProductDetail.ActiveControl = null;
            this.tleProductDetail.Location = new System.Drawing.Point(65, 222);
            this.tleProductDetail.Name = "tleProductDetail";
            this.tleProductDetail.Size = new System.Drawing.Size(129, 144);
            this.tleProductDetail.TabIndex = 9;
            this.tleProductDetail.Text = "Product Detail";
            this.tleProductDetail.UseSelectable = true;
            // 
            // tleUserDetail
            // 
            this.tleUserDetail.ActiveControl = null;
            this.tleUserDetail.Location = new System.Drawing.Point(582, 48);
            this.tleUserDetail.Name = "tleUserDetail";
            this.tleUserDetail.Size = new System.Drawing.Size(129, 144);
            this.tleUserDetail.TabIndex = 8;
            this.tleUserDetail.Text = "User detail";
            this.tleUserDetail.UseSelectable = true;
            // 
            // tleCustomiseProduct
            // 
            this.tleCustomiseProduct.ActiveControl = null;
            this.tleCustomiseProduct.Location = new System.Drawing.Point(320, 48);
            this.tleCustomiseProduct.Name = "tleCustomiseProduct";
            this.tleCustomiseProduct.Size = new System.Drawing.Size(129, 144);
            this.tleCustomiseProduct.TabIndex = 7;
            this.tleCustomiseProduct.Text = "Customise Product";
            this.tleCustomiseProduct.UseSelectable = true;
            // 
            // tleCustomiseUser
            // 
            this.tleCustomiseUser.ActiveControl = null;
            this.tleCustomiseUser.Location = new System.Drawing.Point(65, 48);
            this.tleCustomiseUser.Name = "tleCustomiseUser";
            this.tleCustomiseUser.Size = new System.Drawing.Size(129, 144);
            this.tleCustomiseUser.TabIndex = 6;
            this.tleCustomiseUser.Text = "Customise User";
            this.tleCustomiseUser.UseSelectable = true;
            this.tleCustomiseUser.Click += new System.EventHandler(this.tleCustomiseUser_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile tleCustomiseUser;
        private MetroFramework.Controls.MetroTile tleUserDetail;
        private MetroFramework.Controls.MetroTile tleCustomiseProduct;
        private MetroFramework.Controls.MetroTile tleProductDetail;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}