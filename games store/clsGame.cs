using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games_store
{
    public class clsGame
    {
        private int id;
        private string name;
        private string catergory;
        private int stock;
        private decimal price;
        private string type;
        private string serial;
        private int weight;
        private decimal shipping;
        private string download;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Catergory { get => catergory; set => catergory = value; }
        public decimal Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Serial { get => serial; set => serial = value; }
        public int Weight { get => weight; set => weight = value; }
        public decimal Shipping { get => shipping; set => shipping = value; }
        public string Download { get => download; set => download = value; }

        public override string ToString()
        {
            return Name;
        }

        public static clsGame NewWork(string prChoice)
        {
            return new clsGame() { Type = prChoice };
        }
    }
}
