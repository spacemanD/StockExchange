using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using Microsoft.Extensions.Configuration;

namespace StockExchange
{ 
    class EmailSender
    {
        //Отправка на почту для востановления пароля
        public static void SendEmail(Customer customer)
        {
            var builder = new ConfigurationBuilder()
             .AddJsonFile("appsettings.json");

            var config = builder.Build();
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("email@gmail.com");
                mail.To.Add(customer.Email);
                mail.Subject = "Востановление пароля";
                mail.Body = "Привет: " + customer.Username + " Твой пароль: " + customer.Password;

                using (SmtpClient smtp = new SmtpClient(config["Smtp:Host"], int.Parse(config["Smtp:Port"])))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(config["Smtp:Username"], config["Smtp:Password"]);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }

        //Отправка на почту списка покупок из корзины
        public static void SendEmail(Customer customer, ShoppingCart shopping)
        {
            var builder = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json");

            var config = builder.Build();
            string message = "";
            foreach (ItemtoPurchase item in shopping.itemstoPurchase)
            {
                message += item.Product.Name + "  из названный акций " + item.Quantity + " вы заказали это" + "\n";
            }
            message += "Общая сумма" + " " + shopping.PaymentAmount.ToString();
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("email@gmail.com");
                mail.To.Add(customer.Email);
                mail.Subject = "Счет";
                mail.Body = message;

                using (SmtpClient smtp = new SmtpClient(config["Smtp:Host"], int.Parse(config["Smtp:Port"])))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(config["Smtp:Username"], config["Smtp:Password"]);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }

        //Отправка чека по почте
        public static void SendEmail(Customer customer, string bidding)
        {
            var builder = new ConfigurationBuilder()
                          .AddJsonFile("appsettings.json");

            var config = builder.Build();
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("email@gmail.com");
                mail.To.Add(customer.Email);
                mail.Subject = "Чек";
                mail.Body = bidding;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(config["Smtp:Host"], int.Parse(config["Smtp:Port"])))
                {
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new NetworkCredential(config["Smtp:Username"], config["Smtp:Password"]);
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}

