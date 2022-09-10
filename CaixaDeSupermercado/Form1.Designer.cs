namespace CaixaDeSupermercado
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxProduto = new System.Windows.Forms.TextBox();
            this.boxSubTotal = new System.Windows.Forms.TextBox();
            this.boxPcUnit = new System.Windows.Forms.TextBox();
            this.boxQuantidade = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbProduto = new System.Windows.Forms.ListBox();
            this.lbQuantidade = new System.Windows.Forms.ListBox();
            this.lbPreco = new System.Windows.Forms.ListBox();
            this.lbSub = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(585, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sub Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Unitário";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantidade:";
            // 
            // boxProduto
            // 
            this.boxProduto.Location = new System.Drawing.Point(40, 71);
            this.boxProduto.Name = "boxProduto";
            this.boxProduto.Size = new System.Drawing.Size(100, 23);
            this.boxProduto.TabIndex = 4;
            // 
            // boxSubTotal
            // 
            this.boxSubTotal.Enabled = false;
            this.boxSubTotal.Location = new System.Drawing.Point(585, 71);
            this.boxSubTotal.Name = "boxSubTotal";
            this.boxSubTotal.Size = new System.Drawing.Size(100, 23);
            this.boxSubTotal.TabIndex = 5;
            this.boxSubTotal.TextChanged += new System.EventHandler(this.boxSubTotal_TextChanged);
            // 
            // boxPcUnit
            // 
            this.boxPcUnit.Location = new System.Drawing.Point(381, 71);
            this.boxPcUnit.Name = "boxPcUnit";
            this.boxPcUnit.Size = new System.Drawing.Size(100, 23);
            this.boxPcUnit.TabIndex = 6;
            this.boxPcUnit.TextChanged += new System.EventHandler(this.boxPcUnit_TextChanged);
            // 
            // boxQuantidade
            // 
            this.boxQuantidade.Location = new System.Drawing.Point(198, 71);
            this.boxQuantidade.Name = "boxQuantidade";
            this.boxQuantidade.Size = new System.Drawing.Size(100, 23);
            this.boxQuantidade.TabIndex = 7;
            this.boxQuantidade.TextChanged += new System.EventHandler(this.boxQuantidade_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 137);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(198, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adicionar produtos na lista";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(491, 137);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar venda";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbProduto
            // 
            this.lbProduto.FormattingEnabled = true;
            this.lbProduto.ItemHeight = 15;
            this.lbProduto.Location = new System.Drawing.Point(40, 242);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(120, 169);
            this.lbProduto.TabIndex = 10;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.FormattingEnabled = true;
            this.lbQuantidade.ItemHeight = 15;
            this.lbQuantidade.Location = new System.Drawing.Point(198, 242);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(120, 169);
            this.lbQuantidade.TabIndex = 11;
            // 
            // lbPreco
            // 
            this.lbPreco.FormattingEnabled = true;
            this.lbPreco.ItemHeight = 15;
            this.lbPreco.Location = new System.Drawing.Point(381, 242);
            this.lbPreco.Name = "lbPreco";
            this.lbPreco.Size = new System.Drawing.Size(120, 169);
            this.lbPreco.TabIndex = 12;
            // 
            // lbSub
            // 
            this.lbSub.FormattingEnabled = true;
            this.lbSub.ItemHeight = 15;
            this.lbSub.Location = new System.Drawing.Point(565, 242);
            this.lbSub.Name = "lbSub";
            this.lbSub.Size = new System.Drawing.Size(120, 169);
            this.lbSub.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSub);
            this.Controls.Add(this.lbPreco);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.boxQuantidade);
            this.Controls.Add(this.boxPcUnit);
            this.Controls.Add(this.boxSubTotal);
            this.Controls.Add(this.boxProduto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CaixaDeSupermercado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox boxProduto;
        private TextBox boxSubTotal;
        private TextBox boxPcUnit;
        private TextBox boxQuantidade;
        private Button btnAdd;
        private Button btnCancelar;
        private ListBox lbProduto;
        private ListBox lbQuantidade;
        private ListBox lbPreco;
        private ListBox lbSub;
    }
}