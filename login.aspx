<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DevEvas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="user-scaling=no, width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="css/normalize.css" />
    <link rel="stylesheet" href="css/simple-grid.css" />
    <link rel="stylesheet" href="css/index.css" />
    <link href="https://fonts.googleapis.com/css?family=Lato|Roboto|Open+Sans|Poiret+One|Poppins:100,200,400,300,500,600,700" rel="stylesheet" />
</head>
<body class="login-background">
    <a href="index.html" class="login-logo">
        <img src="img/frutech6.png" alt="FruTech" class="frutech-logo" />
    </a>
    <main>
        <form runat="server" id="frmLogin">
            <section class="login-back">
                <div class="login-holder">
                    <p class="login-title">Login</p>
                    <div>
                        <asp:TextBox runat="server" ID="txtUsuario" CssClass="input" placeholder="NOME DE USUÁRIO" MaxLength="20" />
                    </div>
                    <div>
                        <asp:TextBox runat="server" ID="txtSenha" CssClass="input" placeholder="SENHA" MaxLength="20" TextMode="Password" />
                    </div>
                    <div class="forgetpass-holder">
                        <a href="https://devevas.freshdesk.com/support/home" class="forgetpass__link">Esqueceu sua senha?</a>
                    </div>
                </div>
                <div class="btn-holder">
                    <div class="btn-register">
                        <a href="cadastro.aspx" class="btn__link--register">CADASTRE-SE</a>
                    </div>
                    <div class="btn-signin">
                        <asp:Button Text="ENTRAR" runat="server" ID="btnEnviar" CssClass="btn-signin" OnClick="btnEnviar_Click"/>
                    </div>
                </div>
            </section>
        </form>
    </main>
</body>
</html>

