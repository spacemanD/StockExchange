

namespace StockExchange
{
    public enum BondsType
    {
        State,
        Corporate,
        Municipal,
        Discount
    }
    public class Bonds : Product
    {
        public Bonds(string date, BondsType type, string name, int id, double price, string corpor, string picture, string issue) : base(name, id, price, picture, issue)
        {
            this.Date = date;
            this.Type = type;
            this.Corporation = corpor;
        }

        public Bonds(string name, int id, double price, string picture, string issue) : base(name, id, price, picture, issue)
        {
        }

        //Дата друку
        public string Date { get; set; }

        //Тип
        internal BondsType Type { get; set; }

        //Тип (строковий варіант)
        public string Kind { get; set; }

        //Корпорація
        public string Corporation { get; set; }
        /// <summary>
        /// Вывод основных свойств
        /// </summary>
        public override void printProperties()
        {
            BondsForm music = new BondsForm(this);
            music.ShowDialog();
            music.Dispose();
        }
        public Bonds()
        {
        }
        /// <summary>
        /// Получения типа облигации
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        static public BondsType GetBondsType(string type)
        {
            switch (type)
            {
                case "State": return BondsType.State;
                case "Corporate": return BondsType.Corporate;
                case "Municipal": return BondsType.Municipal;
                case "Discount": return BondsType.Discount;
                default: return 0;
            }
        }
    }
}
