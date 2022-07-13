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

        public void UpdateText() {
            MoneyText.Text = Account.balance.ToString("0.00 ");
            MoneyText.Invalidate();
            MoneyText.Update();

            MaxTransactionBalanceMoneyText.Text = Account.max_balance_transaction.ToString("0 ");
            MaxTransactionBalanceMoneyText.Invalidate();
            MaxTransactionBalanceMoneyText.Update();

            AccountID.Text = Account.login;
            AccountID.Invalidate();
            AccountID.Update();
        }
    }
}
