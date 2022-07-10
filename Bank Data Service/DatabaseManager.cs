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

        public List<AccountData> Accounts;

        public DatabaseManager() {
            SqlConnection.Open();
            Accounts = LoadAccountsData();
        }

        private List<AccountData> LoadAccountsData() {
            try {
                List<AccountData> database = new List<AccountData>();
                string sql = $" SELECT * FROM accounts";
                SqlCommand = new MySqlCommand(sql, SqlConnection);
                MySqlDataReader reader = SqlCommand.ExecuteReader();
                while (reader.Read()) {
                    AccountData Data = new AccountData(reader.GetString("login"), 
                                                        reader.GetString("password"), 
                                                        reader.GetString("pin"), 
                                                        reader.GetFloat("balance"), 
                                                        reader.GetInt32("max_balance_transaction"));
                    database.Add(Data);
                }
                reader.Close();
                return database;
            } catch (MySqlException ex) {
                throw ex;
            }
        }


        /*
         accounts table:
        id: int(10), Auto Increment, Not Negative, Not Null
        login: varchar(255)
        password: varchar(255)
        pin: varchar(4)
        balance: float, default: 0
        max_balance_transaction: int(10) Not Negative, default: 250
         */

        public struct AccountData {
            public AccountData(string login, string password, string pin, float balance, int max_balance_transaction) {
                this.login = login;
                this.password = password;
                this.pin = pin;
                this.balance = balance;
                this.max_balance_transaction = max_balance_transaction;
            }

            public string login;
            public string password;
            public string pin;
            public float balance;
            public int max_balance_transaction;
        }


        /*
         transactions table:
        transaction_id: int(10), Auto Increment, Not Negative, Not Null
        sender_id: int(10), Not Negative
        receiver_id: int(10), Not Negative
        money_amount: float, Not Negative
         */

        public struct TransactionData {
            public TransactionData(int transaction_id, int sender_id, int receiver_id, float money_amount) {
                this.transaction_id = transaction_id;
                this.sender_id = sender_id;
                this.receiver_id = receiver_id;
                this.money_amount = money_amount;
            }

            public int transaction_id;
            public int sender_id;
            public int receiver_id;
            public float money_amount;
        }
    }
}
