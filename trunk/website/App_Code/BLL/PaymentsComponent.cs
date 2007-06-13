using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;

namespace BLL
{
    /// <summary>
    /// Summary description for PaymentsComponent
    /// </summary>
    public class PaymentsComponent
    {
        public PaymentsComponent()
        {
        }

        public List<Payment> GetPayments()
        {
            List<Payment> payments = new List<Payment>();
            DataSet ds = new DataSet();
            DataSetTableAdapters.paymentsTableAdapter adapter = new DataSetTableAdapters.paymentsTableAdapter();
            adapter.Fill(ds.payments);
            DataSet.paymentsDataTable table = adapter.GetPaymentData();

            // load all payments into the list
            foreach (DataSet.paymentsRow row in table.Rows)
            {
                // create memory for new payment & fill in properties
                Payment p = new Payment();
                p.ID = row.paymentId;
                p.CardholderName = row.cardholderName;
                p.CardType = row.cardType;
                p.CardNumber = row.cardNumber;
                p.CardExpiration = row.cardExpiration;

                // add this payment to the list
                payments.Add(p);
            }
            // returns the list w/ 0 or more Payments
            return payments;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns>A payment if found; null if payment not found</returns>
        public Payment GetPaymentById(int id)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.paymentsTableAdapter adapter = new DataSetTableAdapters.paymentsTableAdapter();
            adapter.Fill(ds.payments);
            Payment p = new Payment();

            // find the payment
            DataSet.paymentsDataTable table = adapter.GetPaymentById(id);

            // if a payment was found, then fill in the details 
            if (table.Rows.Count > 0)
            {
                // use the 1st row's data
                DataSet.paymentsRow row = (DataSet.paymentsRow)table.Rows[0];
                p.ID = row.paymentId;
                p.CardholderName = row.cardholderName;
                p.CardType = row.cardType;
                p.CardNumber = row.cardNumber;
                p.CardExpiration = row.cardExpiration;
                return p;
            }
            else
            {
                return null;
            }
        }

        public int UpdatePayment(Payment p)
        {
            return UpdatePayment(p.ID, p.CardholderName, p.CardType, p.CardNumber, p.CardExpiration);
        }

        public int UpdatePayment(int id, String cardholderName, String cardType, String cardNumber, DateTime cardExpiration)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.paymentsTableAdapter adapter = new DataSetTableAdapters.paymentsTableAdapter();

            return adapter.Update(cardholderName, cardType, cardNumber, cardExpiration, id);
        }

        public int InsertPayment(Payment p)
        {
            return InsertPayment(p.CardholderName, p.CardType, p.CardNumber, p.CardExpiration);
        }

        public int InsertPayment(String cardholderName, String cardType, String cardNumber, DateTime cardExpiration)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.paymentsTableAdapter adapter = new DataSetTableAdapters.paymentsTableAdapter();

            return adapter.Insert(cardholderName, cardType, cardNumber, cardExpiration);
        }

        public int DeletePayment(Payment p)
        {
            return DeletePayment(p.ID);
        }

        public int DeletePayment(int id)
        {
            DataSet ds = new DataSet();
            DataSetTableAdapters.paymentsTableAdapter adapter = new DataSetTableAdapters.paymentsTableAdapter();

            return adapter.Delete(id);
        }
    }
}