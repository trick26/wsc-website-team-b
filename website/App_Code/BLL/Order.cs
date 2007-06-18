using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace BLL
{
    /// <summary>
    /// Summary description for Order
    /// </summary>
    public class Order
    {
        public Order()
        {
        }

        public Order(int id, int catalogId, int clientId, int paymentId, String details, double price)
        {
            this.ID = id;
            this.CatalogId = catalogId;
            this.ClientId = clientId;
            this.PaymentId = paymentId;
            this.Details = details;
            this.Price = price;
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private int _catalogId;

        public int CatalogId
        {
            get { return _catalogId; }
            set { _catalogId = value; }
        }

        private int _clientId;

        public int ClientId
        {
            get { return _clientId; }
            set { _clientId = value; }
        }

        private int _paymentId;

        public int PaymentId
        {
            get { return _paymentId; }
            set { _paymentId = value; }
        }

        private DateTime _orderDate;

        public DateTime OrderDate
        {
            get { return _orderDate; }
            set { _orderDate = value; }
        }
	
        private String _details;

        public String Details
        {
            get { return _details; }
            set { _details = value; }
        }

        private double _price;

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}