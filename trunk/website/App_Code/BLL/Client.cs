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
    /// Summary description for Client
    /// </summary>
    public class Client
    {

        public Client()
        {
        }

        public Client(int id, String name, String address, String city, String state, String zip, String phone, String contactName)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
            this.ContactName = contactName;
        }

        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private String _address;

        public String Address
        {
            get { return _address; }
            set { _address = value; }
        }

        private String _city;

        public String City
        {
            get { return _city; }
            set { _city = value; }
        }

        private String _state;

        public String State
        {
            get { return _state; }
            set { _state = value; }
        }

        private String _zip;

        public String Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        private String _phone;

        public String Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        private String _contactName;

        public String ContactName
        {
            get { return _contactName; }
            set { _contactName = value; }
        }

    }
}