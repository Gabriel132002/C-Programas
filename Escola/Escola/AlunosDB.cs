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

namespace Escola
{
    class AlunosDB
    {
        string conexao;
        
        public AlunosDB()
        {
            this.conexao = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        }

        public void IncluirAluno(Alunos alunos)
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "INSERT INTO alunos (Matricula, Nome, N1, N2, Media, Status) Values(?Matricula, ?Nome, ?N1, ?N2, ?Media, ?Status)";
            Com.Parameters.AddWithValue("?Matricula", alunos.getMatricula);
            Com.Parameters.AddWithValue("?Nome", alunos.getNome);
            Com.Parameters.AddWithValue("?N1", alunos.getN1);
            Com.Parameters.AddWithValue("?N2", alunos.getN2);
            Com.Parameters.AddWithValue("?Media", alunos.getMedia);
            Com.Parameters.AddWithValue("?Status", alunos.getStatus);

            try
            {
                CN.Open();
                int registrosAfetados = Com.ExecuteNonQuery();
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

        public DataTable getAlunos()
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * FROM ALUNOS";

            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);
                DataTable dtAlunos = new DataTable();
                da.Fill(dtAlunos);
                return dtAlunos;
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
