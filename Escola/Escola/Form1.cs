using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (tbNome.Text.Equals(""))
            {
                MessageBox.Show("Informe o nome do aluno");
                return;
            }
            try
            {
                AlunosDB alunoBD = new AlunosDB();
                Alunos alunoReg = new Alunos(int.Parse(tbMatricula.Text), tbNome.Text, Double.Parse(tbN1.Text), Double.Parse(tbN2.Text), Double.Parse(tbMedia.Text), "Aprovado");

                alunoBD.IncluirAluno(alunoReg);
                MessageBox.Show("Registro salvo com sucesso.");
                btnLimpar.PerformClick();
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
            AlunosDB alunoBD = new AlunosDB();
            tbMatricula.Text = "";
            tbMedia.Text = "";
            tbN1.Text = "";
            tbN2.Text = "";
            tbNome.Text = "";

            tbMatricula.Focus();
            dataGridView1.DataSource = alunoBD.getAlunos();
        }
    }
}
