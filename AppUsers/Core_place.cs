using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AppUsers
{
    public class Core_place
    {
        public int id { get; set; }
        private int placeid;
        private int coreid;
        private string typedev;
        private string open;
        private string close;
        private int storage;
        private int ourselfprice;
        public string TypeDev
        {
            get { return typedev; }
            set { typedev = value; }
        }

        public string Open
        {
            get { return open; }
            set { open = value; }
        }

        public string Close
        {
            get { return close; }
            set { close = value; }
        }

        public int PlaceId
        {
            get { return placeid; }
            set { placeid = value; }
        }

        public int CoreId
        {
            get { return coreid; }
            set { coreid = value; }
        }

        public int Storage
        {
            get { return storage; }
            set { storage = value; }
        }

        public int OurselfPrice
        {
            get { return ourselfprice; }
            set { ourselfprice = value; }
        }


        public Core_place() { }

        public Core_place(int core_id, int place_id, int stor, int price, string type, string open, string close)
        {
            this.coreid = core_id;
            this.placeid = place_id;
            this.typedev = type;
            this.open = open;
            this.close = close;
            this.ourselfprice = price;
            this.storage = stor;
        }
    }
}
