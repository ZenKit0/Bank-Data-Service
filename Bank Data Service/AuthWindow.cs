using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.IO;

namespace Bank_Data_Service {
    public partial class AuthWindow : Form {
        List<DatabaseData> Database;
        MySqlConnection SqlConnection = new MySqlConnection("host=localhost;user=root;password=;database=account;");
        MySqlCommand SqlCommand;
        public AuthWindow() {
            InitializeComponent();
            SqlConnection.Open();
            Database = LoadDatabase();
        }

        private void ShowPasswd_CheckedChanged(object sender, EventArgs e) {
            if (ShowPasswd.Checked) {
                PasswordText.PasswordChar = '*';
            } else {
                PasswordText.PasswordChar = '\0';
            }
        }

        private void LoginButton_Click(object sender, EventArgs e) {
            string login = LoginText.Text;
            string password = PasswordText.Text;

            for (int i = 0; i < Database.Count; i++) {
                if (Database[i].login == login &&
                    Database[i].password == password) {

                    this.Close();
                    Program.ProgramState = Program.CurrentState.Management;
                    return;

                } else {
                    if (i == Database.Count - 1)
                        MessageBox.Show("Nie znaleziono konta.");
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private List<DatabaseData> LoadDatabase() {
            try {
                List<DatabaseData> database = new List<DatabaseData>();
                string sql = $" SELECT * FROM accounts";
                SqlCommand = new MySqlCommand(sql, SqlConnection);
                MySqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read()) {
                    DatabaseData Data = new DatabaseData(reader.GetString("login"), reader.GetString("password"), reader.GetInt32("ballance"), reader.GetInt32("max_ballance_transaction"));
                    database.Add(Data);
                }
                reader.Close();
                return database;
            } catch (MySqlException ex) {
                throw ex;
            }
        }

        public struct DatabaseData {
            public DatabaseData (string login, string password, int ballance, int max_ballance_transaction) {
                this.login = login;
                this.password = password;
                this.ballance = ballance;
                this.max_ballance_transaction = max_ballance_transaction;
            }
            public string login;
            public string password;
            public int ballance;
            public int max_ballance_transaction;
        }
    }
}
