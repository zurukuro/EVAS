using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//*******************************************
// REFERENCIANDO AS BIBLIOTECAS NECESSÁRIAS
using System.Data.SqlClient;
using System.Data;
//*******************************************

namespace SiteEVAS
{
    public partial class cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            #region Validação dos Campos
            //Verifica se o campo ta vazio
            if (txtUsuario.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtUsuario.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite o Usuário')</script>");
                //Response.Write("<script>alert('Digite o Usuário')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtUsuario.Text.Replace("'", "´");
            }

            //Verifica se o campo ta vazio
            if (txtSenha.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtSenha.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite sua Senha')</script>");
                //Response.Write("<script>alert('Digite a Senha')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtSenha.Text.Replace("'", "´");
            }

            //Verifica se o campo ta vazio
            if (txtConfirmeSenha.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtConfirmeSenha.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Confirme sua Senha')</script>");
                //Response.Write("<script>alert('Confirme sua Senha')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Verifica se a Senhas são iguais
                if (txtConfirmeSenha.Text != txtSenha.Text)
                {
                    //Traz o Cursor do Mouse para este ponto
                    txtSenha.Focus();

                    //Mostra Mensagem de aviso na Tela
                    ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Senhas não coincidem')</script>");
                    //Response.Write("<script>alert('Senhas não coincidem')</script>");

                    //Limpa o Campo abaixo
                    txtConfirmeSenha.Text = string.Empty;

                    //Para a aplicação
                    return;
                }
                else
                {
                    //Tratamento de Campo ao enviar ao banco de dados
                    txtUsuario.Text.Replace("'", "´");
                }
            }

            //Verifica se o campo ta vazio
            if (txtNomeCompleto.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtNomeCompleto.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite o seu nome Completo')</script>");
                //Response.Write("<script>alert('Digite o seu Nome Completo')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtNomeCompleto.Text.Replace("'", "´");
            }

            //Verifica se o campo ta vazio
            if (txtEmail.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtEmail.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite seu E-mail')</script>");
                //Response.Write("<script>alert('Digite seu E-mail')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtEmail.Text.Replace("'", "´");
            }

            //Verifica se o campo ta vazio
            if (txtCPF.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtCPF.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite seu CPF')</script>");
                //Response.Write("<script>alert('Digite seu CPF')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtCPF.Text.Replace("'", "´");
            }

            //Verifica se o campo ta vazio
            if (txtCEP.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtCEP.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite seu CEP')</script>");
                //Response.Write("<script>alert('Digite seu CEP')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtCEP.Text.Replace("'", "´");
            }

            //Verifica se o campo ta vazio
            if (txtLogradouro.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtLogradouro.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite sua Rua')</script>");
                //Response.Write("<script>alert('Digite sua Rua')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtLogradouro.Text.Replace("'", "´");
            }

            //Verifica se o campo ta vazio
            if (txtNumeroLocal.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtNumeroLocal.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite o Número do Endereço')</script>");
                //Response.Write("<script>alert('Digite o Número do Endereço')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtNumeroLocal.Text.Replace("'", "´");
            }

            //Tratamento de Campo ao enviar ao banco de dados
            txtComplemento.Text.Replace("'", "´");

            //Verifica se o campo ta vazio
            if (txtBairro.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtBairro.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite o seu Bairro')</script>");
                //Response.Write("<script>alert('Digite o seu Bairro')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtBairro.Text.Replace("'", "´");
            }

            //Verifica se o campo ta vazio
            if (txtCidade.Text == string.Empty)
            {
                //Traz o Cursor do Mouse para este ponto
                txtCidade.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Digite a sua Cidade')</script>");
                //Response.Write("<script>alert('Digite a sua Cidade')</script>");

                //Para a aplicação
                return;
            }
            else
            {
                //Tratamento de Campo ao enviar ao banco de dados
                txtCidade.Text.Replace("'", "´");
            }

            //Verifica se o campo ta vazio
            if (ddlUF.Text == "-- Selecione --")
            {
                //Traz o Cursor do Mouse para este ponto
                ddlUF.Focus();

                //Mostra Mensagem de aviso na Tela
                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Selecione um Estado')</script>");
                //Response.Write("<script>alert('Selecione um Estado')</script>");

                //Para a aplicação
                return;
            }

            //Tratamento de Campo ao enviar ao banco de dados
            txtTelefone.Text.Replace("'", "´");


