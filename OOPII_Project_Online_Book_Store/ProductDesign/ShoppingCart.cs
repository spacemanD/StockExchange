using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    //Вид оплаты
    public enum PaymentType
    {
        Unassigned,
        Cash,
        Creditcard,
    }
    public class ShoppingCart
    {
        DataBase data = DataBase.database();

        private int customerID;

        private List<ItemtoPurchase> ItemstoPurchase = new List<ItemtoPurchase>();

        private double paymentAmount = 0.0;

        PaymentType paymentType;

        public int CustomerID { get { return customerID; } set { customerID = value; } }

        public List<ItemtoPurchase> itemstoPurchase { get { return ItemstoPurchase; } set { ItemstoPurchase = value; } }

        public double PaymentAmount { get { return paymentAmount; } set { paymentAmount = value; } }
        /// <summary>
        /// Вывод купленных вещей
        /// </summary>
        public void printProducts() {
            ShoppingCartForm shoppingcartform = new ShoppingCartForm(this);
            shoppingcartform.ShowDialog();
            shoppingcartform.Dispose();
        }

        /// <summary>
        /// Добавить продукт в корзину
        /// </summary>
        /// <param name="itemtopurchase"></param>
        public void addProduct(ItemtoPurchase itemtopurchase)
        {
            PaymentAmount += itemtopurchase.Product.Price * itemtopurchase.Quantity;
            itemstoPurchase.Add(itemtopurchase);
        }

        //Разместить заказ
        public void placeOrder(PaymentType PaymentType)
        {
            string orders = "";
            string quantity = "";
            foreach (ItemtoPurchase item in itemstoPurchase)
            {
                orders += item.Product.Name+ ",";
                quantity += item.Quantity.ToString() + ",";
            }
            this.paymentType = PaymentType;

            var dt = DateTime.Now;
            data.addOrder(this.customerID, orders, quantity, "0", this.paymentAmount, this.paymentType.ToString(),dt);           
            sendInvoidcebyEmail();
        }

        //Отправить по почте чек
        public void sendInvoidcebyEmail()
        {
            EmailSender.SendEmail(data.GetCustomerbyID(this.CustomerID), this);
        }

        //Получить тип оплаты
        public static PaymentType GetPaymentType(string Type)
        {
            switch (Type)
            {
                case "Cash": return PaymentType.Cash;
                case "CreditCard": return PaymentType.Creditcard;
                default: return PaymentType.Unassigned;

            }
        }
    }
}
