<%@ Page Title="Movie List" Language="C#" Inherits="MoviesListProject.Default"
CodeBehind="Default.aspx.cs" AutoEventWireup="true" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Movies Details Page</title>
            <style>
        select[id*='ListBox1'] option {
            white-space:normal;
        }
    </style>
</head>
<body>
	<form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="Movie Id"></asp:Label>   
        <asp:TextBox ID="txtFN" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="SUBMIT" onclick="Button1_Click" />
        </div>
        <br/>
        <div style="border: solid 5px blue; float: left; height:400px; width: 200px;">
        <asp:ListBox ID="ListBox1" runat="server" Text="Movie Names" ItemType="bold" Rows="3" height="400px" width ="200px"
                SelectionMode="Single"></asp:ListBox>
        </div>
        <div style="border: solid 5px red; float: left; height:400px; width: 400px;">    
                <asp:Image ID="Image1" runat="server" AlternateText ="Movie Poster :" height="400px" width ="400px" />
        </div>       


	</form>
</body>
</html>
