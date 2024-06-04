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
        private int placeid;
        private string name;
        private string bandwidth;

        public int PlaceId
        {
            get { return placeid; }
            set { placeid = value; }
        }

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

        public Place(string name, string role, string bandwidth, int placeid)
        {
            this.name = name;
            this.bandwidth = bandwidth;
            this.placeid = placeid;
        }
    }
}
