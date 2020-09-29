using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DS_ExerciceListEx003_18092020_10H
{
    public partial class fmrSupermarketCashier : Form
    {
        public long barcode;
        public decimal amountProduct;
        public string productDescription;
        public double unitPrice;

        public fmrSupermarketCashier()
        {
            InitializeComponent();
        }

        public void insetProduct(long Barcode ,decimal AmountProduct, string ProductDescritiont, double UnitPrice)
        {
            this.barcode = Barcode;
            this.amountProduct = AmountProduct;
            this.productDescription = ProductDescritiont;
            this.unitPrice = UnitPrice;
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            //insetProduct(
            //    Convert.ToInt64(mtbBarCode.Text),
            //    nudProductAmount.Value,
            //    txtDescription.Text,
            //    double.Parse(txtUnitPrice.Text)
            //    );

            List<Product> product = new List<Product>();

            product.Add(new Product(
                Convert.ToInt64(mtbBarCode.Text),
                nudProductAmount.Value,
                txtDescription.Text,
                double.Parse(txtUnitPrice.Text)
                ));

            foreach (Product element in product)
                Carrinho.Items.Add(element);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void mnsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rbnInvoiceNot_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpf.Visible = false;
        }

        private void rdbInvoiceYes_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpf.Visible = true;
        }
    }

    public class Product : List<Product>
    {
        long barcode;
        decimal amountproduct;
        string productdescription;
        double unitprice;

        public Product(long barcode, decimal amountproduct, string productdescritiont, double unitprice)
        {
            this.barcode = barcode;
            this.amountproduct = amountproduct;
            this.productdescription = productdescritiont;
            this.unitprice = unitprice;
        }
    }
}
