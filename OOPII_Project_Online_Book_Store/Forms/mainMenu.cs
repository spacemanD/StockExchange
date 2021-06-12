using StockExchange.ProductDesign;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StockExchange
{
    public partial class MainForm : Form
    {
        Customer customer;
        public static ShoppingCart shoppingcart;
        public MainForm(Customer customer)
        {
            this.customer = customer;
            shoppingcart = new ShoppingCart();
            shoppingcart.CustomerID = customer.CustomerID;
            InitializeComponent();
        }

        List<Product> products = new List<Product>();
        List<Product> currentProducts = new List<Product>();
        DataBase Data = DataBase.database();

        private void mainMenu_Load(object sender, EventArgs e)
        {
            shoppingcart.CustomerID = customer.CustomerID;
            ProductPanelCreator panelcreator = new ProductPanelCreator();
            Data.GetProduct(products);
            btnAdminInterface.Visible = false;
            cmbProductType.SelectedIndex = 0;
            lblusername.Text = customer.Username;
            lblemail.Text = customer.Email;
            lblID.Text = customer.CustomerID.ToString();
        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {
            flPanel.Controls.Clear();
            cmbCategory.Items.Clear();

            switch (cmbProductType.SelectedIndex)
            {
                case 0:

                    LoadProduct(ProductNames.All, "All");
                    cmbCategory.Hide();
                    lblCategory.Hide();

                    break;
                case 1:

                    cmbCategory.Show();
                    lblCategory.Show();

                    string[] bookCategory = new string[] { "All Stock", "ShortTerm", "LongTerm", "MidleTerm" };
                    cmbCategory.Items.AddRange(bookCategory);
                    cmbCategory.SelectedIndex = 0;
                    break;
                case 2:
                    cmbCategory.Show();
                    lblCategory.Show();

                    string[] magazineCategory = new string[] { "All Possessions", "RealEstate", "Transport" };
                    cmbCategory.Items.AddRange(magazineCategory);
                    cmbCategory.SelectedIndex = 0;
                    break;
                case 3:
                    cmbCategory.Show();
                    lblCategory.Show();

                    string[] musicCategory = new string[] { "All Bond", "State", "Corporate", "Municipal", "Discount" };
                    cmbCategory.Items.AddRange(musicCategory);
                    cmbCategory.SelectedIndex = 0;
                    break;
                default:
                    break;
            }

        }

        private void cmbCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            flPanel.Controls.Clear();
            currentProducts.Clear();


            if (cmbProductType.SelectedIndex == 1)
            {
                switch (cmbCategory.SelectedIndex)
                {
                    case 0:
                        LoadProduct(ProductNames.Stock, "All");
                        break;
                    case 1:
                        LoadProduct(ProductNames.Stock, "ShortTerm");
                        break;
                    case 2:
                        LoadProduct(ProductNames.Stock, "LongTerm");
                        break;
                    case 3:
                        LoadProduct(ProductNames.Stock, "MidleTerm");
                        break;
                    default:
                        break;
                }
            }
            else if (cmbProductType.SelectedIndex == 2)
            {
                switch (cmbCategory.SelectedIndex)
                {
                    case 0:
                        LoadProduct(ProductNames.Possessions, "All");
                        break;
                    case 1:
                        LoadProduct(ProductNames.Possessions, "RealEstate");
                        break;
                    case 2:
                        LoadProduct(ProductNames.Possessions, "Transport");
                        break;
                    default:
                        break;
                }

            }
            else if (cmbProductType.SelectedIndex == 3)
            {

                switch (cmbCategory.SelectedIndex)
                {
                    case 0:
                        LoadProduct(ProductNames.Bounds, "All");
                        break;
                    case 1:
                        LoadProduct(ProductNames.Bounds, "State");
                        break;
                    case 2:
                        LoadProduct(ProductNames.Bounds, "Corporate");
                        break;
                    case 3:
                        LoadProduct(ProductNames.Bounds, "Municipal");
                        break;
                    case 4:
                        LoadProduct(ProductNames.Bounds, "Discount");
                        break;
                    default:
                        break;
                }
            }
        }

       private void LoadByName()
        {
            List<Product> products = new List<Product>();
            DataBase dataBase = DataBase.database(); ;
            var res = dataBase.GetProductByName(products, txtName.Text);
            foreach (var item in res)
            {
                ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                flPanel.Controls.Add(productPanel);
            }     
        }
        
        private void LoadProduct(ProductNames ProductName, string category)
        {
            switch (ProductName)
            {
                case ProductNames.All:
                    foreach (Product item in products)
                    {
                        currentProducts.Add(item);
                        ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                        flPanel.Controls.Add(productPanel);
                    }
                    break;
                case ProductNames.Possessions:
                    if (category == "All")
                    {
                        foreach (Product item in products)
                        {
                            if (item is Possessions)
                            {
                                currentProducts.Add(item);
                                ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                                flPanel.Controls.Add(productPanel);

                            }
                        }
                    }
                    else
                        LoadPossessions(category);
                    break;
                case ProductNames.Bounds:
                    if (category == "All")
                    {
                        foreach (Product item in products)
                        {
                            if (item is Bonds)
                            {
                                currentProducts.Add(item);
                                ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                                flPanel.Controls.Add(productPanel);
                            }
                        }
                    }
                    else
                        LoadBonds(category);
                    break;
                case ProductNames.Stock:
                    if (category == "All")
                    {
                        foreach (Product item in products)
                        {
                            if (item is Stock)
                            {
                                currentProducts.Add(item);
                                ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                                flPanel.Controls.Add(productPanel);
                            }
                        }
                    }
                    else
                        LoadStock(category);
                    break;
                default:
                    break;
            }
        }
        void LoadPossessions(String category)
        {

            foreach (Product item in products)
            {
                if (item is Possessions)
                {
                    Possessions magazine = (Possessions)item;
                    if (category == magazine.Type.ToString())
                    {
                        currentProducts.Add(item);
                        ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                        flPanel.Controls.Add(productPanel);
                    }
                }
            }
        }
        void LoadBonds(String category)
        {
            foreach (Product item in products)
            {
                if (item is Bonds)
                {
                    Bonds musicCD = (Bonds)item;

                    if (category == musicCD.Type.ToString())
                    {
                        currentProducts.Add(item);
                        ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                        flPanel.Controls.Add(productPanel);
                    }
                }
            }
        }
        void LoadStock(String category)
        {
            foreach (Product item in products)
            {
                if (item is Stock)
                {
                    Stock book = (Stock)item;
                    if (category == book.Type.ToString())
                    {
                        currentProducts.Add(item);
                        ProductPanel productPanel = ProductPanelCreator.CreatePanel(item);
                        flPanel.Controls.Add(productPanel);
                    }
                }
            }
        }

        private void pnlProductShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            shoppingcart.printProducts();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            customer.printCustomerDetails();
           
        }
        
        private void btnLogout_Click(object sender, EventArgs e)
        {
            MainForm.ActiveForm.Dispose();
            loginForm loginForm = new loginForm();
            loginForm.ShowDialog();
            
        }

        private void btnBillings_Click(object sender, EventArgs e)
        {
            customer.printCustomerPurchases();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BillingsForm billingsForm = new BillingsForm(customer);
            billingsForm.ShowDialog();
        }

        private void lblemail_Click(object sender, EventArgs e)
        {
            LoadByName();
        }

        private void flPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyData == Keys.F1)
            {
                try
                {
                    JsonFileDesign json = new JsonFileDesign();
                    json.Write<Product>(currentProducts);

                    MessageBox.Show("Successful", "Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Not Successful", "Recorded", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            flPanel.Controls.Clear();
            LoadByName();
        }
    }


}

