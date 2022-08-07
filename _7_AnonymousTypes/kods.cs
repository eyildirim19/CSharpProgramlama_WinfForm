using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_AnonymousTypes
{

    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
    }


    public class UserDTO
    {
        public string Name { get; set; }

        public string SurName { get; set; }
    }
}
