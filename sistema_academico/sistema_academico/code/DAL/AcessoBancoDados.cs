using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
// Manipular banco de dados
using System.Data;
//SQLSERVER
using System.Data.SqlClient;


namespace DAL // DATA ACESS LAYER
{
    public class AcessoBancoDados
    {
        // Conjunto de atributos da Classe

        //atributo para guardar conexao do banco.
        private SqlConnection conn;
        //atributo para comandos SQL.
        private SqlCommand comando;
        //guardar tabelas
        private DataTable data;
        //auxilia na conversao de dados no formato adaptado
        private SqlDataAdapter da;

        //Metodo para estabelecer uma conexao
        public void Conectar()
        {
            //verifica se existe uma conexao aberta, caso sim, ele fecha.
            if (conn != null)
            {
                conn.Close();
            }
            //criar uma variavel que recebe caminho conexao;
            string connStr = "Data Source=LAB41-09;Initial Catalog=sistema_academico;User ID=sa;Password=venus";
            try
            {
                // concretiza a criação do objeto conn.
                conn = new SqlConnection(connStr);
                conn.Open();
            }
            catch(SqlException ex)//se chegar é por que deu algum erro na conexao
            {
                throw new Exception(ex.Message);
            }
        }

        //Metodo para executar comandos SQL no Banco de dados.
        //INSERT, UPDATE, e DELETE
        public void ExecutarComandoSQL(string comandoSql)
        {
            //concretiza a criação do objeto command Parametro(comandoSQL, conecxao)
            comando = new SqlCommand(comandoSql,conn);
            comando.ExecuteNonQuery();//execução da query
            conn.Close();
        }

        //Metodo responsavel pelo retorno do objeto DATATABLE
        public DataTable RetDataTable(string sql)
        {
            //concretiza a criação do objeto Datatable
            data = new DataTable();
            //concretiza a criação do objeto Adapter
            da = new SqlDataAdapter(sql,conn);
            da.Fill(data);//preenche o objeto data com os dados que estao no da
            return data;//retorno o data já preenchido
        }

        //Metodo responsavel pelo retorno do objeto DataReader
        public SqlDataReader RetDataReader(string sql)
        {
            comando = new SqlCommand(sql, conn);
            SqlDataReader dr = comando.ExecuteReader();
            dr.Read(); // O objeto precisa ser lido para liberar seu uso.
            return dr;
        }
    }
}