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
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            #region Verificação dos Campos
            //Verificando se o usuário digitou algo no campo
            if (txtUsuario.Text == string.Empty)
            {
                //Coloca o cursor no campo para digitar
                txtUsuario.Focus();

                //Mostra mensagem para o usuário
                Response.Write("<script>alert('Digite seu usuário')</script>");
                return;
            }
            else
            {
                //Trata a informação digita para não travar o banco de dados
                txtUsuario.Text.Replace("'", "´");
            }

            //Verificando se o usuário digitou algo no campo
            if (txtSenha.Text == string.Empty)
            {
                //Coloca o cursor no campo para digitar
                txtSenha.Focus();

                //Mostra mensagem para o usuário
                Response.Write("<script>alert('Digite sua senha')</script>");
                return;
            }
            else
            {
                //Trata a informação digita para não travar o banco de dados
                txtSenha.Text.Replace("'", "´");
            }
            #endregion

            #region Logando o usuário
            // Cria e abre a conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection("Server=tcp:zackariel.database.windows.net,1433;Initial Catalog=Duffoux;Persist Security Info=False;User ID=Duffoux;Password=Rick091295;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                // Cria um comando para selecionar registros da tabela, 
                // trazendo se o usuário existe.
                using (SqlCommand cmd = new SqlCommand("SELECT IdLogin, Usuario, Senha, Ativo FROM tblLogin " +
                    "WHERE Usuario = @Usuario and Senha = @Senha and Ativo = 1", conn))
                {
                    // Esse valor poderia vir de qualquer outro lugar, como uma TextBox...
                    cmd.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

                    //Executando a query(consulta) no banco de dados
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        //Verifica se a query(consulta) retornou algo
                        if (reader.Read() == false)
                        {
                            //**********************************************************************
                            //Zera os campos e mostra mensagem de erro ao usuário
                            txtUsuario.Text = string.Empty;
                            txtUsuario.Focus();
                            txtSenha.Text = string.Empty;
                            Response.Write("<script>alert('Usuário ou senha incorretos')</script>");
                            //**********************************************************************
                        }
                        else
                        {
                            //Login efetuado com sucesso
                            Response.Redirect("perfil.html");
                            //Server.Transfer("perfil.html", true);
                            //Response.Write("<script>alert('Logado com Sucesso')</script>");
                        }
                    }
                }
            }
            #endregion
        }
    }
}