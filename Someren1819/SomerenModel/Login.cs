using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public bool AdminRequest { get; set; }
        public bool RequestDenied { get; set; }
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
    }
}
