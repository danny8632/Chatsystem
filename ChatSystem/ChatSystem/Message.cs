using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystem
{
    public class Message
    {
        public string message { get; set; }

        public string roomName { get; set; }

        public string time { get; set; }

        public string username { get; set; }

        public string Display
        {
            get
            {
                return string.Format("{0} : {1} : {2}", username, message, time);
            }
        }
    }
}
