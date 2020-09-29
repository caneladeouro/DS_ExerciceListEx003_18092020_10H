namespace DS_ExerciceListEx003_18092020_10H
{
    partial class fmrSupermarketCashier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbInvoiceYes = new System.Windows.Forms.RadioButton();
            this.gpbProducts = new System.Windows.Forms.GroupBox();
            this.rbnInvoiceNot = new System.Windows.Forms.RadioButton();
            this.lblBarCode = new System.Windows.Forms.Label();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.gpbAddProduct = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.Carrinho = new System.Windows.Forms.ListBox();
            this.lblTotalSub = new System.Windows.Forms.Label();
            this.txtTotalSub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.nudProductAmount = new System.Windows.Forms.NumericUpDown();
            this.mtbBarCode = new System.Windows.Forms.MaskedTextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.mtbCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nudItemsAmountRemove = new System.Windows.Forms.NumericUpDown();
            this.gpbProducts.SuspendLayout();
            this.gpbAddProduct.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemsAmountRemove)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbInvoiceYes
            // 
            this.rdbInvoiceYes.AutoSize = true;
            this.rdbInvoiceYes.Location = new System.Drawing.Point(7, 32);
            this.rdbInvoiceYes.Name = "rdbInvoiceYes";
            this.rdbInvoiceYes.Size = new System.Drawing.Size(42, 17);
            this.rdbInvoiceYes.TabIndex = 0;
            this.rdbInvoiceYes.TabStop = true;
            this.rdbInvoiceYes.Text = "Sim";
            this.rdbInvoiceYes.UseVisualStyleBackColor = true;
            this.rdbInvoiceYes.CheckedChanged += new System.EventHandler(this.rdbInvoiceYes_CheckedChanged);
            // 
            // gpbProducts
            // 
            this.gpbProducts.Controls.Add(this.nudItemsAmountRemove);
            this.gpbProducts.Controls.Add(this.mtbCpf);
            this.gpbProducts.Controls.Add(this.lblInvoice);
            this.gpbProducts.Controls.Add(this.btnRemove);
            this.gpbProducts.Controls.Add(this.textBox5);
            this.gpbProducts.Controls.Add(this.label6);
            this.gpbProducts.Controls.Add(this.txtTotalSub);
            this.gpbProducts.Controls.Add(this.lblTotalSub);
            this.gpbProducts.Controls.Add(this.Carrinho);
            this.gpbProducts.Controls.Add(this.gpbAddProduct);
            this.gpbProducts.Controls.Add(this.rbnInvoiceNot);
            this.gpbProducts.Controls.Add(this.rdbInvoiceYes);
            this.gpbProducts.Location = new System.Drawing.Point(12, 27);
            this.gpbProducts.Name = "gpbProducts";
            this.gpbProducts.Size = new System.Drawing.Size(344, 289);
            this.gpbProducts.TabIndex = 1;
            this.gpbProducts.TabStop = false;
            this.gpbProducts.Text = "Produtos";
            // 
            // rbnInvoiceNot
            // 
            this.rbnInvoiceNot.AutoSize = true;
            this.rbnInvoiceNot.Location = new System.Drawing.Point(55, 32);
            this.rbnInvoiceNot.Name = "rbnInvoiceNot";
            this.rbnInvoiceNot.Size = new System.Drawing.Size(45, 17);
            this.rbnInvoiceNot.TabIndex = 1;
            this.rbnInvoiceNot.TabStop = true;
            this.rbnInvoiceNot.Text = "Não";
            this.rbnInvoiceNot.UseVisualStyleBackColor = true;
            this.rbnInvoiceNot.CheckedChanged += new System.EventHandler(this.rbnInvoiceNot_CheckedChanged);
            // 
            // lblBarCode
            // 
            this.lblBarCode.AutoSize = true;
            this.lblBarCode.Location = new System.Drawing.Point(9, 26);
            this.lblBarCode.Name = "lblBarCode";
            this.lblBarCode.Size = new System.Drawing.Size(87, 13);
            this.lblBarCode.TabIndex = 5;
            this.lblBarCode.Text = "Código de barras";
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.Location = new System.Drawing.Point(9, 73);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(121, 13);
            this.lblProductAmount.TabIndex = 7;
            this.lblProductAmount.Text = "Quantidade de produtos";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(9, 122);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(72, 13);
            this.lblUnitPrice.TabIndex = 9;
            this.lblUnitPrice.Text = "Preço unitário";
            // 
            // gpbAddProduct
            // 
            this.gpbAddProduct.Controls.Add(this.txtDescription);
            this.gpbAddProduct.Controls.Add(this.lblDescription);
            this.gpbAddProduct.Controls.Add(this.lblInformation);
            this.gpbAddProduct.Controls.Add(this.txtUnitPrice);
            this.gpbAddProduct.Controls.Add(this.mtbBarCode);
            this.gpbAddProduct.Controls.Add(this.nudProductAmount);
            this.gpbAddProduct.Controls.Add(this.btnAddProduct);
            this.gpbAddProduct.Controls.Add(this.lblUnitPrice);
            this.gpbAddProduct.Controls.Add(this.lblProductAmount);
            this.gpbAddProduct.Controls.Add(this.lblBarCode);
            this.gpbAddProduct.Location = new System.Drawing.Point(7, 55);
            this.gpbAddProduct.Name = "gpbAddProduct";
            this.gpbAddProduct.Size = new System.Drawing.Size(200, 228);
            this.gpbAddProduct.TabIndex = 10;
            this.gpbAddProduct.TabStop = false;
            this.gpbAddProduct.Text = "Adicionar Produto";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(12, 199);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(178, 23);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Adicionar produto ao carrinho";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // Carrinho
            // 
            this.Carrinho.Enabled = false;
            this.Carrinho.FormattingEnabled = true;
            this.Carrinho.Location = new System.Drawing.Point(219, 55);
            this.Carrinho.Name = "Carrinho";
            this.Carrinho.Size = new System.Drawing.Size(120, 82);
            this.Carrinho.TabIndex = 11;
            // 
            // lblTotalSub
            // 
            this.lblTotalSub.AutoSize = true;
            this.lblTotalSub.Location = new System.Drawing.Point(216, 140);
            this.lblTotalSub.Name = "lblTotalSub";
            this.lblTotalSub.Size = new System.Drawing.Size(49, 13);
            this.lblTotalSub.TabIndex = 11;
            this.lblTotalSub.Text = "Sub-total";
            // 
            // txtTotalSub
            // 
            this.txtTotalSub.Location = new System.Drawing.Point(219, 159);
            this.txtTotalSub.Name = "txtTotalSub";
            this.txtTotalSub.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSub.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor parcial";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(219, 199);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 13;
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(263, 29);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(236, 322);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(120, 23);
            this.btnCheckOut.TabIndex = 14;
            this.btnCheckOut.Text = "&Finalizar compra";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(368, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsAbout,
            this.mnsExit});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "&Arquivo";
            // 
            // mnsAbout
            // 
            this.mnsAbout.Name = "mnsAbout";
            this.mnsAbout.Size = new System.Drawing.Size(152, 22);
            this.mnsAbout.Text = "&Sobre";
            // 
            // mnsExit
            // 
            this.mnsExit.Name = "mnsExit";
            this.mnsExit.Size = new System.Drawing.Size(152, 22);
            this.mnsExit.Text = "&Sair";
            this.mnsExit.Click += new System.EventHandler(this.mnsExit_Click);
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Location = new System.Drawing.Point(6, 16);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(63, 13);
            this.lblInvoice.TabIndex = 14;
            this.lblInvoice.Text = "Nota fiscal?";
            // 
            // nudProductAmount
            // 
            this.nudProductAmount.Location = new System.Drawing.Point(12, 89);
            this.nudProductAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudProductAmount.Name = "nudProductAmount";
            this.nudProductAmount.Size = new System.Drawing.Size(120, 20);
            this.nudProductAmount.TabIndex = 11;
            this.nudProductAmount.ThousandsSeparator = true;
            this.nudProductAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // mtbBarCode
            // 
            this.mtbBarCode.Location = new System.Drawing.Point(12, 42);
            this.mtbBarCode.Mask = "0000000000000";
            this.mtbBarCode.Name = "mtbBarCode";
            this.mtbBarCode.Size = new System.Drawing.Size(100, 20);
            this.mtbBarCode.TabIndex = 13;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(12, 138);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtUnitPrice.TabIndex = 15;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(118, 141);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(59, 13);
            this.lblInformation.TabIndex = 16;
            this.lblInformation.Text = "Informarion";
            this.lblInformation.Visible = false;
            // 
            // mtbCpf
            // 
            this.mtbCpf.Location = new System.Drawing.Point(101, 29);
            this.mtbCpf.Mask = "000.000.000.00";
            this.mtbCpf.Name = "mtbCpf";
            this.mtbCpf.Size = new System.Drawing.Size(100, 20);
            this.mtbCpf.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 161);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(55, 13);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Descrição";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 177);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 18;
            // 
            // nudItemsAmountRemove
            // 
            this.nudItemsAmountRemove.Enabled = false;
            this.nudItemsAmountRemove.Location = new System.Drawing.Point(218, 32);
            this.nudItemsAmountRemove.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudItemsAmountRemove.Name = "nudItemsAmountRemove";
            this.nudItemsAmountRemove.Size = new System.Drawing.Size(39, 20);
            this.nudItemsAmountRemove.TabIndex = 19;
            this.nudItemsAmountRemove.ThousandsSeparator = true;
            this.nudItemsAmountRemove.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // fmrSupermarketCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 357);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.gpbProducts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrSupermarketCashier";
            this.Text = "Supermarket Cashier";
            this.gpbProducts.ResumeLayout(false);
            this.gpbProducts.PerformLayout();
            this.gpbAddProduct.ResumeLayout(false);
            this.gpbAddProduct.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudItemsAmountRemove)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbInvoiceYes;
        private System.Windows.Forms.GroupBox gpbProducts;
        private System.Windows.Forms.RadioButton rbnInvoiceNot;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalSub;
        private System.Windows.Forms.Label lblTotalSub;
        private System.Windows.Forms.ListBox Carrinho;
        private System.Windows.Forms.GroupBox gpbAddProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblProductAmount;
        private System.Windows.Forms.Label lblBarCode;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnsAbout;
        private System.Windows.Forms.ToolStripMenuItem mnsExit;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.NumericUpDown nudProductAmount;
        private System.Windows.Forms.MaskedTextBox mtbBarCode;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.MaskedTextBox mtbCpf;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.NumericUpDown nudItemsAmountRemove;
    }
}

