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

namespace Bank_Data_Service {
    public partial class TransferMoneyDialog : Form {
        public TransferMoneyDialog() {
            InitializeComponent();
        }
        
        private void TransferMoneyButton_Click(object sender, EventArgs e) {
            DatabaseManager.AccountData MngAcc = ManagementWindow.MngInstance.Account;

            int ParsedReceiverID = Int32.Parse(ReceiverID.Text);

            if (string.IsNullOrEmpty(ReceiverID.Text) ||
                ParsedReceiverID == MngAcc.login) {
                MessageBox.Show("Podaj poprawny numer konta odbiorcy!");
                return;
            }

            if (MoneyValue.Value == 0 || 
                MoneyValue.Value > MngAcc.balance ||
                MoneyValue.Value > MngAcc.max_balance_transaction) {
                MessageBox.Show("Podano niepoprawną wartość!");
                return;
            }

            DatabaseManager.DBMInstance.TransferMoney(
                MngAcc.login,
                ParsedReceiverID,
                MoneyValue.Value,
                DateTime.Now);

            Hide();
        }
    }
}
