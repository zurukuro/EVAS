<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="SiteEVAS.login" %>

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
    <main class="login__background">
        <div class="container">
            <div class="row row-center">
                <div class="col-2">
                    <a href="index.html" class="login__logo"></a>
                </div>
            </div>
        </div>
        <section class="login">
            <div class="container">
                <div class="row row-center">
                    <div class="col-4 login__holder">
                        <h3>Acesso ao perfil</h3>
                        <form id="frmLogin" runat="server" class="form-login">
                            <div>
                                <asp:TextBox runat="server" ID="txtUsuario" CssClass="input" placeholder="Nome de Usuário" MaxLength="20" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" TextMode="Password" ID="txtSenha" CssClass="input" placeholder="Senha" MaxLength="20" />
                                <p class="forgetpass">Esqueceu sua senha? Entre em <a href="contato.html" class="forgetpass__link">contato</a> conosco.</p>
                            </div>
                            <asp:Button Text="Enviar" runat="server" ID="btnEnviar" CssClass="btnsquare btn--terciary" OnClick="btnEnviar_Click" />
                        </form>
                        <p class="login__text">Ainda não é cadastrado?</p>
                        <a href="cadastro.aspx" class="btnsquare btn--terciary">Cadastre-se</a>
                    </div>
                </div>
            </div>
        </section>
        <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
        <script src="js/index.js"></script>
    </main>
</body>
</html>
