using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Data_Service {
    public static class Locale {

        public static string ConverDecimalToSQLDecimal(decimal variableDecimal) {
            string str_money_amount = variableDecimal.ToString();

            int iter = 0;
            foreach (char item in str_money_amount) {
                if (item == ',')
                    iter++;
            }

            if (iter == 0)
                return $"{variableDecimal}.00";

            StringBuilder tmpMoney = new StringBuilder(str_money_amount);
            tmpMoney[variableDecimal.ToString().Length - 3] = '.';
            return tmpMoney.ToString();
        }

        public static string ConvertDateTimeToSQLDateTime(DateTime date_time) {
            return date_time.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string ConvertTransactionDataToTransactionLog(DatabaseManager.TransactionData data) {
            string convertedString = $"{data.date_time}: Wysłano: {data.money_amount} " +
                $"do użytkownika: {data.receiver_id}";

            return convertedString;
        }

        public static string ConvertChangesDataToChangesLog(DatabaseManager.ChangeMaxBalanceTransactionData data) {
            string convertedString = $"{data.date_time}: Zmieniono maksymalną wartość transakcji do: {data.money_amount}";

            return convertedString;
        }
    }
}
