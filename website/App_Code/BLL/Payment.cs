using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Payment
/// </summary>
public class Payment
{
	public Payment()
	{
	}

    public Payment(int id, String cardholderName, String cardType, String cardNumber, DateTime cardExpiration)
    {
        this.ID = id;
        this.CardholderName = cardholderName;
        this.CardType = cardType;
        this.CardNumber = cardNumber;
        this.CardExpiration = CardExpiration;
    }
    
    private int _id;

    public int ID
    {
        get { return _id; }
        set { _id = value; }
    }

    private String _cardholderName;

    public String CardholderName
    {
        get { return _cardholderName; }
        set { _cardholderName = value; }
    }

    private String _cardType;

    public String CardType
    {
        get { return _cardType; }
        set { _cardType = value; }
    }

    private String _cardNumber;

    public String CardNumber
    {
        get { return _cardNumber; }
        set { _cardNumber = value; }
    }

    private DateTime _cardExpiration;

    public DateTime CardExpiration
    {
        get { return _cardExpiration; }
        set { _cardExpiration = value; }
    }
	
}
