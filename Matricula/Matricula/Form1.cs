using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbMatricula.Equals(""))
            {
                MessageBox.Show("Insira sua matrícula");
                return;
            }
            try
            {
                AlunoDB alunoDB = new AlunoDB();
                Alunos alunoReg = new Alunos(
                    int.Parse(tbMatricula.Text),
                    int.Parse(tbTelefone.Text),
                    tbNome.Text);
                alunoDB.incluirAluno(alunoReg);
                MessageBox.Show("Salvo com sucesso");

            }
            catch(Exception c)
            {
                MessageBox.Show(c.ToString());
            }

            if (tbDisciplina.Equals(""))
            {
                MessageBox.Show("Insira sua disciplina desejada");
                return;
            }
            try
            {
                DisciplinaDB disDB = new DisciplinaDB();
                Disciplina disReg = new Disciplina(
                    tbDisciplina.Text
                    );
                disDB.incluirDisciplina(disReg);
                MessageBox.Show("salvo");
            }
            catch(Exception c)
            {
                MessageBox.Show(c.ToString());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            AlunoDB alunosDB = new AlunoDB();
            tbMatricula.Text = "";
            tbNome.Text = "";
            tbTelefone.Text = "";
            tbDisciplina.Text = "";
            
        }

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
