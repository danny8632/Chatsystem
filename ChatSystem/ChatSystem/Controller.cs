using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatSystem
{
    public class Controller
    {
        public List<User> users { get; set; }

        public List<Message> messages { get; set; }

        public List<Room> rooms { get; set; }

        public Controller()
        {
            users = new List<User>();
            messages = new List<Message>();
            rooms = new List<Room>();
        }

        public int UserListCount()
        {
            return users.Count();
        }
    }
}