            //Cria a Conexão com o Banco
            using (SqlConnection conn = new SqlConnection("Server=tcp:zackariel.database.windows.net,1433;Initial Catalog=Duffoux;Persist Security Info=False;User ID=Duffoux;Password=Rick091295;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                //Abri a Conexão com o Banco
                conn.Open();

                //Cria um comando para selecionar registros da tabela, trazendo todos os usuários da tabela que sejam igual ao informado pelo usuário
                using (SqlCommand cmd = new SqlCommand("SELECT Usuario FROM tblLogin WHERE Usuario = @usuario", conn))
                {
                    //Parametros da query acima, os valores podem vir de objetos do formulario como por exemplo um TEXTBOX
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);

                    //Executa a Query acima
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Verifica se retorno algum registro
                        while (reader.Read() == true)
                        {
                            //Traz o Cursor do Mouse para este ponto
                            txtUsuario.Focus();

                            //Mostra Mensagem de aviso na Tela
                            ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Este usuário já existe')</script>");
                            //Response.Write("<script>Alert('Este usuário já existe')</script>");

                            //Para a aplicação
                            return;
                        }
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection("Server=tcp:zackariel.database.windows.net,1433;Initial Catalog=Duffoux;Persist Security Info=False;User ID=Duffoux;Password=Rick091295;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                //Abri a Conexão com o Banco
                conn.Open();

                //Cria um comando para selecionar registros da tabela, trazendo todos os e-mails da tabela que sejam igual ao informado pelo usuário
                using (SqlCommand cmd = new SqlCommand("SELECT Email FROM tblCliente WHERE Email = @Email", conn))
                {
                    //Parametros da query acima, os valores podem vir de objetos do formulario como por exemplo um TEXTBOX
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                    //Executa a Query acima
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Verifica se retorno algum registro
                        while (reader.Read() == true)
                        {
                            //Traz o Cursor do Mouse para este ponto
                            txtEmail.Focus();

                            //Mostra Mensagem de aviso na Tela
                            ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Este E-mail já existe')</script>");
                            //Response.Write("<script>Alert('Este E-mail já existe')</script>");

                            //Para a aplicação
                            return;
                        }
                    }
                }
            }

            using (SqlConnection conn = new SqlConnection("Server=tcp:zackariel.database.windows.net,1433;Initial Catalog=Duffoux;Persist Security Info=False;User ID=Duffoux;Password=Rick091295;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                //Abri a Conexão com o Banco
                conn.Open();

                //Cria um comando para selecionar registros da tabela, trazendo todos os CPFs da tabela que sejam igual ao informado pelo usuário
                using (SqlCommand cmd = new SqlCommand("SELECT CPF FROM tblCliente WHERE CPF = @CPF", conn))
                {
                    //Parametros da query acima, os valores podem vir de objetos do formulario como por exemplo um TEXTBOX
                    cmd.Parameters.AddWithValue("@CPF", txtCPF.Text);

                    //Executa a Query acima
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Verifica se retorno algum registro
                        while (reader.Read() == true)
                        {
                            //Traz o Cursor do Mouse para este ponto
                            txtCPF.Focus();

                            //Mostra Mensagem de aviso na Tela
                            ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Este CPF já existe')</script>");
                            //Response.Write("<script>Alert('Este CPF já existe')</script>");

                            //Para a aplicação
                            return;
                        }
                    }
                }
            }
            #endregion

            #region Enviar Informações ao Banco de Dados
            //Cria a Conexão com o Banco
            using (SqlConnection conn = new SqlConnection("Server=tcp:zackariel.database.windows.net,1433;Initial Catalog=Duffoux;Persist Security Info=False;User ID=Duffoux;Password=Rick091295;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                using (SqlConnection conn2 = new SqlConnection("Server=tcp:zackariel.database.windows.net,1433;Initial Catalog=Duffoux;Persist Security Info=False;User ID=Duffoux;Password=Rick091295;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
                {
                    conn2.Open();

                    // Cria um comando para selecionar registros da tabela, trazendo o CEP informado pelo usuário
                    using (SqlCommand select = new SqlCommand("Select IdEndereco, CEP from tblEndereco where CEP = @CEP", conn2))
                    {
                        // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                        select.Parameters.AddWithValue("@CEP", txtCEP.Text);
                        using (SqlDataReader reader = select.ExecuteReader())
                        {
                            if (reader.Read() == true)
                            {
                                int idEndereco = reader.GetInt32(0);
                                using (SqlCommand upEnd = new SqlCommand("UPDATE tblEndereco set LOGRADOURO=@LOGRADOURO, CEP=@CEP, BAIRRO=@BAIRRO, CIDADE=@CIDADE, UF=@UF where IdEndereco=@IdEndereco", conn))
                                {
                                    upEnd.Parameters.AddWithValue("@LOGRADOURO", txtLogradouro.Text);
                                    upEnd.Parameters.AddWithValue("@CEP", txtCEP.Text);
                                    upEnd.Parameters.AddWithValue("@BAIRRO", txtBairro.Text);
                                    upEnd.Parameters.AddWithValue("@CIDADE", txtCidade.Text);
                                    upEnd.Parameters.AddWithValue("@UF", ddlUF.Text);
                                    upEnd.Parameters.AddWithValue("@IdEndereco", idEndereco);

                                    upEnd.ExecuteNonQuery();

                                    // Cria um comando para inserir um novo registro à tabela
                                    using (SqlCommand insClient = new SqlCommand("INSERT INTO tblCliente (NomeCliente, CPF, NumeroLocal, " +
                                        "Complemento, Email, Seguir, CodEndereco) OUTPUT INSERTED.IDCLIENTE VALUES (@NomeCliente, @CPF, @NumeroLocal, " +
                                        "@Complemento, @Email, @Seguir, @CodEndereco)", conn))
                                    {
                                        // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                                        insClient.Parameters.AddWithValue("@NomeCliente", txtNomeCompleto.Text);
                                        insClient.Parameters.AddWithValue("@CPF", txtCPF.Text);
                                        insClient.Parameters.AddWithValue("@NumeroLocal", txtNumeroLocal.Text);
                                        insClient.Parameters.AddWithValue("@Complemento", txtComplemento.Text);
                                        insClient.Parameters.AddWithValue("@Email", txtEmail.Text);
                                        if (ckbNotificacao.Checked == true)
                                        {
                                            insClient.Parameters.AddWithValue("@Seguir", 1);
                                        }
                                        else
                                        {
                                            insClient.Parameters.AddWithValue("@Seguir", 0);
                                        }
                                        insClient.Parameters.AddWithValue("@CodEndereco", idEndereco);

                                        // Agora a variável id conterá o valor do campo Id do registro criado
                                        int idClient = (int)insClient.ExecuteScalar();

                                        // Cria um comando para inserir um novo registro à tabela
                                        using (SqlCommand insLogin = new SqlCommand("INSERT INTO tblLogin (Usuario, Senha, Ativo, CodCliente) " +
                                            "VALUES (@Usuario, @Senha, @Ativo, @CodCliente)", conn))
                                        {
                                            // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                                            insLogin.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                                            insLogin.Parameters.AddWithValue("@Senha", txtSenha.Text);
                                            insLogin.Parameters.AddWithValue("@Ativo", 1);
                                            insLogin.Parameters.AddWithValue("@CodCliente", idClient);

                                            insLogin.ExecuteNonQuery();
                                        }

                                        if (txtTelefone.Text != string.Empty)
                                        {
                                            // Cria um comando para inserir um novo registro à tabela
                                            using (SqlCommand insTel = new SqlCommand("INSERT INTO tblTelefone (Telefone, CodCliente) " +
                                                "VALUES (@Telefone, @CodCliente)", conn))
                                            {
                                                // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                                                insTel.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                                                insTel.Parameters.AddWithValue("@CodCliente", idClient);

                                                insTel.ExecuteNonQuery();

                                                //Mostra a Mensagem na Tela de Criado com Sucesso
                                                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Usuário Cadastrado Com Sucesso')</script>");
                                                Response.Redirect("login.aspx", true);
                                                //Response.Write("<script>Alert('Usuário Cadastrado Com Sucesso')</script>");
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                // Cria um comando para inserir um novo registro à tabela
                                using (SqlCommand insEnd = new SqlCommand("INSERT INTO tblEndereco (Logradouro, CEP, Bairro, Cidade, UF) " +
                                    "OUTPUT INSERTED.IDENDERECO VALUES (@Logradouro, @CEP, @Bairro, @Cidade, @UF)", conn))
                                {
                                    // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                                    insEnd.Parameters.AddWithValue("@Logradouro", txtLogradouro.Text);
                                    insEnd.Parameters.AddWithValue("@CEP", txtCEP.Text);
                                    insEnd.Parameters.AddWithValue("@Bairro", txtBairro.Text);
                                    insEnd.Parameters.AddWithValue("@Cidade", txtCidade.Text);
                                    insEnd.Parameters.AddWithValue("@UF", ddlUF.Text);

                                    // Agora a variável id conterá o valor do campo Id do registro criado
                                    int idEnd = (int)insEnd.ExecuteScalar();

                                    // Cria um comando para inserir um novo registro à tabela
                                    using (SqlCommand insClient = new SqlCommand("INSERT INTO tblCliente (NomeCliente, CPF, NumeroLocal, " +
                                        "Complemento, Email, Seguir, CodEndereco) OUTPUT INSERTED.IDCLIENTE VALUES (@NomeCliente, @CPF, @NumeroLocal, " +
                                        "@Complemento, @Email, @Seguir, @CodEndereco)", conn))
                                    {
                                        // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                                        insClient.Parameters.AddWithValue("@NomeCliente", txtNomeCompleto.Text);
                                        insClient.Parameters.AddWithValue("@CPF", txtCPF.Text);
                                        insClient.Parameters.AddWithValue("@NumeroLocal", txtNumeroLocal.Text);
                                        insClient.Parameters.AddWithValue("@Complemento", txtComplemento.Text);
                                        insClient.Parameters.AddWithValue("@Email", txtEmail.Text);
                                        if (ckbNotificacao.Checked == true)
                                        {
                                            insClient.Parameters.AddWithValue("@Seguir", 1);
                                        }
                                        else
                                        {
                                            insClient.Parameters.AddWithValue("@Seguir", 0);
                                        }
                                        insClient.Parameters.AddWithValue("@CodEndereco", idEnd);

                                        // Agora a variável id conterá o valor do campo Id do registro criado
                                        int idClient = (int)insClient.ExecuteScalar();

                                        // Cria um comando para inserir um novo registro à tabela
                                        using (SqlCommand insLogin = new SqlCommand("INSERT INTO tblLogin (Usuario, Senha, Ativo, CodCliente) " +
                                            "VALUES (@Usuario, @Senha, @Ativo, @CodCliente)", conn))
                                        {
                                            // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                                            insLogin.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                                            insLogin.Parameters.AddWithValue("@Senha", txtSenha.Text);
                                            insLogin.Parameters.AddWithValue("@Ativo", 1);
                                            insLogin.Parameters.AddWithValue("@CodCliente", idClient);

                                            insLogin.ExecuteNonQuery();
                                        }

                                        if (txtTelefone.Text != string.Empty)
                                        {
                                            // Cria um comando para inserir um novo registro à tabela
                                            using (SqlCommand insTel = new SqlCommand("INSERT INTO tblTelefone (Telefone, CodCliente) " +
                                                "VALUES (@Telefone, @CodCliente)", conn))
                                            {
                                                // Esses valores poderiam vir de qualquer outro lugar, como uma TextBox...
                                                insTel.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                                                insTel.Parameters.AddWithValue("@CodCliente", idClient);

                                                insTel.ExecuteNonQuery();

                                                //Mostra a Mensagem na Tela de Criado com Sucesso
                                                Response.Redirect("login.aspx", true);
                                                ClientScript.RegisterStartupScript(Page.GetType(), "msg", "<script>alert('Usuário Cadastrado Com Sucesso')</script>");
                                                //Response.Write("<script>Alert('Usuário Cadastrado Com Sucesso')</script>");
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            #endregion
        }

        protected void txtCEP_TextChanged(object sender, EventArgs e)
        {
            #region Auto Preenchimento de Campos do Endereço
            using (SqlConnection conn = new SqlConnection("Server=tcp:zackariel.database.windows.net,1433;Initial Catalog=Duffoux;Persist Security Info=False;User ID=Duffoux;Password=Rick091295;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                using (SqlCommand autoEnd = new SqlCommand("SELECT IdEndereco, Logradouro, CEP, Bairro, Cidade, UF from tblendereco where cep=@cep", conn))
                {
                    autoEnd.Parameters.AddWithValue("@cep", txtCEP.Text);

                    using (SqlDataReader reader = autoEnd.ExecuteReader())
                    {
                        if (reader.Read() == true)
                        {
                            int idEndereco = reader.GetInt32(0);
                            txtLogradouro.Text = reader.GetString(1);
                            txtCEP.Text = reader.GetString(2);
                            txtBairro.Text = reader.GetString(3);
                            txtCidade.Text = reader.GetString(4);
                            ddlUF.Text = reader.GetString(5);

                            txtNumeroLocal.Focus();
                        }
                    }
                }
            }
            #endregion
        }
    }
}