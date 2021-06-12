using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using StockExchange;
using System.Linq;

namespace StockExchange
{
    class DataBase
    {
        private static DataBase dataBase;

        private static string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Stock;Integrated Security=True";
        public  string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }
        public static DataBase database()
        {
            if (dataBase == null)
            {
                dataBase = new DataBase();
            }
            return dataBase;
        }
        //Проверка пароля и сравнения с базой
        public bool Password_control(string user, string Password)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Customers where Username ='" + user + "'and Password ='" + Password + "'", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                connection.Close();
                return true;
            }
            else
            {
                connection.Close();
                return false;
            }

        }

        //Регистрация нового пользователя
        public bool Newsign(Customer Customer)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Customers where Username ='" + Customer.Username + "'", connection);
            SqlDataReader dataReader = command.ExecuteReader();
            if (dataReader.Read())
            {
                command.ExecuteNonQuery();
                connection.Close();
                return false;

            }
            else
            {
                dataReader.Close();
                
                string sorgu = "Insert into Customers (Username,Password,Name,Email,Adress,AdminConfirm) values (@Username,@Password,@Name,@Email,@Adress,@AdminConfirm)";
                SqlCommand komut = new SqlCommand(sorgu, connection);
                komut.Parameters.AddWithValue("@Username", Customer.Username);
                komut.Parameters.AddWithValue("@Password", Customer.Password);
                komut.Parameters.AddWithValue("@Name", Customer.Name);
                komut.Parameters.AddWithValue("@Email", Customer.Email);
                komut.Parameters.AddWithValue("@Adress", Customer.Adress);
                komut.Parameters.AddWithValue("@AdminConfirm", Customer.AdminConfirm.ToString());
                komut.ExecuteNonQuery();
                connection.Close();
                return true;
            }
        }

        //Получения списка доступных айтемов
        public void GetProduct(List<Product> productList)
        {
            using (ProductContext db = new ProductContext())
            {
                var books = db.Stock;
                var posses = db.Possessions;
                var bonds = db.Bonds;
                foreach (var item in books)
                {
                    productList.Add(new Stock(Stock.GetStockType(item.Kind), item.Code, item.Author, item.Publisher, item.Picture, item.Percent, item.Name, item.Id, item.Price, item.Issue));
                }

                foreach (var item in posses)
                {
                    productList.Add(new Possessions(Possessions.GetPossessions(item.Kind), item.Issue, item.Name, item.Id, item.Price, item.Picture));
                }

                foreach (var item in bonds)
                {                                    
                    productList.Add(new Bonds(item.Date, Bonds.GetBondsType(item.Kind), item.Name, item.Id, item.Price, item.Corporation, item.Picture, item.Issue));
                }
            }
        }

        //Получение по имени вещи
        public List<Product> GetProductByName(List<Product> productList, string name)
        {
            using (ProductContext db = new ProductContext())
            {
                var books = db.Stock;
                var posses = db.Possessions;
                var bonds = db.Bonds;
                foreach (var item in books)
                {
                    productList.Add(new Stock(Stock.GetStockType(item.Kind), item.Code, item.Author, item.Publisher, item.Picture, item.Percent, item.Name, item.Id, item.Price, item.Issue));
                }

                foreach (var item in posses)
                {
                    productList.Add(new Possessions(Possessions.GetPossessions(item.Kind), item.Issue, item.Name, item.Id, item.Price, item.Picture));
                }

                foreach (var item in bonds)
                {
                    productList.Add(new Bonds(item.Date, Bonds.GetBondsType(item.Kind), item.Name, item.Id, item.Price, item.Corporation, item.Picture, item.Issue));
                }
            }
            return productList.Where(x => x.Name == name).ToList();
        }

        //Поиск пользователя по почте
        public Customer GetCustomer(string Email)
        {
            Customer Customer = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Customers", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (Email == reader["Email"].ToString().Trim())
                {
                    Customer = new Customer(Convert.ToInt32(reader["CustomerID"]),reader["Name"].ToString().Trim(), reader["Adress"].ToString().Trim(),
                        reader["Email"].ToString().Trim(), reader["Username"].ToString().Trim(), reader["Password"].ToString().Trim());
                }
            }
            connection.Close();
            return Customer;
        }

        //Поиск пользователя по имени
        public Customer GetCustomerByUsername(string Username)
        {
            Customer Customer = null;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("select * from Customers where Username ='" + Username + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (Username == reader["Username"].ToString().Trim())
                {
                    Customer = new Customer(Convert.ToInt32(reader["CustomerID"]),reader["Name"].ToString().Trim(), reader["Adress"].ToString().Trim(),
                        reader["Email"].ToString().Trim(), reader["Username"].ToString().Trim(), reader["Password"].ToString().Trim());

                }
            }
            connection.Close();
            return Customer;
        }

        //Поиск пользователя по Id
        public Customer GetCustomerbyID(int Id)
        {
            using (ProductContext db = new ProductContext())
            {
                var user = db.Customer.Find(Id);
                return user;
            }
        }

        //Обновления пользователя
        public void updateCustomer(int ID, string Name, string Username, string Password, string Email, string Adress)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string kayit = "update Customers set Name=@Name,Username=@Username,Password=@Password,Email=@Email,Adress=@Adress where CustomerID="+ID;
            SqlCommand komut = new SqlCommand(kayit, connection);
            komut.Parameters.AddWithValue("@Name", Name);
            komut.Parameters.AddWithValue("@Username", Username);
            komut.Parameters.AddWithValue("@Password", Password);
            komut.Parameters.AddWithValue("@Email", Email);
            komut.Parameters.AddWithValue("@Adress", Adress);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Update success.");

        }

        //Добавление заказа
        public void addOrder(int Id,string orders,string quantity,string cancel,double price,string type,DateTime date)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string sorgu = "Insert into orders (Id,orders,quantity,iscancel,price,type,date) values (@Id,@orders,@quantity,@iscancel,@price,@type,@date)";
            SqlCommand komut = new SqlCommand(sorgu, connection);
            komut.Parameters.AddWithValue("@Id", Id);
            komut.Parameters.AddWithValue("@orders",orders );
            komut.Parameters.AddWithValue("@quantity", quantity);
            komut.Parameters.AddWithValue("@iscancel", cancel);
            komut.Parameters.AddWithValue("@price", price);
            komut.Parameters.AddWithValue("@type", type);
            komut.Parameters.AddWithValue("@date", date);

            connection.Open();
            komut.ExecuteNonQuery();
            connection.Close();

        }

        //Размещения таблицы уже заполненных заказов юзера
        public DataTable datagrIdOrder(DataTable dt, int Id)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            string kayit = "SELECT * from orders where Id="+Id+" and iscancel= 0";
            SqlCommand komut = new SqlCommand(kayit, connection);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }

        //Удаление заказа
        public void DeleteOrder(DateTime dt,int Id)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            string kayit = "update orders set iscancel=@iscancel where date=@date and Id=@Id";
            SqlCommand komut = new SqlCommand(kayit, connection);
            komut.Parameters.AddWithValue("@iscancel", "1");
            komut.Parameters.AddWithValue("@date", dt);
            komut.Parameters.AddWithValue("@Id", Id);
            komut.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Update success.");
        }

    }
}
