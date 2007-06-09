<%@ Page language="c#" Codebehind="OrderDetails.aspx.cs" AutoEventWireup="false" Inherits="WSCOrders.OrderDetails" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>OrderDetails</title>
		<meta name="GENERATOR" Content="Microsoft FrontPage 5.0">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			&nbsp;
			<TABLE class="ordertable" id="cardList" style="Z-INDEX: 102; LEFT: 40px; WIDTH: 376px; POSITION: absolute; TOP: 272px; HEIGHT: 260px"
				cellSpacing="1" cellPadding="1" width="376" border="0">
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px; HEIGHT: 30px" align="left">
						<H3 class="Order Id">Order ID:</H3>
					</TD>
					<TD class="txtorderid" style="HEIGHT: 30px" align="center">
						<asp:TextBox id="id" runat="server"></asp:TextBox></TD>
					<TD class="txtorderid" style="HEIGHT: 30px" align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Cataloge ID:</H3>
					</TD>
					<TD align="center">
						<asp:TextBox id="catalogid" runat="server"></asp:TextBox></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Client ID:</H3>
					</TD>
					<TD align="center">
						<asp:TextBox id="clientid" runat="server"></asp:TextBox></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Card&nbsp;Type:</H3>
					</TD>
					<TD align="center">
						<asp:TextBox id="paymentid" runat="server"></asp:TextBox></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Card Number</H3>
					</TD>
					<TD align="center"><INPUT type="text" size="20"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Expiration Data</H3>
					</TD>
					<TD align="center"><INPUT type="text" size="20"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px" align="left"><H3>Card Holder Name</H3>
					</TD>
					<TD align="center"><INPUT type="text" size="20"></TD>
					<TD align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px; HEIGHT: 26px" align="left">
						<H3>Order Details:</H3>
					</TD>
					<TD style="HEIGHT: 26px" align="center">
						<asp:TextBox id="details" runat="server"></asp:TextBox></TD>
					<TD style="HEIGHT: 26px" align="center"></TD>
				</TR>
				<TR>
					<TD style="FONT-WEIGHT: bold; WIDTH: 168px; HEIGHT: 15px" align="left">
						<H3>Price:</H3>
					</TD>
					<TD style="HEIGHT: 15px" align="center">
						<asp:TextBox id="price" runat="server"></asp:TextBox></TD>
					<TD style="HEIGHT: 15px" align="center"></TD>
				</TR>
				<TR>
					<TD align="center">
						<asp:Button id="editOrder" runat="server" Text="Edit Order" Height="29px"></asp:Button>
					</TD>
					</TD>
					<TD align="center">
						<asp:Button id="SubmitOrder" runat="server" Text="Submit Order To Cart" Height="29px"></asp:Button></TD>
					<TD align="center"></TD>
				</TR>
			</TABLE>
			<HR style="Z-INDEX: 101; LEFT: -16px; WIDTH: 159.02%; POSITION: absolute; TOP: 168px; HEIGHT: 8px"
				width="159.02%" color="#0000ff" SIZE="8">
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 136px; POSITION: absolute; TOP: 208px" runat="server"
				Width="232px" Height="30px" Font-Size="X-Large">Order Detail</asp:Label>
			<H3 align="center">
				<H3 align="center">
					<H3 align="center"><IMG style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 16px" src="logo.gif"></H3>
				</H3>
			</H3>
		</form>
	</body>
</HTML>
