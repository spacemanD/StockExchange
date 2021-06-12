using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace StockExchange
{    
    public partial class BondsForm : Form
    {
        Bonds musicCD;
        public BondsForm(Bonds musicCD)
        {
            this.musicCD = musicCD;
            InitializeComponent();
        }

        private void BondsForm_Load(object sender, EventArgs e)
        {
            lblname.Text += musicCD.Name;
            lblprice.Text += musicCD.Price.ToString()+" $";
            lbltype.Text += musicCD.Type.ToString();
            txtIssue.Text = musicCD.Issue;
            try
            {
                pbmusicCD.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\bonds\" + musicCD.Picture);
            }
            catch
            {
                pbmusicCD.BackgroundImage = Image.FromFile(Application.StartupPath + @"\resources\not-found.png");
            }
            pbmusicCD.BackgroundImageLayout = ImageLayout.Zoom;
            
        }
        SoundPlayer soundPlayer = new SoundPlayer();

        private void btnpurchase_Click(object sender, EventArgs e)
        {
            ItemtoPurchase item = new ItemtoPurchase();
            item.Product = this.musicCD;
            item.Quantity = Convert.ToInt32(nudmussicCD.Value);
            MainForm.shoppingcart.addProduct(item);
            MessageBox.Show("Product/Products added to Shoppingcart", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
