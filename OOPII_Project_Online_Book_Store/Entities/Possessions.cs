using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchange
{
    public enum PossessionsType
    {
        RealEstate,
        Transport
    }
    public class Possessions : Product
    {
        public Possessions(PossessionsType type, string issue, string name, int id, double price, string picture) : base(name, id, price, picture, issue)
        {
            this.Type = type;
        }


        public Possessions(string name, int id, double price, string picture, string issue) : base(name, id, price, picture, issue)
        {
        }
        
        //Тип
        public PossessionsType Type { get; set; }

        //Тип (строковий варінт)
        public string Kind { get; set; }

        public Possessions()
        { }
        /// <summary>
        /// Получения типа активов
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        static public PossessionsType GetPossessions(string type)
        {
            switch (type)
            {

                case "RealEstate": return PossessionsType.RealEstate;
                case "Transport": return PossessionsType.Transport;
                default: return 0;
            }
        }
        /// <summary>
        /// Отображение на форме основных характеристик
        /// </summary>
        public override void printProperties()
        {
            PossessionsForm magazine = new PossessionsForm(this);
            magazine.ShowDialog();
            magazine.Dispose();
        }
    }
}
