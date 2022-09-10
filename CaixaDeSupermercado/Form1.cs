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
            double total;
            
        }

        private void boxQuantidade_TextChanged(object sender, EventArgs e)
        {
            double qtd;
            qtd = Convert.ToDouble(boxQuantidade.Text);
        }

        private void boxPcUnit_TextChanged(object sender, EventArgs e)
        {
            double unit;
            unit = Convert.ToDouble(boxPcUnit.Text);

        }
    }
}