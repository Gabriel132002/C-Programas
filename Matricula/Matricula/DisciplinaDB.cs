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
    class DisciplinaDB
    {
        string conexao;

        public DisciplinaDB()
        {
            this.conexao = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        }

        public void incluirDisciplina(Disciplina disciplina)
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand Com = CN.CreateCommand();
            Com.CommandText = "INSERT INTO dadosaluno (Disciplina) Values(?disciplina)";
            Com.Parameters.AddWithValue("?disciplina", disciplina.getDisciplina);

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

        public DataTable getDadosDisciplina()
        {
            MySqlConnection CN = new MySqlConnection(conexao);
            MySqlCommand cmd = CN.CreateCommand();
            MySqlDataAdapter da;
            cmd.CommandText = "SELECT * FROM dadosalunoa";

            try
            {
                CN.Open();
                cmd = new MySqlCommand(cmd.CommandText, CN);
                da = new MySqlDataAdapter(cmd);
                DataTable dtDadosDisciplina = new DataTable();
                da.Fill(dtDadosDisciplina);
                return dtDadosDisciplina;
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
