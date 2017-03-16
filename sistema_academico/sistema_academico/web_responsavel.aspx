<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web_responsavel.aspx.cs" Inherits="sistema_academico.web_responsavel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="NOME"></asp:Label>
        <br />
        <asp:TextBox ID="tx_nome_resp" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tx_nome_resp" ErrorMessage="Campo Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="TELEFONE RESIDENCIAL"></asp:Label>
        <br />
        <asp:TextBox ID="tx_tel_resp" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tx_tel_resp" ErrorMessage="Campo Obrigatorio" ForeColor="Red"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="TELEFONE CELULAR"></asp:Label>
        <br />
        <asp:TextBox ID="tx_cel_resp" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="TELEFONE OPCIONAL"></asp:Label>
        <br />
        <asp:TextBox ID="tx_tel_opcional" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="NOME OPCIONAL"></asp:Label>
        <br />
        <asp:TextBox ID="tx_nome_opcional" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="btn_gravar_resp" runat="server" Text="GRAVAR" OnClick="btn_gravar_resp_Click" />
    
    </div>
    </form>
</body>
</html>
