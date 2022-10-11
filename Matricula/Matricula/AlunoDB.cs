using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Matricula
{
    class AlunoDB
    {
        string conexao;

        public AlunoDB()
        {
            this.conexao = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        }

        public void incluirAluno(Alunos alunos)
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "INSERT INTO dadosaluno (Matricula, Nome, Telefone) Values (?matricula, ?nome, ?telefone)";
            Com.Parameters.AddWithValue("?matricula", alunos.getMatricula);
            Com.Parameters.AddWithValue("?nome", alunos.getNome);
            Com.Parameters.AddWithValue("?telefone", alunos.getTelefone);
            

            try
            {
                CN.Open();
                int registrosAdicionados = Com.ExecuteNonQuery();
            }
            catch(MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }

        public DataTable getDadosAlunos()
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * FROM dadosalunos";

            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);
                DataTable dtDadosAlunos = new DataTable();
                da.Fill(dtDadosAlunos);
                return dtDadosAlunos;
            }
            catch(MySqlException ex)
            {
                throw new ApplicationException(ex.ToString());
            }
            finally
            {
                CN.Close();
            }
        }
    }
}
