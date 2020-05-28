using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrmarireBuguri.domain
{
    public class Bug
    {
        public int id { get; set; }
        public string denumire { get; set; }
        public string descriere { get; set; }

        public Bug(int Id, string Denumire, string Descriere)
        {
            id = Id;
            denumire = Denumire;
            descriere = Descriere;
        }

        public Bug() { }
    }
}
