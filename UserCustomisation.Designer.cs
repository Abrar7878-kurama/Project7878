namespace WindowsFormsApp1
{
    partial class UserCustomisation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tbcUserCustomisation = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.lblAddress = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.btnShowDetail = new MetroFramework.Controls.MetroButton();
            this.lblRole = new MetroFramework.Controls.MetroLabel();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.lblUserName = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.cmbRole = new MetroFramework.Controls.MetroComboBox();
            this.lblUserId = new MetroFramework.Controls.MetroLabel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtUserId = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.lblAddressUpdate = new MetroFramework.Controls.MetroLabel();
            this.cmbRoleUpdate = new MetroFramework.Controls.MetroComboBox();
            this.lblNameUpdate = new MetroFramework.Controls.MetroLabel();
            this.lblPasswordUpdate = new MetroFramework.Controls.MetroLabel();
            this.lblRoleUpdate = new MetroFramework.Controls.MetroLabel();
            this.txtIdUpdate = new MetroFramework.Controls.MetroTextBox();
            this.txtNameUpdate = new MetroFramework.Controls.MetroTextBox();
            this.txtPasswordUpdate = new MetroFramework.Controls.MetroTextBox();
            this.txtAddressUpdate = new MetroFramework.Controls.MetroTextBox();
            this.lblIdUpdate = new MetroFramework.Controls.MetroLabel();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtAutoSearch = new MetroFramework.Controls.MetroTextBox();
            this.lblautoSearch = new MetroFramework.Controls.MetroLabel();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.btnShowDetails = new MetroFramework.Controls.MetroButton();
            this.dgvDelete = new MetroFramework.Controls.MetroGrid();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            this.tbcUserCustomisation.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.tbcUserCustomisation);
            this.metroPanel1.Controls.Add(this.btnBack);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1021, 558);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tbcUserCustomisation
            // 
            this.tbcUserCustomisation.Controls.Add(this.metroTabPage1);
            this.tbcUserCustomisation.Controls.Add(this.metroTabPage2);
            this.tbcUserCustomisation.Location = new System.Drawing.Point(4, 42);
            this.tbcUserCustomisation.Name = "tbcUserCustomisation";
            this.tbcUserCustomisation.SelectedIndex = 1;
            this.tbcUserCustomisation.Size = new System.Drawing.Size(1014, 513);
            this.tbcUserCustomisation.TabIndex = 3;
            this.tbcUserCustomisation.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.lblAddress);
            this.metroTabPage1.Controls.Add(this.txtAddress);
            this.metroTabPage1.Controls.Add(this.btnShowDetail);
            this.metroTabPage1.Controls.Add(this.lblRole);
            this.metroTabPage1.Controls.Add(this.lblPassword);
            this.metroTabPage1.Controls.Add(this.txtUserName);
            this.metroTabPage1.Controls.Add(this.lblUserName);
            this.metroTabPage1.Controls.Add(this.txtPassword);
            this.metroTabPage1.Controls.Add(this.cmbRole);
            this.metroTabPage1.Controls.Add(this.lblUserId);
            this.metroTabPage1.Controls.Add(this.btnAdd);
            this.metroTabPage1.Controls.Add(this.txtUserId);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1006, 471);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Add Staff";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(320, 238);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 19);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(542, 238);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(226, 90);
            this.txtAddress.TabIndex = 14;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnShowDetail
            // 
            this.btnShowDetail.Location = new System.Drawing.Point(678, 346);
            this.btnShowDetail.Name = "btnShowDetail";
            this.btnShowDetail.Size = new System.Drawing.Size(90, 38);
            this.btnShowDetail.TabIndex = 11;
            this.btnShowDetail.Text = "Show Detail";
            this.btnShowDetail.UseSelectable = true;
            this.btnShowDetail.Click += new System.EventHandler(this.btnShowDetail_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(320, 192);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(35, 19);
            this.lblRole.TabIndex = 10;
            this.lblRole.Text = "Role";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(320, 149);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(63, 19);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(542, 103);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(226, 23);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(320, 103);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(75, 19);
            this.lblUserName.TabIndex = 7;
            this.lblUserName.Text = "User Name";
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(542, 149);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(226, 23);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbRole
            // 
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.ItemHeight = 23;
            this.cmbRole.Items.AddRange(new object[] {
            "Admin",
            "Manager"});
            this.cmbRole.Location = new System.Drawing.Point(542, 192);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(226, 29);
            this.cmbRole.TabIndex = 5;
            this.cmbRole.UseSelectable = true;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(320, 55);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(50, 19);
            this.lblUserId.TabIndex = 4;
            this.lblUserId.Text = "User Id";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(542, 346);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 38);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            // 
            // txtUserId
            // 
            // 
            // 
            // 
            this.txtUserId.CustomButton.Image = null;
            this.txtUserId.CustomButton.Location = new System.Drawing.Point(204, 1);
            this.txtUserId.CustomButton.Name = "";
            this.txtUserId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserId.CustomButton.TabIndex = 1;
            this.txtUserId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserId.CustomButton.UseSelectable = true;
            this.txtUserId.CustomButton.Visible = false;
            this.txtUserId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserId.Lines = new string[0];
            this.txtUserId.Location = new System.Drawing.Point(542, 55);
            this.txtUserId.MaxLength = 32767;
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.PasswordChar = '\0';
            this.txtUserId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserId.SelectedText = "";
            this.txtUserId.SelectionLength = 0;
            this.txtUserId.SelectionStart = 0;
            this.txtUserId.ShortcutsEnabled = true;
            this.txtUserId.Size = new System.Drawing.Size(226, 23);
            this.txtUserId.TabIndex = 2;
            this.txtUserId.UseSelectable = true;
            this.txtUserId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.lblAddressUpdate);
            this.metroTabPage2.Controls.Add(this.cmbRoleUpdate);
            this.metroTabPage2.Controls.Add(this.lblNameUpdate);
            this.metroTabPage2.Controls.Add(this.lblPasswordUpdate);
            this.metroTabPage2.Controls.Add(this.lblRoleUpdate);
            this.metroTabPage2.Controls.Add(this.txtIdUpdate);
            this.metroTabPage2.Controls.Add(this.txtNameUpdate);
            this.metroTabPage2.Controls.Add(this.txtPasswordUpdate);
            this.metroTabPage2.Controls.Add(this.txtAddressUpdate);
            this.metroTabPage2.Controls.Add(this.lblIdUpdate);
            this.metroTabPage2.Controls.Add(this.btnSave);
            this.metroTabPage2.Controls.Add(this.txtAutoSearch);
            this.metroTabPage2.Controls.Add(this.lblautoSearch);
            this.metroTabPage2.Controls.Add(this.btnSearch);
            this.metroTabPage2.Controls.Add(this.btnShowDetails);
            this.metroTabPage2.Controls.Add(this.dgvDelete);
            this.metroTabPage2.Controls.Add(this.txtSearch);
            this.metroTabPage2.Controls.Add(this.btnDelete);
            this.metroTabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1006, 471);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Delete Staff";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // lblAddressUpdate
            // 
            this.lblAddressUpdate.AutoSize = true;
            this.lblAddressUpdate.Location = new System.Drawing.Point(3, 156);
            this.lblAddressUpdate.Name = "lblAddressUpdate";
            this.lblAddressUpdate.Size = new System.Drawing.Size(56, 19);
            this.lblAddressUpdate.TabIndex = 28;
            this.lblAddressUpdate.Text = "Address";
            // 
            // cmbRoleUpdate
            // 
            this.cmbRoleUpdate.AutoCompleteCustomSource.AddRange(new string[] {
            "Admin",
            "Manager"});
            this.cmbRoleUpdate.FormattingEnabled = true;
            this.cmbRoleUpdate.ItemHeight = 23;
            this.cmbRoleUpdate.Items.AddRange(new object[] {
            "Admin",
            "Manager"});
            this.cmbRoleUpdate.Location = new System.Drawing.Point(99, 121);
            this.cmbRoleUpdate.Name = "cmbRoleUpdate";
            this.cmbRoleUpdate.Size = new System.Drawing.Size(195, 29);
            this.cmbRoleUpdate.TabIndex = 27;
            this.cmbRoleUpdate.UseSelectable = true;
            // 
            // lblNameUpdate
            // 
            this.lblNameUpdate.AutoSize = true;
            this.lblNameUpdate.Location = new System.Drawing.Point(3, 50);
            this.lblNameUpdate.Name = "lblNameUpdate";
            this.lblNameUpdate.Size = new System.Drawing.Size(75, 19);
            this.lblNameUpdate.TabIndex = 26;
            this.lblNameUpdate.Text = "User Name";
            // 
            // lblPasswordUpdate
            // 
            this.lblPasswordUpdate.AutoSize = true;
            this.lblPasswordUpdate.Location = new System.Drawing.Point(3, 87);
            this.lblPasswordUpdate.Name = "lblPasswordUpdate";
            this.lblPasswordUpdate.Size = new System.Drawing.Size(63, 19);
            this.lblPasswordUpdate.TabIndex = 25;
            this.lblPasswordUpdate.Text = "Password";
            // 
            // lblRoleUpdate
            // 
            this.lblRoleUpdate.AutoSize = true;
            this.lblRoleUpdate.Location = new System.Drawing.Point(3, 124);
            this.lblRoleUpdate.Name = "lblRoleUpdate";
            this.lblRoleUpdate.Size = new System.Drawing.Size(35, 19);
            this.lblRoleUpdate.TabIndex = 24;
            this.lblRoleUpdate.Text = "Role";
            // 
            // txtIdUpdate
            // 
            // 
            // 
            // 
            this.txtIdUpdate.CustomButton.Image = null;
            this.txtIdUpdate.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtIdUpdate.CustomButton.Name = "";
            this.txtIdUpdate.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtIdUpdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtIdUpdate.CustomButton.TabIndex = 1;
            this.txtIdUpdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtIdUpdate.CustomButton.UseSelectable = true;
            this.txtIdUpdate.CustomButton.Visible = false;
            this.txtIdUpdate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtIdUpdate.Lines = new string[0];
            this.txtIdUpdate.Location = new System.Drawing.Point(99, 13);
            this.txtIdUpdate.MaxLength = 32767;
            this.txtIdUpdate.Name = "txtIdUpdate";
            this.txtIdUpdate.PasswordChar = '\0';
            this.txtIdUpdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIdUpdate.SelectedText = "";
            this.txtIdUpdate.SelectionLength = 0;
            this.txtIdUpdate.SelectionStart = 0;
            this.txtIdUpdate.ShortcutsEnabled = true;
            this.txtIdUpdate.Size = new System.Drawing.Size(195, 31);
            this.txtIdUpdate.TabIndex = 23;
            this.txtIdUpdate.UseSelectable = true;
            this.txtIdUpdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtIdUpdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNameUpdate
            // 
            // 
            // 
            // 
            this.txtNameUpdate.CustomButton.Image = null;
            this.txtNameUpdate.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtNameUpdate.CustomButton.Name = "";
            this.txtNameUpdate.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtNameUpdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameUpdate.CustomButton.TabIndex = 1;
            this.txtNameUpdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameUpdate.CustomButton.UseSelectable = true;
            this.txtNameUpdate.CustomButton.Visible = false;
            this.txtNameUpdate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtNameUpdate.Lines = new string[0];
            this.txtNameUpdate.Location = new System.Drawing.Point(99, 50);
            this.txtNameUpdate.MaxLength = 32767;
            this.txtNameUpdate.Name = "txtNameUpdate";
            this.txtNameUpdate.PasswordChar = '\0';
            this.txtNameUpdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameUpdate.SelectedText = "";
            this.txtNameUpdate.SelectionLength = 0;
            this.txtNameUpdate.SelectionStart = 0;
            this.txtNameUpdate.ShortcutsEnabled = true;
            this.txtNameUpdate.Size = new System.Drawing.Size(195, 31);
            this.txtNameUpdate.TabIndex = 22;
            this.txtNameUpdate.UseSelectable = true;
            this.txtNameUpdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameUpdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPasswordUpdate
            // 
            // 
            // 
            // 
            this.txtPasswordUpdate.CustomButton.Image = null;
            this.txtPasswordUpdate.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtPasswordUpdate.CustomButton.Name = "";
            this.txtPasswordUpdate.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtPasswordUpdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordUpdate.CustomButton.TabIndex = 1;
            this.txtPasswordUpdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordUpdate.CustomButton.UseSelectable = true;
            this.txtPasswordUpdate.CustomButton.Visible = false;
            this.txtPasswordUpdate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPasswordUpdate.Lines = new string[0];
            this.txtPasswordUpdate.Location = new System.Drawing.Point(99, 87);
            this.txtPasswordUpdate.MaxLength = 32767;
            this.txtPasswordUpdate.Name = "txtPasswordUpdate";
            this.txtPasswordUpdate.PasswordChar = '\0';
            this.txtPasswordUpdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordUpdate.SelectedText = "";
            this.txtPasswordUpdate.SelectionLength = 0;
            this.txtPasswordUpdate.SelectionStart = 0;
            this.txtPasswordUpdate.ShortcutsEnabled = true;
            this.txtPasswordUpdate.Size = new System.Drawing.Size(195, 31);
            this.txtPasswordUpdate.TabIndex = 21;
            this.txtPasswordUpdate.UseSelectable = true;
            this.txtPasswordUpdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordUpdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAddressUpdate
            // 
            // 
            // 
            // 
            this.txtAddressUpdate.CustomButton.Image = null;
            this.txtAddressUpdate.CustomButton.Location = new System.Drawing.Point(107, 2);
            this.txtAddressUpdate.CustomButton.Name = "";
            this.txtAddressUpdate.CustomButton.Size = new System.Drawing.Size(85, 85);
            this.txtAddressUpdate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddressUpdate.CustomButton.TabIndex = 1;
            this.txtAddressUpdate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddressUpdate.CustomButton.UseSelectable = true;
            this.txtAddressUpdate.CustomButton.Visible = false;
            this.txtAddressUpdate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtAddressUpdate.Lines = new string[0];
            this.txtAddressUpdate.Location = new System.Drawing.Point(99, 156);
            this.txtAddressUpdate.MaxLength = 32767;
            this.txtAddressUpdate.Name = "txtAddressUpdate";
            this.txtAddressUpdate.PasswordChar = '\0';
            this.txtAddressUpdate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddressUpdate.SelectedText = "";
            this.txtAddressUpdate.SelectionLength = 0;
            this.txtAddressUpdate.SelectionStart = 0;
            this.txtAddressUpdate.ShortcutsEnabled = true;
            this.txtAddressUpdate.Size = new System.Drawing.Size(195, 90);
            this.txtAddressUpdate.TabIndex = 20;
            this.txtAddressUpdate.UseSelectable = true;
            this.txtAddressUpdate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddressUpdate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblIdUpdate
            // 
            this.lblIdUpdate.AutoSize = true;
            this.lblIdUpdate.Location = new System.Drawing.Point(3, 13);
            this.lblIdUpdate.Name = "lblIdUpdate";
            this.lblIdUpdate.Size = new System.Drawing.Size(50, 19);
            this.lblIdUpdate.TabIndex = 19;
            this.lblIdUpdate.Text = "User Id";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(99, 252);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(83, 31);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            // 
            // txtAutoSearch
            // 
            // 
            // 
            // 
            this.txtAutoSearch.CustomButton.Image = null;
            this.txtAutoSearch.CustomButton.Location = new System.Drawing.Point(168, 1);
            this.txtAutoSearch.CustomButton.Name = "";
            this.txtAutoSearch.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtAutoSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAutoSearch.CustomButton.TabIndex = 1;
            this.txtAutoSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAutoSearch.CustomButton.UseSelectable = true;
            this.txtAutoSearch.CustomButton.Visible = false;
            this.txtAutoSearch.Lines = new string[0];
            this.txtAutoSearch.Location = new System.Drawing.Point(805, 7);
            this.txtAutoSearch.MaxLength = 32767;
            this.txtAutoSearch.Name = "txtAutoSearch";
            this.txtAutoSearch.PasswordChar = '\0';
            this.txtAutoSearch.PromptText = "Type Name to Search";
            this.txtAutoSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAutoSearch.SelectedText = "";
            this.txtAutoSearch.SelectionLength = 0;
            this.txtAutoSearch.SelectionStart = 0;
            this.txtAutoSearch.ShortcutsEnabled = true;
            this.txtAutoSearch.Size = new System.Drawing.Size(198, 31);
            this.txtAutoSearch.TabIndex = 9;
            this.txtAutoSearch.UseSelectable = true;
            this.txtAutoSearch.WaterMark = "Type Name to Search";
            this.txtAutoSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAutoSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAutoSearch.TextChanged += new System.EventHandler(this.txtAutoSearch_TextChanged);
            // 
            // lblautoSearch
            // 
            this.lblautoSearch.AutoSize = true;
            this.lblautoSearch.Location = new System.Drawing.Point(664, 13);
            this.lblautoSearch.Name = "lblautoSearch";
            this.lblautoSearch.Size = new System.Drawing.Size(135, 19);
            this.lblautoSearch.TabIndex = 8;
            this.lblautoSearch.Text = "Type Name to Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(316, 252);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Location = new System.Drawing.Point(922, 243);
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(81, 40);
            this.btnShowDetails.TabIndex = 6;
            this.btnShowDetails.Text = "Show Details";
            this.btnShowDetails.UseSelectable = true;
            // 
            // dgvDelete
            // 
            this.dgvDelete.AllowUserToResizeRows = false;
            this.dgvDelete.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDelete.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDelete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDelete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDelete.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.password,
            this.address,
            this.role});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDelete.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDelete.EnableHeadersVisualStyles = false;
            this.dgvDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvDelete.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDelete.Location = new System.Drawing.Point(3, 289);
            this.dgvDelete.Name = "dgvDelete";
            this.dgvDelete.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDelete.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDelete.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDelete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDelete.Size = new System.Drawing.Size(1005, 179);
            this.dgvDelete.TabIndex = 5;
            this.dgvDelete.DoubleClick += new System.EventHandler(this.dgvDelete_DoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "User ID";
            this.id.Name = "id";
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "User Name";
            this.name.Name = "name";
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.Name = "password";
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "Address";
            this.address.Name = "address";
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.Name = "role";
            // 
            // txtSearch
            // 
            this.txtSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(29, 29);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(397, 252);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Write Id to Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(195, 31);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Write Id to Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(620, 252);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(86, 32);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseSelectable = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserCustomisation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 644);
            this.Controls.Add(this.metroPanel1);
            this.Name = "UserCustomisation";
            this.Text = "Form1";
            this.metroPanel1.ResumeLayout(false);
            this.tbcUserCustomisation.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroTabControl tbcUserCustomisation;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroButton btnShowDetail;
        private MetroFramework.Controls.MetroLabel lblRole;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroLabel lblUserName;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroComboBox cmbRole;
        private MetroFramework.Controls.MetroLabel lblUserId;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtUserId;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton btnShowDetails;
        private MetroFramework.Controls.MetroGrid dgvDelete;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroLabel lblAddress;
        private MetroFramework.Controls.MetroTextBox txtAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private MetroFramework.Controls.MetroTextBox txtAutoSearch;
        private MetroFramework.Controls.MetroLabel lblautoSearch;
        private MetroFramework.Controls.MetroLabel lblAddressUpdate;
        private MetroFramework.Controls.MetroComboBox cmbRoleUpdate;
        private MetroFramework.Controls.MetroLabel lblNameUpdate;
        private MetroFramework.Controls.MetroLabel lblPasswordUpdate;
        private MetroFramework.Controls.MetroLabel lblRoleUpdate;
        private MetroFramework.Controls.MetroTextBox txtIdUpdate;
        private MetroFramework.Controls.MetroTextBox txtNameUpdate;
        private MetroFramework.Controls.MetroTextBox txtPasswordUpdate;
        private MetroFramework.Controls.MetroTextBox txtAddressUpdate;
        private MetroFramework.Controls.MetroLabel lblIdUpdate;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}