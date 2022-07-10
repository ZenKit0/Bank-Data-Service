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
        public static DatabaseManager.AccountData Account;
        public ManagementWindow() {
            InitializeComponent();
            MoneyText.Text = Account.balance.ToString("0.00 ");
            MaxTransactionBalanceMoneyText.Text = Account.max_balance_transaction.ToString("0.00 ");
        }
    }
}
