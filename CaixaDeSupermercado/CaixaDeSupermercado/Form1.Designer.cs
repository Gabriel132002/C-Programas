
namespace CaixaDeSupermercado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.box1Produto = new System.Windows.Forms.TextBox();
            this.box2Quantidade = new System.Windows.Forms.TextBox();
            this.box3PcUnit = new System.Windows.Forms.TextBox();
            this.box4Subtot = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listProduto = new System.Windows.Forms.ListBox();
            this.listQuantidade = new System.Windows.Forms.ListBox();
            this.listPcUnit = new System.Windows.Forms.ListBox();
            this.listSubTot = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(416, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Preço Unitário:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sub Total:";
            // 
            // box1Produto
            // 
            this.box1Produto.Location = new System.Drawing.Point(36, 47);
            this.box1Produto.Name = "box1Produto";
            this.box1Produto.Size = new System.Drawing.Size(100, 20);
            this.box1Produto.TabIndex = 4;
            
            // 
            // box2Quantidade
            // 
            this.box2Quantidade.Location = new System.Drawing.Point(221, 47);
            this.box2Quantidade.Name = "box2Quantidade";
            this.box2Quantidade.Size = new System.Drawing.Size(100, 20);
            this.box2Quantidade.TabIndex = 5;
            
            // 
            // box3PcUnit
            // 
            this.box3PcUnit.Location = new System.Drawing.Point(419, 47);
            this.box3PcUnit.Name = "box3PcUnit";
            this.box3PcUnit.Size = new System.Drawing.Size(100, 20);
            this.box3PcUnit.TabIndex = 6;
            // 
            // box4Subtot
            // 
            this.box4Subtot.Enabled = false;
            this.box4Subtot.Location = new System.Drawing.Point(633, 47);
            this.box4Subtot.Name = "box4Subtot";
            this.box4Subtot.Size = new System.Drawing.Size(100, 20);
            this.box4Subtot.TabIndex = 7;
            this.box4Subtot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(98, 132);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(135, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Adicionar produto na lista\r\n";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(562, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancelar Venda";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Produtos:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(419, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Preço Unitário:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(633, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Sub Total:";
            // 
            // listProduto
            // 
            this.listProduto.FormattingEnabled = true;
            this.listProduto.Location = new System.Drawing.Point(36, 250);
            this.listProduto.Name = "listProduto";
            this.listProduto.Size = new System.Drawing.Size(100, 160);
            this.listProduto.TabIndex = 15;
            this.listProduto.SelectedIndexChanged += new System.EventHandler(this.listProduto_SelectedIndexChanged);
            // 
            // listQuantidade
            // 
            this.listQuantidade.FormattingEnabled = true;
            this.listQuantidade.Location = new System.Drawing.Point(221, 250);
            this.listQuantidade.Name = "listQuantidade";
            this.listQuantidade.Size = new System.Drawing.Size(100, 160);
            this.listQuantidade.TabIndex = 16;
            this.listQuantidade.SelectedIndexChanged += new System.EventHandler(this.listQuantidade_SelectedIndexChanged);
            // 
            // listPcUnit
            // 
            this.listPcUnit.FormattingEnabled = true;
            this.listPcUnit.Location = new System.Drawing.Point(419, 250);
            this.listPcUnit.Name = "listPcUnit";
            this.listPcUnit.Size = new System.Drawing.Size(100, 160);
            this.listPcUnit.TabIndex = 17;
            this.listPcUnit.SelectedIndexChanged += new System.EventHandler(this.listPcUnit_SelectedIndexChanged);
            // 
            // listSubTot
            // 
            this.listSubTot.FormattingEnabled = true;
            this.listSubTot.Location = new System.Drawing.Point(633, 250);
            this.listSubTot.Name = "listSubTot";
            this.listSubTot.Size = new System.Drawing.Size(100, 160);
            this.listSubTot.TabIndex = 18;
            this.listSubTot.SelectedIndexChanged += new System.EventHandler(this.listSubTot_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(36, 454);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(697, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Remover produtos da lista de compra";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(98, 506);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "Fechar venda";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total a pagar:";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(613, 506);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(120, 17);
            this.listBox5.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listSubTot);
            this.Controls.Add(this.listPcUnit);
            this.Controls.Add(this.listQuantidade);
            this.Controls.Add(this.listProduto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.box4Subtot);
            this.Controls.Add(this.box3PcUnit);
            this.Controls.Add(this.box2Quantidade);
            this.Controls.Add(this.box1Produto);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box1Produto;
        private System.Windows.Forms.TextBox box2Quantidade;
        private System.Windows.Forms.TextBox box3PcUnit;
        private System.Windows.Forms.TextBox box4Subtot;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listProduto;
        private System.Windows.Forms.ListBox listQuantidade;
        private System.Windows.Forms.ListBox listPcUnit;
        private System.Windows.Forms.ListBox listSubTot;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox5;
    }
}

