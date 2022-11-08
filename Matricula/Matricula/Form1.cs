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
            try
            {
                AlunoDB alunoDB = new AlunoDB();
                Alunos alunoReg = new Alunos(
                    int.Parse(tbTelefone.Text),
                    tbNome.Text,
                    tbCurso.Text,
                    tbDisciplina.Text,
                    tbEmail.Text
                    );
                alunoDB.incluirAluno(alunoReg);
                MessageBox.Show("Salvo com sucesso");
                btnLimpar.PerformClick();
            }
            catch(Exception C)
            {
                MessageBox.Show(C.ToString());
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            AlunoDB alunosDB = new AlunoDB();
            tbNome.Text = "";
            tbTelefone.Text = "";
            tbDisciplina.Text = "";
            tbCurso.Text = "";
            tbEmail.Text = "";

            tbNome.Focus();
        }
    }
}
