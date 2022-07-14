using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Data_Service {
    public partial class ManagementWindow : Form {
        public static ManagementWindow MngInstance;

        public DatabaseManager.AccountData Account;
        public ManagementWindow() {
            InitializeComponent();
            UpdateText();
        }

        private void TransferMoneyButton_Click(object sender, EventArgs e) {
            if (Account.balance <= 0)
                return;

            TransferMoneyDialog dialog = new TransferMoneyDialog();
            dialog.Show();
        }

        private void ChangeMaxTransactionBalanceButton_Click(object sender, EventArgs e) {
            ChangeMaxBalanceTransactionDialog dialog = new ChangeMaxBalanceTransactionDialog();
            dialog.Show();
        }

        public void UpdateText() {
            MoneyText.Text = Account.balance.ToString("0.00 ");
            MoneyText.Invalidate();
            MoneyText.Update();

            MaxBalanceTransactionMoneyText.Text = Account.max_balance_transaction.ToString("0.00 ");
            MaxBalanceTransactionMoneyText.Invalidate();
            MaxBalanceTransactionMoneyText.Update();

            AccountID.Text = Account.login.ToString();
            AccountID.Invalidate();
            AccountID.Update();

            
        }

        private void TransactionHistoryButton_Click(object sender, EventArgs e) {
            HistoryList.Items.Clear();
            foreach (DatabaseManager.TransactionData item in DatabaseManager.DBMInstance.GetTransactionsLogs(Account.login)) {
                HistoryList.Items.Add(Locale.ConvertTransactionDataToTransactionLog(item));
                HistoryList.Items.Add("--------------------------------------------------------------------");
            }
        }

        private void ChangesButton_Click(object sender, EventArgs e) {
            HistoryList.Items.Clear();
            foreach (DatabaseManager.ChangeMaxBalanceTransactionData item in DatabaseManager.DBMInstance.GetChangesLogs(Account.login)) {
                HistoryList.Items.Add(Locale.ConvertChangesDataToChangesLog(item));
                HistoryList.Items.Add("--------------------------------------------------------------------");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e) {
            UpdateText();
        }
    }
}
