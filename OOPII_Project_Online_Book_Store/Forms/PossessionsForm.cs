using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockExchange
{
    public partial class PossessionsForm : Form
    {
        Possessions magazine;
        public PossessionsForm(Possessions magazine):base()
        {
            this.magazine = magazine;
            InitializeComponent();
        }

        private void PossessionsForm_Load(object sender, EventArgs e)
        {
            lblname.Text += magazine.Name;
            lblprice.Text += magazine.Price.ToString()+"$"; 
            lbltype.Text += magazine.Type.ToString();
            pbmagazine.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\Possessions\" + magazine.Picture);
            try
            {
                pbmagazine.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\Possessions\" + magazine.Picture);
            }
            catch
            {
                pbmagazine.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\not-found.png");
            }
            pbmagazine.BackgroundImageLayout = ImageLayout.Zoom;
            txtIssue.Text = magazine.Issue;
            txtIssue.Enabled = false;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ItemtoPurchase item = new ItemtoPurchase();
            item.Product = this.magazine;
            item.Quantity = Convert.ToInt32(nudMagazine.Value);
            MainForm.shoppingcart.addProduct(item);
            MessageBox.Show("Product/Products added to Shoppingcart","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
