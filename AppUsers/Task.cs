using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace AppUsers
{
    public class Task
    {
        public int id { get; set; }
        private int idUser { get; set; }
        private string name;
        private string data;
        private string time;
        private string text;
        private int _does;

        public int IdUser
        {
            get { return idUser; }
            set { idUser = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Data
        {
            get { return data; }
            set { data = value; }
        }
        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public int Does
        {
            get { return _does; }
            set { _does = value; }
        }


        public Task() { }

        public Task(int idUser, string name, string data, string time, string text, int does)
        {
            this.idUser = idUser;
            this.name = name;
            this.data = data;
            this.time = time;
            this.text = text;
            this._does = does;
        }

    }
}
