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

        #region Initialize
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
                        AccountData Data = GetAccountData(reader);
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
                        acc = GetAccountData(reader);
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
        #endregion

        #region Transaction
        public void TransferMoney(int sender_id, int receiver_id, decimal money_amount, DateTime date_time) {
            string str_money_amount = Locale.ConverDecimalToSQLDecimal(money_amount);

            string sql;
            sql = $"UPDATE accounts " +
                $"SET balance = balance - {str_money_amount} " +
                $"WHERE login = {sender_id};";

            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                cmd.ExecuteNonQuery();
            }

            sql = $"UPDATE accounts " +
                $"SET balance = balance + {str_money_amount} " +
                $"WHERE login = {receiver_id};";

            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Poprawnie wykonano transakcje!");

            CreateTransactionLog(sender_id, receiver_id, money_amount, date_time);
            ManagementWindow.MngInstance.Account = ReadAccountInformations(sender_id);
            ManagementWindow.MngInstance.UpdateText();
        }
        
        public void CreateTransactionLog(int sender_id, int receiver_id, decimal money_amount, DateTime date_time) {
            string str_money_amount = Locale.ConverDecimalToSQLDecimal(money_amount);

            string sql = $" INSERT INTO transactions (sender_id, receiver_id, money_amount, date_time) " +
                $"VALUES ({sender_id}, {receiver_id}, {str_money_amount}, '{Locale.ConvertDateTimeToSQLDateTime(date_time)}');";

            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                cmd.ExecuteNonQuery();
            }
        }

        public List<TransactionData> GetTransactionsLogs(int sender_id) {
            List<TransactionData> tmp = new List<TransactionData>();

            string sql = $" SELECT * FROM transactions WHERE sender_id = {sender_id}";
            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    TransactionData Data = GetTransactionData(reader);
                    tmp.Add(Data);
                }
                reader.Close();
            }

            return tmp;
        }
        #endregion

        #region Change Max Balance Transaction
        public void ChangeMaxTransactionBalance(int sender_id, decimal money_amount, DateTime date_time) {
            string str_money_amount = Locale.ConverDecimalToSQLDecimal(money_amount);

            string sql;
            sql = $"UPDATE accounts " +
                $"SET max_balance_transaction = {str_money_amount} " +
                $"WHERE login = {sender_id};";
            Debug.WriteLine(sql);
            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Poprawnie wykonano zmianę!");

            CreateChangeMaxBalanceTransactionLog(sender_id, money_amount, date_time);
            ManagementWindow.MngInstance.Account = ReadAccountInformations(sender_id);
            ManagementWindow.MngInstance.UpdateText();
        }

        public void CreateChangeMaxBalanceTransactionLog(int sender_id, decimal money_amount, DateTime date_time) {
            string str_money_amount = Locale.ConverDecimalToSQLDecimal(money_amount);

            string sql = $" INSERT INTO changes_max_balance_transaction (sender_id, money_amount, date_time) " +
                $"VALUES ({sender_id}, {str_money_amount}, '{Locale.ConvertDateTimeToSQLDateTime(date_time)}');";

            Debug.WriteLine(sql);

            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                cmd.ExecuteNonQuery();
            }
        }

        public List<ChangeMaxBalanceTransactionData> GetChangesLogs(int sender_id) {
            List<ChangeMaxBalanceTransactionData> tmp = new List<ChangeMaxBalanceTransactionData>();

            string sql = $" SELECT * FROM changes_max_balance_transaction WHERE sender_id = {sender_id}";
            using (MySqlCommand cmd = new MySqlCommand(sql, SqlConnection)) {
                reader = cmd.ExecuteReader();

                while (reader.Read()) {
                    ChangeMaxBalanceTransactionData Data = GetChangeMaxBalanceTransactionData(reader);
                    tmp.Add(Data);
                }
                reader.Close();
            }

            return tmp;
        }
        #endregion

        #region Data
        private AccountData GetAccountData(MySqlDataReader reader) {
            AccountData tmp = new AccountData(reader.GetInt32("login"),
                            reader.GetString("password"),
                            reader.GetString("pin"),
                            reader.GetDecimal("balance"),
                            reader.GetDecimal("max_balance_transaction"));

            return tmp;
        }

        private TransactionData GetTransactionData(MySqlDataReader reader) {
            TransactionData tmp = new TransactionData(reader.GetInt32("transaction_id"),
                            reader.GetInt32("sender_id"),
                            reader.GetInt32("receiver_id"),
                            reader.GetDecimal("money_amount"),
                            reader.GetDateTime("date_time"));

            return tmp;
        }

        private ChangeMaxBalanceTransactionData GetChangeMaxBalanceTransactionData(MySqlDataReader reader) {
            ChangeMaxBalanceTransactionData tmp = new ChangeMaxBalanceTransactionData(reader.GetInt32("transaction_id"),
                                reader.GetInt32("sender_id"),
                                reader.GetDecimal("money_amount"),
                                reader.GetDateTime("date_time"));

            return tmp;
        }


        /*
         accounts table:
        id: int(10), Auto Increment, Not Negative, Not Null
        login: int(10), Not Negative
        password: varchar(255)
        pin: varchar(4)
        balance: decimal(10), After Comma: 2, default: 0
        max_balance_transaction: decimal(10), After Comma: 2, Not Negative, default: 250.00
         */

        public struct AccountData {
            public AccountData(int login, string password, string pin, decimal balance, decimal max_balance_transaction) {
                this.login = login;
                this.password = password;
                this.pin = pin;
                this.balance = balance;
                this.max_balance_transaction = max_balance_transaction;
            }

            public int login;
            public string password;
            public string pin;
            public decimal balance;
            public decimal max_balance_transaction;
        }


        /*
         transactions table:
        transaction_id: int(10), Auto Increment, Not Negative, Not Null
        sender_id: int(10), Not Negative
        receiver_id: int(10), Not Negative
        money_amount: decimal(10), After Comma: 2, Not Negative
        date_time: datetime
         */

        public struct TransactionData {
            public TransactionData(int transaction_id, int sender_id, int receiver_id, decimal money_amount, DateTime date_time) {
                this.transaction_id = transaction_id;
                this.sender_id = sender_id;
                this.receiver_id = receiver_id;
                this.money_amount = money_amount;
                this.date_time = date_time;
            }

            public int transaction_id;
            public int sender_id;
            public int receiver_id;
            public decimal money_amount;
            public DateTime date_time;
        }


        /*
         changes_max_balance_transaction table:
        transaction_id: int(10), Auto Increment, Not Negative, Not Null
        sender_id: int(10), Not Negative
        money_amount: decimal(10), After Comma: 2, Not Negative
        date_time: datetime
         */

        public struct ChangeMaxBalanceTransactionData {
            public ChangeMaxBalanceTransactionData(int transaction_id, int sender_id, decimal money_amount, DateTime date_time) {
                this.transaction_id = transaction_id;
                this.sender_id = sender_id;
                this.money_amount = money_amount;
                this.date_time = date_time;
            }

            public int transaction_id;
            public int sender_id;
            public decimal money_amount;
            public DateTime date_time;
        }
        #endregion
    }
}
