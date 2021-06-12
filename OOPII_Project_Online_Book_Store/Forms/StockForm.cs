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
    public partial class StockForm : Form
    {
        Stock stock;

        public StockForm(Stock stock):base()
        {
            this.stock = stock;
            InitializeComponent();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            lblStockName.Text = stock.Name;
            lblStockPrice.Text+= stock.Price.ToString() + " $"; 
            lblAuthor.Text += stock.Author;
            lblISBN.Text += stock.Code;
            lblPercent.Text += stock.Percent;
            lblPublisher.Text += stock.Publisher;
            lblType.Text += stock.Type.ToString();
            
            try
            {
                picbxStockPicture.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\stocks\" + stock.Picture);
            }
            catch
            {
                picbxStockPicture.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\not-found.png");
            }
            picbxStockPicture.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            ItemtoPurchase item = new ItemtoPurchase();
            item.Product = this.stock;
            item.Quantity =Convert.ToInt32(nudPurchase.Value);
            MainForm.shoppingcart.addProduct(item);
            MessageBox.Show("добавлен в ваш список продуктов", "информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void lblpage_Click(object sender, EventArgs e)
        {

        }
    }
}
