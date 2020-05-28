using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrmarireBuguri.domain
{
    public class Programator
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Programator(int Id, string Username, string Password)
        {
            id = Id;
            username = Username;
            password = Password;
        }

        public Programator() { }

        public override string ToString()
        {
            return "[Programator-> id: " + id + ", username: " + username + ", password: " + password + "]";
        }
    }
}
