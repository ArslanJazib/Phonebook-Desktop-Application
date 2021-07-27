using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTier
{
    public class Row
    {
        string serial;
        string name;
        string number;
        string email;
        string address;
        public string Serial { get => serial; set => serial = value; }
        public string Name { get => name; set => name = value; }
        public string Number { get => number; set => number = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
    }
}
