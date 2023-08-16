﻿using File_Acess_Management.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace File_Acess_Management
{
    public partial class ManagerDashboard : Form
    {
        bool check = false;
        public ManagerDashboard()
        {
            InitializeComponent();
        }

        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            deleteButton.Enabled = false;
            updateButton.Enabled = false;
            userRecordDataGridView.AllowUserToAddRows = false;
            userRecordDataGridView.ReadOnly = true;
            // Attach the SelectionChanged event handler to the DataGridView
            userRecordDataGridView.SelectionChanged += userRecordDataGridView_SelectionChanged;
            PopulateRoleComboBox();
            GetUsersRecord();
        }

        private void userRecordDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            // This event is triggered when the selection in DataGridView changes
            if (userRecordDataGridView.SelectedRows.Count > 0)
            {
                check= true;
                userNameText.Enabled = false;
                passwordText.Enabled = false;
                deleteButton.Enabled = true;
                updateButton.Enabled = true;
                DataGridViewRow selectedRow = userRecordDataGridView.SelectedRows[0];

                // Assuming you have TextBox controls for updating data
                userNameText.Text = selectedRow.Cells["user_name"].Value.ToString();
                emailText.Text = selectedRow.Cells["email"].Value.ToString();
                nameText.Text = selectedRow.Cells["name"].Value.ToString();
                phoneNumberText.Text = selectedRow.Cells["phone_number"].Value.ToString();
                addressText.Text = selectedRow.Cells["address"].Value.ToString();

                // Set the selected role in the ComboBox
                string role_name = selectedRow.Cells["role"].Value.ToString();
                // using linq expression here especially FirstOrDefault
                // FirstOrDefault(...) finds the first item that matches the specified condition. In this case, it's looking for an item with a RoleId equal to the roleId variable.
                Role roleItem = roleComboBox.Items.OfType<Role>().FirstOrDefault(item => item.RoleName == role_name);
                if (roleItem != null)
                {
                    roleComboBox.SelectedItem = roleItem;
                }
            }
        }

        private void GetUsersRecord()
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT u.user_name, r.role_name as role, u.name, u.email, u.phone_number, u.address FROM users AS u INNER JOIN roles AS r ON u.role_id = r.role_id WHERE r.role_name!='Admin';";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    DataTable dt= new DataTable();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load (reader);
                        connection.Close ();
                    }
                    userRecordDataGridView.DataSource = dt;
                    //studentRecordDataGridView.Columns["Password"].Visible = false;
                    userRecordDataGridView.Columns["user_name"].HeaderText = "User Name";
                    userRecordDataGridView.Columns["role"].HeaderText = "Role";
                    userRecordDataGridView.Columns["name"].HeaderText = "Full Name";
                    userRecordDataGridView.Columns["email"].HeaderText = "Email";
                    userRecordDataGridView.Columns["phone_number"].HeaderText = "Phone Number";
                    userRecordDataGridView.Columns["address"].HeaderText = "Address";
                }
            }
        }
        private void PopulateRoleComboBox()
        {
            // Assuming you have a ComboBox named roleComboBox
            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();

                string query = "SELECT role_id, role_name FROM roles where role_name!='Admin'";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int roleId = reader.GetInt32("role_id");
                            string roleName = reader.GetString("role_name");
                            roleComboBox.Items.Add(new Role(roleId, roleName));
                        }
                    }
                }

                connection.Close();
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string username = userNameText.Text;
            string password = passwordText.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            Role selectedRole = (Role)roleComboBox.SelectedItem;
            string name = nameText.Text;
            string email = emailText.Text;
            string phno = phoneNumberText.Text;
            string address = addressText.Text;
            bool check=false;

            using(MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                connection.Open();
                string query = "Select * from users where user_name=@Username";
                using(MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            check=true;
                        }
                    }
                }
            }

            if (username == "" && password == "" && name == "" && email == "" && phno == "" && address == "")
            {
                MessageBox.Show("Please don't submit blank fields");
                return;
            }
            else if (selectedRole == null)
            {
                MessageBox.Show("Please select a role");
                return;
            }
            else if (check == true)
            {
                MessageBox.Show("Select a unique username");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                int roleId = selectedRole.RoleId;
                connection.Open();

                string query = "INSERT INTO users (id, user_name, password, role_id, name, email, phone_number, address, manager_assigned) VALUES (0,@Username, @Password, @RoleId, @Name, @Email, @PhoneNumber, @Address, @Assigned)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", hashedPassword);
                    command.Parameters.AddWithValue("@RoleId", roleId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phno);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@Assigned", "false");

                    int rowsAffected = command.ExecuteNonQuery(); ;
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User added successfully.");
                        GetUsersRecord(); 
                        ClearFormFields(); 
                    }
                    else
                    {
                        MessageBox.Show("Error adding user.");
                    }
                }

                connection.Close();
            }
        }
        private void ClearFormFields()
        {
            deleteButton.Enabled = false;
            updateButton.Enabled = false;
            userNameText.Enabled = true;
            passwordText.Enabled = true;
            userRecordDataGridView.ClearSelection();
            // Clear the form fields
            userNameText.Text = "";
            passwordText.Text = "";
            roleComboBox.SelectedIndex = -1;
            nameText.Text = "";
            emailText.Text = "";
            phoneNumberText.Text = "";
            addressText.Text = "";
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string username = userNameText.Text;
            string password = passwordText.Text;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            Role selectedRole = (Role)roleComboBox.SelectedItem;
            string name = nameText.Text;
            string email = emailText.Text;
            string phno = phoneNumberText.Text;
            string address = addressText.Text;
            if (username == "" && password == "" && name == "" && email == "" && phno == "" && address == "")
            {
                MessageBox.Show("Please don't submit blank fields");
                return;
            }
            else if (selectedRole == null)
            {
                MessageBox.Show("Please select a role");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
            {
                int roleId = selectedRole.RoleId;
                connection.Open();

                string query = "UPDATE users SET role_id = @RoleId, name = @Name, email = @Email, phone_number = @PhoneNumber, address = @Address WHERE user_name = @Username;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@RoleId", roleId);
                    command.Parameters.AddWithValue("@Name", name);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@PhoneNumber", phno);
                    command.Parameters.AddWithValue("@Address", address);

                    int rowsAffected = command.ExecuteNonQuery(); ;
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User updated successfully.");
                        GetUsersRecord();
                        ClearFormFields();
                        updateButton.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Error updating user.");
                    }
                }

                connection.Close();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ClearFormFields ();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
                if (check == true)
            {
                string username = userNameText.Text;
                using (MySqlConnection connection = new MySqlConnection(ConnectionHelper.ConnectionString))
                {
                    connection.Open();

                    string query = "Delete from users where user_name=@Username";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        int rowsAffected = command.ExecuteNonQuery(); ;
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully.");
                            GetUsersRecord();
                            ClearFormFields();
                            check = false;
                            deleteButton.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Error deleting user.");
                        }
                    }

                    connection.Close();
                }
                }

        }

        }
    }