using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsers
{
    public class Core
    {

        public int id { get; set; }
        private string name;
        private string numberfind;
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string NumberFind
        {
            get { return numberfind; }
            set { numberfind = value; }
        }


        public Core() { }

        public Core(string name, string price, string number_find)
        {
            this.name = name;
            this.price = price;
            this.numberfind = number_find;
        }
    }
}
