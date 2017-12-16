using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;
using Ciape.Modelo;


namespace Ciape.Banco {
    public class RevisaoDataAccess {

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source = C:\Users\Eder\source\repos\Solucao05\Ciape\Banco\Banco.sdf");

        public static DataTable PegarRevisoes() {

            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT Id, Descricao Descrição, Link, Status, DataCadastro Cadastro FROM Revisao WHERE Status='Pendente'", con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }


        public static bool ExcluirRevisao(int id) {
            string sql = "Delete from Revisao where Id=@id";
            SqlCeCommand comando = new SqlCeCommand(sql, con);

            comando.Parameters.Add("@id", id);

            con.Open();
            if (comando.ExecuteNonQuery() > 0) {

                con.Close();
                return true;
            }
            else {
                con.Close();
                return false;
            }
        }

        public static bool SalvarLink(Revisoes revisao) {

            string sql = "Insert into Revisao(Descricao,Link,Status,DataCadastro) VALUES (@Descricao,@Link,@Status,@DataCadastro)";
            SqlCeCommand comando = new SqlCeCommand(sql, con);
            comando.Parameters.Add("@Descricao", revisao.Descricao);
            comando.Parameters.Add("@Link", revisao.Link);
            comando.Parameters.Add("@Status", revisao.Status);
            comando.Parameters.Add("@DataCadastro", revisao.DataCadastro);

            con.Open();
            if (comando.ExecuteNonQuery() > 0) {
                con.Close();
                return true;
            }
           else {
                con.Close();
                return false;
            }

        }

    }
}
