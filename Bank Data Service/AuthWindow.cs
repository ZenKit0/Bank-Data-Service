using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;

namespace Bank_Data_Service {
    public partial class AuthWindow : Form {
        public AuthWindow() {
            InitializeComponent();

            CheckConnectionValidation();
        }

        private void CheckConnectionValidation() {
            if (DatabaseManager.DBMInstance.IsOpenedConnection) 
                return;

            LoginButton.Enabled = false;
            LoginButton.Text = "Nie można się zalogować";
        }

        private void ShowPasswd_CheckedChanged(object sender, EventArgs e) {
            if (ShowPasswd.Checked) {
                PasswordText.PasswordChar = '*';
            } else {
                PasswordText.PasswordChar = '\0';
            }
        }

        private void ShowPin_CheckedChanged(object sender, EventArgs e) {
            if (ShowPin.Checked) {
                PinText.PasswordChar = '*';
            } else {
                PinText.PasswordChar = '\0';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            int login = Int32.Parse(LoginText.Text);
            string password = PasswordText.Text;
            string pin = PinText.Text;

            List<DatabaseManager.AccountData> Accounts = DatabaseManager.DBMInstance.Accounts;

            for (int i = 0; i < Accounts.Count; i++) {
                if (Accounts[i].login == login &&
                    Accounts[i].password == password &&
                    Accounts[i].pin == pin) {
                    this.Close();
                    Program.ProgramState = Program.CurrentState.Management;
                    ManagementWindow.MngInstance.Account = Accounts[i];
                    ManagementWindow.MngInstance.UpdateText();
                    return;
                } else {
                    if (i == Accounts.Count - 1)
                        MessageBox.Show("Nie znaleziono konta.");
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
