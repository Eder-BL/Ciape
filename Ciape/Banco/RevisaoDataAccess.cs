using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlServerCe;
using Ciape.Modelo;
using System.ComponentModel.DataAnnotations;
using Ciape.Banco;


namespace Ciape.Banco {
    public class RevisaoDataAccess {

        private static SqlCeConnection con = new SqlCeConnection(@"Data Source = C:\Users\Eder\source\repos\Solucao05\Ciape\Banco\Banco.sdf");

        public static DataTable PegarRevisoes() {

            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT Id, Descricao Descrição, Link, Corrigir, Status, DataCadastro Cadastro FROM Revisao WHERE Status='Pendente'", con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable PegarCorrecoes() {

            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT Id, Descricao Descrição, Link, Corrigir, Status, DataCadastro Cadastro FROM Revisao WHERE Status='Corrigir'", con);
            DataSet ds = new DataSet();

            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable PegarAprovados() {

            SqlCeDataAdapter da = new SqlCeDataAdapter("SELECT Id, Descricao Descrição, Link, Status, DataCadastro Cadastro, DataAtualizacao Atualização FROM Revisao WHERE Status='Aprovado'", con);
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

        public static bool CorrigirRevisao(int id, string correcao) {

            string sql = "Update Revisao set Status='Corrigir', Corrigir=@correcao where Id=@id";
            SqlCeCommand comando = new SqlCeCommand(sql, con);

            comando.Parameters.Add("@id", id);
            comando.Parameters.Add("@correcao", correcao);

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


        public static bool CorrigidoRev(int id) {

            string sql = "Update Revisao set Status='Pendente' where Id=@id";
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

        public static bool AprovadoRev(int id) {

            string sql = "Update Revisao set Status='Aprovado', DataAtualizacao=@DataAtualizacao where Id=@id";
            SqlCeCommand comando = new SqlCeCommand(sql, con);

            DateTime DataAtualizacao = DateTime.Now;
            string Status = "Aprovado";

            comando.Parameters.Add("@id", id);
            comando.Parameters.Add("@Status", Status);
            comando.Parameters.Add("@DataAtualizacao", DataAtualizacao);

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

        //===============================INÍCIO DashBoard===============================//

        public static DataTable RevCountTotal() {
            
            var da = new SqlCeDataAdapter("SELECT COUNT(ID) FROM Revisao", con);
            var ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable RevCountPendentes() {
            
            var da = new SqlCeDataAdapter("SELECT COUNT(ID) FROM Revisao where Status='Pendente'", con);
            var ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable RevCountCorrigir() {
            
            var da = new SqlCeDataAdapter("SELECT COUNT(ID) FROM Revisao where Status='Corrigir'", con);
            var ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable RevCountLinksCorrigidos() {
            //"SELECT COUNT(Id) FROM Revisao where Corrigir is not null"
            var da = new SqlCeDataAdapter("SELECT COUNT(Id) FROM Revisao where Corrigir is not null", con);
            var ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0];
        }

        public static DataTable RevCountLinksSemCorrecao() {
            //"SELECT COUNT(Id) FROM Revisao where Corrigir is null"
            var da = new SqlCeDataAdapter("SELECT COUNT(Id) FROM Revisao where Corrigir is null", con);
            var ds = new DataSet();
            da.Fill(ds);

            return ds.Tables[0];
        }


        //===============================FIM DashBoard===============================//

    }
}
