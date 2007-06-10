<%@ Page language="c#" Codebehind="cart.aspx.cs" AutoEventWireup="false" Inherits="WSCOrders.cart" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>cart</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<IMG style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 16px" src="logo.gif">
			<TABLE id="Table1" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 264px" cellSpacing="1"
				cellPadding="1" width="300" border="3">
				<TR>
					<TD style="WIDTH: 142px">
						<H3>Customer Name:</H3>
					</TD>
					<TD>
						<DIV id="userName" style="DISPLAY: inline; WIDTH: 160px; HEIGHT: 19px" ms_positioning="FlowLayout"
							runat="server"></DIV>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 142px">
						<H3>Details:</H3>
					</TD>
					<TD>
						<DIV id="Details" style="DISPLAY: inline; WIDTH: 160px; HEIGHT: 19px" ms_positioning="FlowLayout"
							runat="server"></DIV>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 142px">
						<H3>Catalog ID:</H3>
					</TD>
					<TD>
						<DIV id="catalogId" style="DISPLAY: inline; WIDTH: 160px; HEIGHT: 19px" ms_positioning="FlowLayout"
							runat="server"></DIV>
					</TD>
				</TR>
			</TABLE>
			<HR style="Z-INDEX: 102; LEFT: -8px; WIDTH: 174.37%; POSITION: absolute; TOP: 160px; HEIGHT: 8px"
				width="174.37%" color="#0000ff" SIZE="8">
			<DIV style="DISPLAY: inline; Z-INDEX: 104; LEFT: 72px; WIDTH: 216px; POSITION: absolute; TOP: 224px; HEIGHT: 37px"
				ms_positioning="FlowLayout">
				<H2><FONT color="#000000">Shopping Cart</FONT>
				</H2>
			</DIV>
			<INPUT id="Checkout" style="Z-INDEX: 105; LEFT: 176px; WIDTH: 120px; POSITION: absolute; TOP: 432px; HEIGHT: 24px"
				type="button" value="Check Out">
		</form>
	</body>
</HTML>
