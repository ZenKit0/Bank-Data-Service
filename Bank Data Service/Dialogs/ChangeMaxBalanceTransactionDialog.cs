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
    public partial class ChangeMaxBalanceTransactionDialog : Form {
        public ChangeMaxBalanceTransactionDialog() {
            InitializeComponent();
        }
        
        private void ChangeButton_Click(object sender, EventArgs e) {
            DatabaseManager.AccountData MngAcc = ManagementWindow.MngInstance.Account;


            if (MoneyValue.Value == 0 ||
                MoneyValue.Value == MngAcc.max_balance_transaction) {
                MessageBox.Show("Podano niepoprawną wartość!");
                return;
            }

            DatabaseManager.DBMInstance.ChangeMaxTransactionBalance(
                MngAcc.login, 
                MoneyValue.Value,
                DateTime.Now);

            Hide();
        }
    }
}
