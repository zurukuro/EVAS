<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cadastro.aspx.cs" Inherits="SiteEVAS.cadastro" %>

<!DOCTYPE html>

<html style="height: 100%" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <link rel="stylesheet" href="css/normalize.css" />
    <link rel="stylesheet" href="css/simple-grid.css" />
    <link rel="stylesheet" href="css/index.css" />
    <link href="https://fonts.googleapis.com/css?family=Lato|Roboto|Open+Sans|Poiret+One|Poppins:100,200,400,300,500,600,700" rel="stylesheet" />
    <title></title>
</head>
<body style="height: 100%">
    <main class="cadastro__background">
        <div class="container">
            <div class="row row-center">
                <div class="col-2">
                    s
                    <a href="index.html" class="login__logo"></a>
                </div>
            </div>
        </div>
        <section class="cadastro">
            <div class="container">
                <div class="row row-center">
                    <div class="col-4 cadastro__holder">
                        <h3>Crie sua conta</h3>
                        <form id="frmCadastro" runat="server" class="form-cadastro">
                            <div>
                                <asp:TextBox runat="server" ID="txtUsuario" CssClass="input" placeholder="Nome de Usuário" MaxLength="20" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" TextMode="Password" ID="txtSenha" CssClass="input" placeholder="Senha" MaxLength="20" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" TextMode="Password" ID="txtConfirmeSenha" CssClass="input" placeholder="Confirme sua Senha" MaxLength="20" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtNomeCompleto" CssClass="input" placeholder="Nome Completo" MaxLength="50" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtEmail" CssClass="input" placeholder="Email" MaxLength="50" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtCPF" CssClass="input" placeholder="CPF (Somente os Números)" MaxLength="11" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtCEP" CssClass="input" placeholder="CEP (Somente os Números)" MaxLength="8" Width="90%" AutoPostBack="true" OnTextChanged="txtCEP_TextChanged" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtLogradouro" CssClass="input" placeholder="Rua" MaxLength="50" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtNumeroLocal" CssClass="input" placeholder="Número do Endereço" MaxLength="7" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtComplemento" CssClass="input" placeholder="Complemento" MaxLength="30" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtBairro" CssClass="input" placeholder="Bairro" MaxLength="50" Width="90%" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtCidade" CssClass="input" placeholder="Cidade" MaxLength="50" Width="90%" />
                            </div>

                            <div>
                                <asp:DropDownList runat="server" ID="ddlUF" CssClass="input" Width="90%">
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
                                    <asp:ListItem Text="RO" />
                                    <asp:ListItem Text="RR" />
                                    <asp:ListItem Text="RS" />
                                    <asp:ListItem Text="SC" />
                                    <asp:ListItem Text="SE" />
                                    <asp:ListItem Text="SP" />
                                    <asp:ListItem Text="TO" />
                                </asp:DropDownList>
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtTelefone" CssClass="input" placeholder="Telefone com DDD (Somente Número)" MaxLength="11" Width="90%" />
                            </div>
                            <p class="news">
                                <asp:CheckBox Text=" Quero receber as notificações de atualização do Sistema via E-mail" runat="server" ID="ckbNotificacao" />
                            </p>
                            <asp:Button Text="Enviar" runat="server" ID="btnEnviar" CssClass="btnsquare btn--terciary" OnClick="btnEnviar_Click" />
                        </form>
                    </div>
                </div>
            </div>
        </section>
    </main>
</body>
</html>
