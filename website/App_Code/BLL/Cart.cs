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
    /// Summary description for Cart
    /// </summary>
    public class Cart
    {
        public Cart()
        {
        }

        public Cart(String userName, String details, int catalogId)
        {
            this.UserName = userName;
            this.Details = details;
            this.CatalogId = catalogId;
        }

        private String _userName;

        public String UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        private String _details;

        public String Details
        {
            get { return _details; }
            set { _details = value; }
        }

        private int _catalogId;

        public int CatalogId
        {
            get { return _catalogId; }
            set { _catalogId = value; }
        }
    }
}