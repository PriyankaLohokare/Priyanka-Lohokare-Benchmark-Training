<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body bgcolor="#DFD5E1 ">
    <form id="form1" runat="server">
        <div>
            <h1><asp:Label ID="Label1" runat="server" Text="Movie Details"></asp:Label></h1>
        </div>
        <asp:Repeater ID="Repeater1" runat="server" OnItemCommand="Repeater1_ItemCommand" DataSourceID="SqlDataSource1">
            <HeaderTemplate>
                <table border="1" bgcolor="#EE689E ">
                    <thead>
                        <th>Movie Id</th>
                        <th>Movie Title</th>
                        <th>Movie Language</th>
                        <th>Movie Year</th>
                    </thead>
            </HeaderTemplate>
            <ItemTemplate>
                <tr bgcolor="#E893F1 ">
                    <td><%#Eval("Movie_Id")%></td>
                     <td><%#Eval("Movie_Title")%></td>
                     <td><%#Eval("Movie_Lang")%></td>
                     <td><%#Eval("Movie_year")%></td>
                </tr>
            </ItemTemplate>
            <AlternatingItemTemplate>
                 <tr bgcolor="#B1E5EC ">
                    <td><%#Eval("Movie_Id")%></td>
                     <td><%#Eval("Movie_Title")%></td>
                     <td><%#Eval("Movie_Lang")%></td>
                     <td><%#Eval("Movie_year")%></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
               
                </table>
            </FooterTemplate>
        </asp:Repeater>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MovieDbConnectionString %>" SelectCommand="SELECT * FROM [Movie]"></asp:SqlDataSource>
    </form>
</body>
</html>
