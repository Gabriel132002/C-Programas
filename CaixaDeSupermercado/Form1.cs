namespace CaixaDeSupermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(boxProduto.Text==" " || boxQuantidade.Text=="" || boxPcUnit.Text=="")
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }
            lbProduto.Items.Add(boxProduto.Text);           
            lbQuantidade.Items.Add(boxQuantidade.Text);
            lbPreco.Items.Add(boxPcUnit.Text);
            lbSub.Items.Add(boxSubTotal.Text);
        }

        private void boxSubTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void boxQuantidade_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void boxPcUnit_TextChanged(object sender, EventArgs e)
        {
            if (boxPcUnit.Text == "")
            {
                boxPcUnit.Text = "";
                boxProduto.Text = "";
                boxQuantidade.Text = "";
                boxSubTotal.Text = "";
            }else
                 boxSubTotal.Text = "" + Convert.ToDouble(boxQuantidade.Text) * Convert.ToDouble(boxPcUnit.Text);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            boxSubTotal.Clear();
            boxProduto.Clear();
            boxPcUnit.Clear();
            boxQuantidade.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* lbProduto.Items.Remove(boxProduto.Text);
            lbQuantidade.Items.Remove(Convert.ToInt32(boxQuantidade.Text));
            lbPreco.Items.Remove(Convert.ToDouble(boxPcUnit.Text));
            lbSub.Items.Remove(boxSubTotal.Text);



           decimal sum = 0;
            for (int i = 0; i < lbPreco.Items.Count; i++)
            {
                sum += Convert.ToDecimal(lbPreco.Items[i]);
            }
            textBox1.Text = "R$: " + sum;
           */
            if(lbPreco.SelectedIndex != -1)
            {
                if(lbPreco.SelectedIndex > -1)
                {
                    lbPreco.Items.RemoveAt(lbPreco.SelectedIndex);                  
                }
            }
            if(lbProduto.SelectedIndex != -1)
            {
                if (lbProduto.SelectedIndex > -1)
                {
                    lbProduto.Items.RemoveAt(lbProduto.SelectedIndex);                   
                }
            }
            if (lbQuantidade.SelectedIndex != -1)
            {
                if (lbQuantidade.SelectedIndex > -1)
                {
                    lbQuantidade.Items.RemoveAt(lbQuantidade.SelectedIndex);
                }
            }
            if(lbSub.SelectedIndex != -1)
            {
                if(lbSub.SelectedIndex > -1)
                {
                    lbSub.Items.RemoveAt(lbSub.SelectedIndex);
                }
            }
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void boxTotal_TextChanged(object sender, EventArgs e)
        {
            if (lbPreco.Text == "")
            {
                lbPreco.Text = "";
                lbProduto.Text = "";
                lbQuantidade.Text = "";
                lbSub.Text = "";
            }
            else
            {
                for (int i = 0; i < lbSub.Items.Count; i++)
                {
                    var soma = 0;
                    soma = soma + Convert.ToInt32(lbSub.Items[i]);
                }

            }
        }
    }
}