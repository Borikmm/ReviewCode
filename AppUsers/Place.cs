using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUsers
{
    public class Place
    {
        public int id { get; set; }
        private string name;
        private string bandwidth;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string BandWidth
        {
            get { return bandwidth; }
            set { bandwidth = value; }
        }

        public Place() { }

        public Place(string name, string bandwidth)
        {
            this.name = name;
            this.bandwidth = bandwidth;
        }
    }
}
