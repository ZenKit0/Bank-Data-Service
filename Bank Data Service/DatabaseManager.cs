using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace Bank_Data_Service {
    public class DatabaseManager {
        public static DatabaseManager DBMInstance;

        private MySqlConnection SqlConnection = new MySqlConnection("host=localhost;user=root;password=;database=account;");
        private MySqlDataReader reader;

        public List<AccountData> Accounts = new List<AccountData>();
        public bool IsOpenedConnection = false;

        public DatabaseManager() {
            if (!OpenConnection())
                return;

            Accounts = LoadAccountsData();
        }

        private bool OpenConnection() {
            try {
                SqlConnection.Open();
            } catch {
                Debug.WriteLine("<error> Can't Connect to Database");
                MessageBox.Show("<error> Nie można połączyć się za Bazą Danych! Sprawdź swoje łącze.");
                return false;
            }

            IsOpenedConnection = true;
            return true;
        }

        public List<AccountData> LoadAccountsData() {
            try {
                List<AccountData> database = new List<AccountData>();
                string sql = $" SELECT * FROM accounts";
                using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                    reader = cmd.ExecuteReader();

                    while (reader.Read()) {
                        AccountData Data = new AccountData(reader.GetString("login"),
                                                            reader.GetString("password"),
                                                            reader.GetString("pin"),
                                                            reader.GetDecimal("balance"),
                                                            reader.GetInt32("max_balance_transaction"));
                        database.Add(Data);
                    }
                    reader.Close();
                }
                
                return database;
            } catch (MySqlException ex) {
                Debug.WriteLine(ex);
                return null;
            }
        }

        public AccountData ReadAccountInformations(int account_id) {
            try {
                AccountData acc = new AccountData();
                string sql = $" SELECT * FROM accounts WHERE login = '{account_id}';";
                using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                    reader = cmd.ExecuteReader();

                    if (reader.Read()) {
                        acc = new AccountData() {
                            login = reader.GetString("login"),
                            password = reader.GetString("password"),
                            pin = reader.GetString("pin"),
                            balance = reader.GetDecimal("balance"),
                            max_balance_transaction = reader.GetInt32("max_balance_transaction")
                        };
                    }
                    reader.Close();
                }


                return acc;
            }
            catch (MySqlException ex) {
                Debug.WriteLine(ex);
                return new AccountData();
            }
        }

        public void TransferMoney(int sender_id, int receiver_id, decimal money_amount) {
            string sql;
            sql = $"UPDATE accounts " +
                $"SET balance = balance - {money_amount} " +
                $"WHERE login = {sender_id};";

            Debug.WriteLine(sql);

            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                cmd.ExecuteNonQuery();
            }

            sql = $"UPDATE accounts " +
                $"SET balance = balance + {money_amount} " +
                $"WHERE login = {receiver_id};";

            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                cmd.ExecuteNonQuery();
            }


            MessageBox.Show("Poprawnie wykonano transakcje!");

            CreateTransactionLog(sender_id, receiver_id, money_amount);
            ManagementWindow.MngInstance.Account = ReadAccountInformations(sender_id);
            ManagementWindow.MngInstance.UpdateText();
        }

        public void CreateTransactionLog(int sender_id, int receiver_id, decimal money_amount) {
            string sql = $" INSERT INTO transactions (sender_id, receiver_id, money_amount)" +
                $"VALUES ({sender_id}, {receiver_id}, {money_amount});";

            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                cmd.ExecuteNonQuery();
            }
        }


        /*
         accounts table:
        id: int(10), Auto Increment, Not Negative, Not Null
        login: varchar(255)
        password: varchar(255)
        pin: varchar(4)
        balance: decimal(10), After Comma: 2, default: 0
        max_balance_transaction: int(10) Not Negative, default: 250
         */

        public struct AccountData {
            public AccountData(string login, string password, string pin, decimal balance, int max_balance_transaction) {
                this.login = login;
                this.password = password;
                this.pin = pin;
                this.balance = balance;
                this.max_balance_transaction = max_balance_transaction;
            }

            public string login;
            public string password;
            public string pin;
            public decimal balance;
            public int max_balance_transaction;
        }


        /*
         transactions table:
        transaction_id: int(10), Auto Increment, Not Negative, Not Null
        sender_id: int(10), Not Negative
        receiver_id: int(10), Not Negative
        money_amount: decimal(10), After Comma: 2, Not Negative
         */

        public struct TransactionData {
            public TransactionData(int transaction_id, int sender_id, int receiver_id, decimal money_amount) {
                this.transaction_id = transaction_id;
                this.sender_id = sender_id;
                this.receiver_id = receiver_id;
                this.money_amount = money_amount;
            }

            public int transaction_id;
            public int sender_id;
            public int receiver_id;
            public decimal money_amount;
        }
    }
}
