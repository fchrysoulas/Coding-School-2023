using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_13.Libs {
    
    public class Business {


        public void AddTransLine(decimal price, int qty) {

            Transaction trans = new Transaction();

            TransactionLine transactionLine = new TransactionLine() {
                Qty = qty,
                Price = price
            };

            transactionLine.TotalPrice = transactionLine.Qty * transactionLine.Price;


            trans.TransactionLines.Add(transactionLine);

            SetTotalPrice(trans);

        }

        private static void SetTotalPrice(Transaction trans) {
            trans.TotalPrice = trans.TransactionLines.Sum(x => x.TotalPrice);
        }

        public void CheckPaymentType(Transaction trans) {

            if (trans.TotalPrice >= 50) {
                trans.PaymentType = 0;
            }


        }

        public void CheckForDiscount(Transaction trans) {

            if (trans.TotalPrice >= 10) {


                foreach (TransactionLine transactionLine in trans.TransactionLines) {


                    transactionLine.DiscPercent = 15;

                    // set discount...
                }

                SetTotalPrice(trans);
            }
        }
    
    }
}
