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
            Com.CommandText = "INSERT INTO dadosalunos (Nome, Telefone, Disciplina, Curso, Email) Values (?nome, ?telefone, ?disciplina, ?curso, ?email)";
            Com.Parameters.AddWithValue("?nome", alunos.getNome);
            Com.Parameters.AddWithValue("?telefone", alunos.getTelefone);
            Com.Parameters.AddWithValue("?disciplina", alunos.getDisciplina);
            Com.Parameters.AddWithValue("?curso", alunos.getCurso);
            Com.Parameters.AddWithValue("?email", alunos.getEmail);
            

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
