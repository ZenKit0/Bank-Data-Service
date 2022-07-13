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

            if (ReceiverID.Text == "" ||
                ReceiverID.Text == MngAcc.login) {
                MessageBox.Show("Podaj poprawny numer konta odbiorcy!");
                return;
            }

            if (MoneyValue.Value == 0 || 
                MoneyValue.Value > MngAcc.balance) {
                MessageBox.Show("Podano niepoprawną wartość!");
                return;
            }

            DatabaseManager.DBMInstance.TransferMoney(
                Int32.Parse(MngAcc.login), 
                Int32.Parse(ReceiverID.Text),
                MoneyValue.Value);

            Hide();
        }
    }
}
