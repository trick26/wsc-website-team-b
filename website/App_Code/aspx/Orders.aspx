<%@ Page language="c#" Codebehind="Orders.aspx.cs" AutoEventWireup="false" Inherits="WSCOrders.Orders" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>orderform</title>
		<meta content="Microsoft FrontPage 5.0" name="GENERATOR">
		<meta content="C#" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bottomMargin="200" leftMargin="15" topMargin="200" rightMargin="15" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<TABLE class="ordertable" id="cardList" style="Z-INDEX: 101; LEFT: 32px; WIDTH: 376px; POSITION: absolute; TOP: 320px; HEIGHT: 260px"
				cellSpacing="1" cellPadding="1" width="376" border="0">
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px; HEIGHT: 30px" align="left">
						<H3 class="Order Id">Order ID:</H3>
					</TD>
					<TD class="txtorderid" style="HEIGHT: 30px" align="center"><INPUT id="orderId" type="text" runat="server"></TD>
					<TD class="txtorderid" style="HEIGHT: 30px" align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Catalog ID:</H3>
					</TD>
					<TD align="center"><INPUT id="catId" type="text" runat="server"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Client ID:</H3>
					</TD>
					<TD align="center"><INPUT id="clientId" type="text" runat="server"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Card&nbsp;Type:</H3>
					</TD>
					<TD align="center"><INPUT id="cardType" type="text" runat="server"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Card Number</H3>
					</TD>
					<TD align="center"><INPUT id="cardnumber" type="text" size="20" runat="server"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Expiration Data</H3>
					</TD>
					<TD align="center"><INPUT id="Experationdate" type="text" size="20" runat="server"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Card Holder Name</H3>
					</TD>
					<TD align="center"><INPUT id="cardholdersname" type="text" size="20" runat="server"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px; HEIGHT: 26px" align="left">
						<H3>Order Details:</H3>
					</TD>
					<TD style="HEIGHT: 26px" align="center"><INPUT id="orderDetail" type="text" runat="server"></TD>
					<TD style="HEIGHT: 26px" align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px; HEIGHT: 15px" align="left">
						<H3>Price:</H3>
					</TD>
					<TD style="HEIGHT: 15px" align="center"><INPUT id="price" type="text" runat="server"></TD>
					<TD style="HEIGHT: 15px" align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>&nbsp;</H3>
					</TD>
					<TD align="center"><asp:button id="SubmitOrder" runat="server" Text="Submit Order" Width="103px" Height="23px"></asp:button></TD>
					<TD align="center"></TD>
				</TR>
			</TABLE>
			<asp:label id="Label1" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 272px" runat="server"
				Width="393px" Height="27px" Font-Size="Larger" Font-Names="Arial Unicode MS" Font-Bold="True">Please fill out the 
            <span lang="en-us">order </span>form.</asp:label>
			<HR style="Z-INDEX: 103; LEFT: 0px; WIDTH: 178.82%; POSITION: absolute; TOP: 168px; HEIGHT: 8px"
				width="178.82%" color="#0000ff" SIZE="8">
			<IMG style="Z-INDEX: 104; LEFT: 16px; WIDTH: 121px; POSITION: absolute; TOP: 8px; HEIGHT: 152px"
				height="152" src="logo.gif" width="121">
			<br>
			<A href="OrderDetails.aspx">Click here to go to order detail.</A><br>
			<br>
		</form>
	</body>
</HTML>
