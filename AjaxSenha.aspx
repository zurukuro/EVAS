<%@ Page Language="C#" %>

<%
    string logradouro, bairro, cep, cidade, uf;
    logradouro = bairro = cep = cidade = uf = "";

    using (var conn = new System.Data.SqlClient.SqlConnection("Server=tcp:zackariel.database.windows.net,1433;Initial Catalog=Duffoux;Persist Security Info=False;User ID=Duffoux;Password=Rick091295;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
    {
        //Abrir conexão com o banco
        conn.Open();

        //Seleciona os registro que deseja fazer autopreenchimento
        using (var autoEnd = new System.Data.SqlClient.SqlCommand("SELECT IdEndereco, Logradouro, CEP, Bairro, Cidade, UF from tblendereco where cep=@cep", conn))
        {
            //Condição para que retorne somente um registro
            autoEnd.Parameters.AddWithValue("@cep", Request.QueryString["cep"]);

            //Executa a query acima para trazer a lista (1 registro)
            using (var reader = autoEnd.ExecuteReader())
            {
                if (reader.Read() == true)
                {
                    //Atribui o resultado da query nos campos
                    int idEndereco = reader.GetInt32(0);
                    logradouro = reader.GetString(1);
                    cep = reader.GetString(2);
                    bairro = reader.GetString(3);
                    cidade = reader.GetString(4);
                    uf = reader.GetString(5);
                }
            }
        }
    }
%>

{
    "logradouro": "<%= logradouro %>",
    "cep": "<%= cep %>",
    "bairro": "<%= bairro %>",
    "cidade": "<%= cidade %>",
    "uf": "<%= uf %>"
}