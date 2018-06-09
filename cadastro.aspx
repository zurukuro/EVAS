<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="DevEvas.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <title>Cadastro</title>
    <link rel="stylesheet" href="css/normalize.css" />
    <link rel="stylesheet" href="css/simple-grid.css" />
    <link rel="stylesheet" href="css/index.css" />
    <link href="https://fonts.googleapis.com/css?family=Lato|Roboto|Open+Sans|Poiret+One|Poppins:100,200,400,300,500,600,700" rel="stylesheet" />
</head>
<body class="register-background">
    <main>
        <form runat="server" id="frmCadastro">
            <div class="cadastro-holder">
                <section class="register-back__left">
                    <div class="register-holder">
                        <p class="register-title">Cadastre-se</p>
                        <div>
                            <asp:TextBox runat="server" ID="txtUsuario" CssClass="input" placeholder="NOME DE USUÁRIO" MaxLength="20" />
                        </div>
                        <div class="pass-holder">
                            <asp:TextBox runat="server" ID="txtSenha" CssClass="input" placeholder="SENHA" MaxLength="20" TextMode="Password" />
                            <asp:TextBox runat="server" ID="txtConfirmeSenha" CssClass="input" placeholder="CONFIRMAÇÃO DA SENHA" MaxLength="20" TextMode="Password" />
                        </div>
                        <div>
                            <asp:TextBox runat="server" ID="txtEmail" CssClass="input" placeholder="EMAIL" MaxLength="50" />
                        </div>
                        <div>
                            <asp:TextBox runat="server" ID="txtNomeCompleto" CssClass="input" placeholder="NOME COMPLETO" MaxLength="50" />
                        </div>
                        <div>
                            <asp:TextBox runat="server" ID="txtCPF" CssClass="input" placeholder="CPF (Somente Números)" MaxLength="11" />
                        </div>
                    </div>
                </section>
                <section class="register-back">
                    <div class="register-holder">
                        <div class="pass-holder">
                            <asp:TextBox runat="server" ID="txtCEP" CssClass="input" placeholder="CEP" MaxLength="8" OnTextChanged="txtCEP_TextChanged" />
                            <asp:TextBox runat="server" ID="txtTelefone" CssClass="input" MaxLength="11" placeholder="Telefone com DDD (Somente os número)" />
                        </div>
                        <div>
                            <asp:TextBox runat="server" ID="txtLogradouro" CssClass="input" placeholder="RUA" MaxLength="50" />
                        </div>
                        <div>
                            <asp:TextBox runat="server" ID="txtBairro" CssClass="input" placeholder="BAIRRO" MaxLength="50" />
                        </div>
                        <div class="pass-holder">
                            <asp:TextBox runat="server" ID="txtComplemento" CssClass="input" placeholder="COMPLEMENTO" MaxLength="30" />
                            <asp:TextBox runat="server" ID="txtNumeroLocal" CssClass="input" placeholder="NÙMERO" MaxLength="20" />
                        </div>
                        <div class="pass-holder">
                            <asp:TextBox runat="server" ID="txtCidade" CssClass="input" placeholder="CIDADE" MaxLength="50" />
                            <asp:DropDownList runat="server" ID="ddlUF" CssClass="input">
                                <asp:ListItem Text="-- Selecione --" />
                                <asp:ListItem Text="AC" />
                                <asp:ListItem Text="AL" />
                                <asp:ListItem Text="AM" />
                                <asp:ListItem Text="AP" />
                                <asp:ListItem Text="BA" />
                                <asp:ListItem Text="CE" />
                                <asp:ListItem Text="DF" />
                                <asp:ListItem Text="ES" />
                                <asp:ListItem Text="GO" />
                                <asp:ListItem Text="MA" />
                                <asp:ListItem Text="MG" />
                                <asp:ListItem Text="MS" />
                                <asp:ListItem Text="MT" />
                                <asp:ListItem Text="PA" />
                                <asp:ListItem Text="PB" />
                                <asp:ListItem Text="PE" />
                                <asp:ListItem Text="PI" />
                                <asp:ListItem Text="PR" />
                                <asp:ListItem Text="RJ" />
                                <asp:ListItem Text="RN" />
                                <asp:ListItem Text="RD" />
                                <asp:ListItem Text="RR" />
                                <asp:ListItem Text="RS" />
                                <asp:ListItem Text="SC" />
                                <asp:ListItem Text="SE" />
                                <asp:ListItem Text="SP" />
                                <asp:ListItem Text="TO" />
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="btn-holder">
                        <div class="btn-register">
                            <asp:Button Text="VOLTAR" runat="server" ID="btnVoltar" CssClass="btn__link--register" OnClick="btnVoltar_Click" />
                        </div>
                        <div class="btn-signin">
                            <asp:Button Text="CADASTRAR" runat="server" ID="btnEnviar" CssClass="btn__link--signin" OnClick="btnEnviar_Click" />
                        </div>
                    </div>
                </section>
            </div>
        </form>
    </main>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="js/index.js"></script>
</body>
</html>
