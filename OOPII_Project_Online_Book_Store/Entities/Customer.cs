

namespace StockExchange
{
    public class Customer
    {
        //Ім'я
        public string Name { get; set; }

        //Адреса
        public string Adress { get; set; }

        //Пошта
        public string Email { get; set; }

        //Нікнейм
        public string Username { get; set; }

        //Пароль
        public string Password { get; set; }

        //Підтвердження адміна
        public bool AdminConfirm { get; set; }

        public int CustomerID { get; set; }

        public static int Customercount { get; set; }

        /// <summary>
        /// Информация о пользователе
        /// </summary>
        public void printCustomerDetails()
        {
            userSettings userSettings = new userSettings(this);
            userSettings.ShowDialog();
            userSettings.Dispose();
        }

        /// <summary>
        /// Сохранение пользователя
        /// </summary>
        public void SaveCustomer()
        {
            DataBase data = DataBase.database();
            data.Newsign(this);

        }

        /// <summary>
        /// Вывод сделок пользователя
        /// </summary>
        public void printCustomerPurchases()
        {
            BillingsForm billingsForm = new BillingsForm(this);
            billingsForm.ShowDialog();
        }

        public Customer(int id,string name, string adress, string email, string username, string password)
        {
            this.CustomerID = id;
            this.Name = name;
            this.Adress = adress;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            Customercount++;
        }

        public Customer(string name, string adress, string email, string username, string password)
        {
            this.Name = name;
            this.Adress = adress;
            this.Email = email;
            this.Username = username;
            this.Password = password;
            Customercount++;
        }

        public Customer()
        {
        }
    }
}