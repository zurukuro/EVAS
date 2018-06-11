﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="contato.aspx.cs" Inherits="DevEvas.contato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Contato</title>
    <meta name="viewport" content="user-scaling=no, width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="css/normalize.css" />
    <link rel="stylesheet" href="css/simple-grid.css" />
    <link rel="stylesheet" href="css/index.css" />
    <link href="https://fonts.googleapis.com/css?family=Lato|Roboto|Open+Sans|Poiret+One|Poppins:100,200,400,300,500,600,700" rel="stylesheet" />
    <script src="https://wchat.freshchat.com/js/widget.js"></script>
</head>
<body>
    <header class="header">
        <div class="header__wrapper">
            <a href="index.html" class="logo"></a>
            <nav class="nav">
                <ul class="nav__list">
                    <li class="nav__item left">
                        <a href="frutech.html" class="nav__link">FruTech</a>
                    </li>
                    <li class="nav__item  nav__item--column left">
                        <a href="sobrenos.html" class="nav__link">Sobre nós</a>
                    </li>
                    <li class="nav__item left">
                        <a href="contato.aspx" class="nav__link">Contato</a>
                    </li>
                </ul>
                <div class="nav__item--login right">
                    <a href="login.aspx" class="nav__login">Login</a>
                </div>
            </nav>
        </div>
        <div id="mobile-trigger" class="mobile-trigger">
            <span class="trigger-btn--1"></span>
            <span class="trigger-btn--2"></span>
            <span class="trigger-btn--3"></span>
        </div>
    </header>
    <main>
        <section class="contactus">
            <div class="container">
                <div class="row row-center">
                    <div class="col-8 contactus__desc">
                        <h1 class="contactus__title">Olá! :)</h1>
                        <p class="contactus__text">Ainda tem dúvidas sobre nós ou nossos serviços? Mande uma mensagem pra gente! Vamos bater um papo e alinhar tudo certinho.</p>
                    </div>
                </div>
            </div>
            <div class="container">
                <div class="row row-center">
                    <div class="col-6">
                        <form runat="server" id="frmContato" class="form">
                            <div>
                                <asp:TextBox runat="server" ID="txtNomeCompleto" CssClass="input" placeholder="Nome Completo" MaxLength="50" />
                            </div>

                            <div>
                                <asp:TextBox runat="server" ID="txtEmail" CssClass="input" placeholder="Email" MaxLength="50" />
                            </div>

                            <div>
                                <asp:DropDownList runat="server" ID="ddlAssunto" CssClass="input" placeholder="Assunto">
                                    <asp:ListItem Text="-- Selecione --" />
                                    <asp:ListItem Text="Preços" />
                                    <asp:ListItem Text="Assistência Técnica" />
                                    <asp:ListItem Text="Dúvidas" />
                                    <asp:ListItem Text="Outros" />
                                </asp:DropDownList>
                            </div>

                            <div class="btnenviar">
                                <asp:TextBox runat="server" ID="txtMensagem" CssClass="textarea" placeholder="Mensagem" TextMode="MultiLine" />
                                <asp:Button Text="Enviar" runat="server" ID="btnEnviar" CssClass="btnsquare btn--terciary" OnClick="btnEnviar_Click"/>
                            </div>
                        </form>
                    </div>
                </div>
            </div>
        </section>
        <script>
            window.fcWidget.init({
                token: "6c898dcd-c381-4a37-9e0f-99511646612f",
                host: "https://wchat.freshchat.com"
            });
        </script>
    </main>
    <footer class="footer-area footer-gap">
        <div class="container">
            <div class="row">
                <div class="col-5">
                    <h4 class="footer__title">Sobre nós</h4>
                    <p class="footer__text">A EVAS é uma empresa especializada em soluções tecnológicas para o consumidor simples</p>
                    <p class="footer__text">
                        <br/>
                        Alguns direitos reservados, 2018 | Website feito com <span class="footer__color">❤</span> por <a href="index.html" class="footer__color">EVAS</a>
                    </p>
                </div>
                <div class="col-4">
                    <h4 class="footer__title">Contato</h4>
                    <p class="footer__text footer__margin">Tem alguma dúvida? Entre em contato conosco</p>
                    <a href="contato.aspx" class="btnsquare btn--terciary">Contato</a>
                </div>
                <div class="col-3">
                    <h4 class="footer__title">Segue a gente!</h4>
                    <p class="footer__text">Fique por dentro das novidades!</p>
                    <div class="social-media">
                        <a href="https://github.com/zurukuro/EVAS" class="icon-link">
                            <svg class="icon-footer icon-github">
                                <symbol id="icon-github" viewBox="0 0 32 32">
                                    <title>github</title>
                                    <path d="M16 0.395c-8.836 0-16 7.163-16 16 0 7.069 4.585 13.067 10.942 15.182 0.8 0.148 1.094-0.347 1.094-0.77 0-0.381-0.015-1.642-0.022-2.979-4.452 0.968-5.391-1.888-5.391-1.888-0.728-1.849-1.776-2.341-1.776-2.341-1.452-0.993 0.11-0.973 0.11-0.973 1.606 0.113 2.452 1.649 2.452 1.649 1.427 2.446 3.743 1.739 4.656 1.33 0.143-1.034 0.558-1.74 1.016-2.14-3.554-0.404-7.29-1.777-7.29-7.907 0-1.747 0.625-3.174 1.649-4.295-0.166-0.403-0.714-2.030 0.155-4.234 0 0 1.344-0.43 4.401 1.64 1.276-0.355 2.645-0.532 4.005-0.539 1.359 0.006 2.729 0.184 4.008 0.539 3.054-2.070 4.395-1.64 4.395-1.64 0.871 2.204 0.323 3.831 0.157 4.234 1.026 1.12 1.647 2.548 1.647 4.295 0 6.145-3.743 7.498-7.306 7.895 0.574 0.497 1.085 1.47 1.085 2.963 0 2.141-0.019 3.864-0.019 4.391 0 0.426 0.288 0.925 1.099 0.768 6.354-2.118 10.933-8.113 10.933-15.18 0-8.837-7.164-16-16-16z"></path>
                                </symbol>
                                <use xlink:href="#icon-github"></use>
                            </svg>
                        </a>
                        <a href="https://twitter.com/dev_evas" class="icon-link">
                            <svg class="icon-footer icon-twitter">
                                <symbol id="icon-twitter" viewBox="0 0 32 32">
                                    <title>twitter</title>
                                    <path d="M32 7.075c-1.175 0.525-2.444 0.875-3.769 1.031 1.356-0.813 2.394-2.1 2.887-3.631-1.269 0.75-2.675 1.3-4.169 1.594-1.2-1.275-2.906-2.069-4.794-2.069-3.625 0-6.563 2.938-6.563 6.563 0 0.512 0.056 1.012 0.169 1.494-5.456-0.275-10.294-2.888-13.531-6.862-0.563 0.969-0.887 2.1-0.887 3.3 0 2.275 1.156 4.287 2.919 5.463-1.075-0.031-2.087-0.331-2.975-0.819 0 0.025 0 0.056 0 0.081 0 3.181 2.263 5.838 5.269 6.437-0.55 0.15-1.131 0.231-1.731 0.231-0.425 0-0.831-0.044-1.237-0.119 0.838 2.606 3.263 4.506 6.131 4.563-2.25 1.762-5.075 2.813-8.156 2.813-0.531 0-1.050-0.031-1.569-0.094 2.913 1.869 6.362 2.95 10.069 2.95 12.075 0 18.681-10.006 18.681-18.681 0-0.287-0.006-0.569-0.019-0.85 1.281-0.919 2.394-2.075 3.275-3.394z"></path>
                                </symbol>
                                <use xlink:href="#icon-twitter"></use>
                            </svg>
                        </a>
                    </div>
                </div>
            </div>
        </div>
    </footer>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
    <script src="js/index.js"></script>
</body>
</html>
