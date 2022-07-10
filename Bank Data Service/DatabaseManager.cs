using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Bank_Data_Service {
    public class DatabaseManager {
        public static DatabaseManager DBMInstance { get; } = new DatabaseManager();

        private MySqlConnection SqlConnection = new MySqlConnection("host=localhost;user=root;password=;database=account;");
        private MySqlCommand SqlCommand;

        public List<DatabaseData> Accounts;

        public DatabaseManager() {
            SqlConnection.Open();
            Accounts = LoadDatabase();
        }

        private List<DatabaseData> LoadDatabase() {
            try {
                List<DatabaseData> database = new List<DatabaseData>();
                string sql = $" SELECT * FROM accounts";
                SqlCommand = new MySqlCommand(sql, SqlConnection);
                MySqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read()) {
                    DatabaseData Data = new DatabaseData(reader.GetString("login"), reader.GetString("password"), reader.GetString("pin"), reader.GetInt32("ballance"), reader.GetInt32("max_ballance_transaction"));
                    database.Add(Data);
                }
                reader.Close();
                return database;
            } catch (MySqlException ex) {
                throw ex;
            }
        }

        public struct DatabaseData {
            public DatabaseData(string login, string password, string pin, int ballance, int max_ballance_transaction) {
                this.login = login;
                this.password = password;
                this.pin = pin;
                this.ballance = ballance;
                this.max_ballance_transaction = max_ballance_transaction;
            }

            public string login;
            public string password;
            public string pin;
            public int ballance;
            public int max_ballance_transaction;
        }
    }
}
