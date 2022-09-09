using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaDeSupermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string produto = box1Produto.Text;
        }

        private void listQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int qtd = Convert.ToInt32(Console.ReadLine());
        }

        private void listPcUnit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listSubTot_SelectedIndexChanged(object sender, EventArgs e)
        {
            listSubTot.Items.Add(box1Produto);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
