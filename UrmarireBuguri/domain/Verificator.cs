using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrmarireBuguri.domain
{
    public class Verificator
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }

        public Verificator() { }

        public Verificator(int Id, string Username, string Password)
        {
            id = Id;
            username = Username;
            password = Password;
        }
    }
}
