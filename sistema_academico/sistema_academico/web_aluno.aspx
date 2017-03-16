<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="web_aluno.aspx.cs" Inherits="sistema_academico.web_aluno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="style.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="formulario">
    
        <a href="web_responsavel.aspx"><asp:Label ID="Label17" runat="server" Text="CADASTRO RESPONSAVEL"></asp:Label></a>
        <br />
        <br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="NOME"></asp:Label>
        <br />
        <asp:TextBox ID="tx_nome" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="CEP"></asp:Label>
        <br />
        <asp:TextBox ID="tx_cep" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="LOGRADOURO"></asp:Label>
        <br />
        <asp:TextBox ID="tx_logradouro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Nº"></asp:Label>
        <br />
        <asp:TextBox ID="tx_numero" runat="server" Width="43px"></asp:TextBox>
        <br />
        <asp:Label ID="Label15" runat="server" Text="COMPLEMENTO"></asp:Label>
        <br />
        <asp:TextBox ID="tx_complemento" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label16" runat="server" Text="BAIRRO"></asp:Label>
        <br />
        <asp:TextBox ID="tx_bairro" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label14" runat="server" Text="CIDADE"></asp:Label>
        <br />
        <asp:TextBox ID="tx_cidade" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label13" runat="server" Text="ESTADO"></asp:Label>
        <br />
        <asp:TextBox ID="tx_estado" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="RG"></asp:Label>
        <br />
        <asp:TextBox ID="tx_rg" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text="CPF"></asp:Label>
        <br />
        <asp:TextBox ID="tx_cpf" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label7" runat="server" Text="TELEFONE"></asp:Label>
        <br />
        <asp:TextBox ID="tx_telefone" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label8" runat="server" Text="CELULAR"></asp:Label>
        <br />
        <asp:TextBox ID="tx_celular" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label9" runat="server" Text="DATA NASCIMENTO"></asp:Label>
        <br />
        <asp:TextBox ID="tx_dt_nascimento" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label10" runat="server" Text="RESPONSAVEL"></asp:Label>
        <br />
        <asp:DropDownList ID="ddl_responsavel" runat="server" Height="44px" Width="168px" DataSourceID="SqlDataSource1" DataTextField="nome_responsavel" DataValueField="nome_responsavel">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:sistema_academicoConnectionString %>" SelectCommand="SELECT [nome_responsavel] FROM [tb_responsavel]"></asp:SqlDataSource>
        <br />
        <asp:Label ID="Label11" runat="server" Text="EMAIL"></asp:Label>
        <br />
        <asp:TextBox ID="tx_email" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label12" runat="server" Text="SITUACAO"></asp:Label>
        <br />
        <asp:DropDownList ID="ddl_situacao" runat="server" Width="127px">
            <asp:ListItem Value="TRUE">ativo</asp:ListItem>
            <asp:ListItem Value="false">falso</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Button ID="bt_gravar" runat="server" OnClick="bt_gravar_Click" Text="GRAVAR" />
    
    </div>
    </form>
</body>
</html>
