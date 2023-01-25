using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_13.Libs {

    public enum PaymentTypeEnum { 
        Cash,
        CreditCard
    }

    public class Settings {

        public decimal RentCost { get; set; }

    }

    public class PetShop {

        public List<Transaction> Transactions { get; set; }

        public List<Customer> Customers { get; set; }

        //public Settings Settings { get; set; }

        public decimal RentCost { get; set; }

    }

    public class Transaction {

        public DateTime TransDate { get; set; }

        public List<TransactionLine> TransactionLines { get; set; }

        public Customer TransCustomer { get; set; }

        public decimal TotalPrice { get; set; }

        public PaymentTypeEnum PaymentType { get; set; }

        public Transaction() {
            TransactionLines = new List<TransactionLine>(); 
        }

        //public void SetTotalPrice() {

        //    TotalPrice = TransactionLines.Sum(x => x.TotalPrice);
        //}
    }


    public class TransactionLine {

        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal DiscPercent { get; set; }

    }
}
