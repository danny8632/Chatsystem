using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystem
{
    public class Room
    {
        public string name { get; set; }

        public string Display
        {
            get
            {
                return string.Format(name);
            }
        }

    }
}
