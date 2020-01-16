using Prognoser.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prognoser.Model
{
    public class Literature
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int SoldCopies { get; set; }
        public DateTime Date { get; set; }

        public Literature(string name, string author, double price, int soldCopies)
        {
            this.Name = name;
            this.Price = price;
            this.Author = author;
            this.SoldCopies = soldCopies;
        }

        public Literature(){}
    }
}
