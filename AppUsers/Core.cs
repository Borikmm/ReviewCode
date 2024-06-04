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
        private int core_id;
        private string name;
        private string numberfind;
        private string price;

        public int CoreId
        {
            get { return core_id; }
            set { core_id = value; }
        }

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

        public Core(int core_id, string name, string price, string number_find)
        {
            this.core_id = core_id;
            this.name = name;
            this.price = price;
            this.numberfind = number_find;
        }
    }
}
