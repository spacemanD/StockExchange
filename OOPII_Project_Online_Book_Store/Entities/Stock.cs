using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    public enum StockType
    {
        ShortTerm,
        LongTerm,
        MidleTerm
    }
    public class Stock : Product
    {
        //Автор
        public string Author { get; set; }

        //Код
        public string Code { get; set; }

        //Видавник
        public string Publisher { get; set; }

        //Процентна ставка
        public int Percent { get; set; }

        //Тип (строкова властивість)
        public string Kind { get; set; }

        //Тип
        internal StockType Type { get; set; }

        public Stock(StockType type, string code, string author, string publisher, string picture, int percent, string name, int id, double price, string issue) : base(name, id, price, picture, issue)
        {
            this.Code = code;
            this.Author = author;
            this.Publisher = publisher;
            this.Percent = percent;
            this.Type = type;
        }

        public Stock(string name, int id, double price, string picture, string issue) : base(name, id, price, picture, issue)
        {
        }
        public Stock()
        {
        }

        /// <summary>
        /// Вывод основных свойств на экран 
        /// </summary>
        public override void printProperties()
        {
            StockForm BookForm = new StockForm(this);
            BookForm.ShowDialog();
            BookForm.Dispose();
        }

        //Получения типа акции
        static public StockType GetStockType(string type)// Получения типа из бд
        {
            switch (type)
            {
                case "ShortTerm": return StockType.ShortTerm;
                case "LongTerm": return StockType.LongTerm;
                case "MidleTerm": return StockType.MidleTerm;
                default: return 0;
            }
        }  
    }
}
