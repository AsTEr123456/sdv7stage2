using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games_store
{
    public class clsOrder
    {
        private int id;
        private string customer_name;
        private string date;
        private int game_id;
        private decimal price;

        public int Id { get => id; set => id = value; }
        public string Customer_name { get => customer_name; set => customer_name = value; }
        public string Date { get => date; set => date = value; }
        public int Game_id { get => game_id; set => game_id = value; }
        public decimal Price { get => price; set => price = value; }

        public override string ToString()
        {
            return Customer_name + "\t" + Date;
        }
    }
}
