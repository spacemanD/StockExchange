using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockExchange.ProductDesign
{
    public class JsonFileDesign
    {
        //Запись в файл json
        public void Write<T>(List<T> Input)
        {
            using(FileStream fs = new FileStream("user.json", FileMode.OpenOrCreate))
            {
                string json = JsonConvert.SerializeObject(Input);
                File.WriteAllText(@"C:\Users\dimas\OneDrive\Рабочий стол\Институт\курсач\StockExchange\OOPII_Project_Online_Book_Store\user.json", json);
            }
        }
    }
}
