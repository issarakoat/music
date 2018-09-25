using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicTheory
{
    public class Note
    {
        public string name { get; set; }
        public string another_name { get; set; }
        public int position { get; set; }
        public Note(string _name)
        {
            this.name = _name;
            // this.position = _position;
        }
    }
}

