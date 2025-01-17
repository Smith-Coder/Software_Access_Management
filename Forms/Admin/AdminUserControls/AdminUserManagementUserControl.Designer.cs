﻿namespace File_Acess_Management.Forms.Admin.ManagerUserControls
{
    partial class AdminUserManagementUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUserManagementUserControl));
            this.addressErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.emailErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.passErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.userNameErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.phoneErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.updateButton = new System.Windows.Forms.Button();
            this.addressText = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneNumberText = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.userRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.tickPicBox = new System.Windows.Forms.PictureBox();
            this.passPicBox = new System.Windows.Forms.PictureBox();
            this.namePicBox = new System.Windows.Forms.PictureBox();
            this.emailPicBox = new System.Windows.Forms.PictureBox();
            this.phonePicBox = new System.Windows.Forms.PictureBox();
            this.addressPicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRecordDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressErrorProvider
            // 
            this.addressErrorProvider.ContainerControl = this;
            // 
            // emailErrorProvider
            // 
            this.emailErrorProvider.ContainerControl = this;
            // 
            // nameErrorProvider
            // 
            this.nameErrorProvider.ContainerControl = this;
            // 
            // passErrorProvider
            // 
            this.passErrorProvider.ContainerControl = this;
            // 
            // userNameErrorProvider
            // 
            this.userNameErrorProvider.ContainerControl = this;
            // 
            // roleComboBox
            // 
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(221, 94);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(177, 21);
            this.roleComboBox.TabIndex = 38;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(86, 97);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(88, 20);
            this.roleLabel.TabIndex = 37;
            this.roleLabel.Text = "Role Name";
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(495, 164);
            this.resetButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 37);
            this.resetButton.TabIndex = 36;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(362, 164);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(96, 37);
            this.deleteButton.TabIndex = 35;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click_1);
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(221, 58);
            this.passwordText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(177, 26);
            this.passwordText.TabIndex = 30;
            this.passwordText.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // userNameText
            // 
            this.userNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameText.Location = new System.Drawing.Point(221, 25);
            this.userNameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(177, 26);
            this.userNameText.TabIndex = 28;
            this.userNameText.Leave += new System.EventHandler(this.userNameText_Leave);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(86, 29);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(89, 20);
            this.userNameLabel.TabIndex = 27;
            this.userNameLabel.Text = "User Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(86, 62);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 29;
            this.passwordLabel.Text = "Password";
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.Location = new System.Drawing.Point(221, 129);
            this.nameText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(177, 26);
            this.nameText.TabIndex = 33;
            this.nameText.Leave += new System.EventHandler(this.nameText_Leave_1);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(86, 134);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 32;
            this.nameLabel.Text = "Name";
            // 
            // addUserButton
            // 
            this.addUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserButton.Location = new System.Drawing.Point(91, 164);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(96, 37);
            this.addUserButton.TabIndex = 31;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click_1);
            // 
            // phoneErrorProvider
            // 
            this.phoneErrorProvider.ContainerControl = this;
            // 
            // updateButton
            // 
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.Location = new System.Drawing.Point(221, 164);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(96, 37);
            this.updateButton.TabIndex = 34;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressText.Location = new System.Drawing.Point(557, 73);
            this.addressText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(175, 26);
            this.addressText.TabIndex = 11;
            this.addressText.Leave += new System.EventHandler(this.addressText_Leave);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(422, 77);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(68, 20);
            this.addressLabel.TabIndex = 10;
            this.addressLabel.Text = "Address";
            // 
            // phoneNumberText
            // 
            this.phoneNumberText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberText.Location = new System.Drawing.Point(557, 37);
            this.phoneNumberText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneNumberText.Name = "phoneNumberText";
            this.phoneNumberText.Size = new System.Drawing.Size(175, 26);
            this.phoneNumberText.TabIndex = 9;
            this.phoneNumberText.Leave += new System.EventHandler(this.phoneNumberText_Leave);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(422, 41);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneNumberLabel.TabIndex = 8;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // emailText
            // 
            this.emailText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailText.Location = new System.Drawing.Point(557, 4);
            this.emailText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(175, 26);
            this.emailText.TabIndex = 7;
            this.emailText.Leave += new System.EventHandler(this.emailText_Leave);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(422, 8);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(48, 20);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // userRecordDataGridView
            // 
            this.userRecordDataGridView.AllowUserToAddRows = false;
            this.userRecordDataGridView.AllowUserToDeleteRows = false;
            this.userRecordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userRecordDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.userRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userRecordDataGridView.Location = new System.Drawing.Point(3, 191);
            this.userRecordDataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userRecordDataGridView.MultiSelect = false;
            this.userRecordDataGridView.Name = "userRecordDataGridView";
            this.userRecordDataGridView.ReadOnly = true;
            this.userRecordDataGridView.RowHeadersWidth = 51;
            this.userRecordDataGridView.Size = new System.Drawing.Size(770, 284);
            this.userRecordDataGridView.TabIndex = 16;
            this.userRecordDataGridView.SelectionChanged += new System.EventHandler(this.userRecordDataGridView_SelectionChanged_1);
            // 
            // tickPicBox
            // 
            this.tickPicBox.Image = ((System.Drawing.Image)(resources.GetObject("tickPicBox.Image")));
            this.tickPicBox.Location = new System.Drawing.Point(334, 6);
            this.tickPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.tickPicBox.Name = "tickPicBox";
            this.tickPicBox.Size = new System.Drawing.Size(26, 23);
            this.tickPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tickPicBox.TabIndex = 17;
            this.tickPicBox.TabStop = false;
            // 
            // passPicBox
            // 
            this.passPicBox.Image = ((System.Drawing.Image)(resources.GetObject("passPicBox.Image")));
            this.passPicBox.Location = new System.Drawing.Point(334, 39);
            this.passPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.passPicBox.Name = "passPicBox";
            this.passPicBox.Size = new System.Drawing.Size(26, 23);
            this.passPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.passPicBox.TabIndex = 18;
            this.passPicBox.TabStop = false;
            // 
            // namePicBox
            // 
            this.namePicBox.Image = ((System.Drawing.Image)(resources.GetObject("namePicBox.Image")));
            this.namePicBox.Location = new System.Drawing.Point(334, 110);
            this.namePicBox.Margin = new System.Windows.Forms.Padding(2);
            this.namePicBox.Name = "namePicBox";
            this.namePicBox.Size = new System.Drawing.Size(26, 23);
            this.namePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.namePicBox.TabIndex = 19;
            this.namePicBox.TabStop = false;
            // 
            // emailPicBox
            // 
            this.emailPicBox.Image = ((System.Drawing.Image)(resources.GetObject("emailPicBox.Image")));
            this.emailPicBox.Location = new System.Drawing.Point(736, 4);
            this.emailPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.emailPicBox.Name = "emailPicBox";
            this.emailPicBox.Size = new System.Drawing.Size(26, 23);
            this.emailPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.emailPicBox.TabIndex = 20;
            this.emailPicBox.TabStop = false;
            // 
            // phonePicBox
            // 
            this.phonePicBox.Image = ((System.Drawing.Image)(resources.GetObject("phonePicBox.Image")));
            this.phonePicBox.Location = new System.Drawing.Point(736, 37);
            this.phonePicBox.Margin = new System.Windows.Forms.Padding(2);
            this.phonePicBox.Name = "phonePicBox";
            this.phonePicBox.Size = new System.Drawing.Size(26, 23);
            this.phonePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phonePicBox.TabIndex = 21;
            this.phonePicBox.TabStop = false;
            // 
            // addressPicBox
            // 
            this.addressPicBox.Image = ((System.Drawing.Image)(resources.GetObject("addressPicBox.Image")));
            this.addressPicBox.Location = new System.Drawing.Point(736, 73);
            this.addressPicBox.Margin = new System.Windows.Forms.Padding(2);
            this.addressPicBox.Name = "addressPicBox";
            this.addressPicBox.Size = new System.Drawing.Size(26, 23);
            this.addressPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addressPicBox.TabIndex = 22;
            this.addressPicBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addressPicBox);
            this.panel1.Controls.Add(this.phonePicBox);
            this.panel1.Controls.Add(this.emailPicBox);
            this.panel1.Controls.Add(this.namePicBox);
            this.panel1.Controls.Add(this.passPicBox);
            this.panel1.Controls.Add(this.tickPicBox);
            this.panel1.Controls.Add(this.userRecordDataGridView);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.emailText);
            this.panel1.Controls.Add(this.phoneNumberLabel);
            this.panel1.Controls.Add(this.phoneNumberText);
            this.panel1.Controls.Add(this.addressLabel);
            this.panel1.Controls.Add(this.addressText);
            this.panel1.Location = new System.Drawing.Point(68, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 585);
            this.panel1.TabIndex = 39;
            // 
            // AdminUserManagementUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userNameText);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminUserManagementUserControl";
            this.Size = new System.Drawing.Size(1018, 634);
            this.Load += new System.EventHandler(this.AdminUserManagementUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addressErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRecordDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tickPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider addressErrorProvider;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox addressPicBox;
        private System.Windows.Forms.PictureBox phonePicBox;
        private System.Windows.Forms.PictureBox emailPicBox;
        private System.Windows.Forms.PictureBox namePicBox;
        private System.Windows.Forms.PictureBox passPicBox;
        private System.Windows.Forms.PictureBox tickPicBox;
        private System.Windows.Forms.DataGridView userRecordDataGridView;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneNumberText;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.ErrorProvider emailErrorProvider;
        private System.Windows.Forms.ErrorProvider nameErrorProvider;
        private System.Windows.Forms.ErrorProvider passErrorProvider;
        private System.Windows.Forms.ErrorProvider userNameErrorProvider;
        private System.Windows.Forms.ErrorProvider phoneErrorProvider;
    }
}
