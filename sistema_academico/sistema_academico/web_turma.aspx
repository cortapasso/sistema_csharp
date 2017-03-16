<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web_turma.aspx.cs" Inherits="sistema_academico.web_turma" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="SIGLA TURMA"></asp:Label>
    <div>
    
        <asp:TextBox ID="tx_turma" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="PERIODO"></asp:Label>
        <br />
        <asp:TextBox ID="tx_periodo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="MODULO"></asp:Label>
        <br />
        <asp:DropDownList ID="ddl_modulo" runat="server" DataSourceID="SqlDataSource1" DataTextField="modulo" DataValueField="modulo" Height="36px" Width="128px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sistema_academicoConnectionString %>" SelectCommand="SELECT [modulo] FROM [tb_turma]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <asp:Button ID="btn_gravarturma" runat="server" OnClick="btn_gravarturma_Click" Text="GRAVAR" />
    
    </div>
    </form>
</body>
</html>
