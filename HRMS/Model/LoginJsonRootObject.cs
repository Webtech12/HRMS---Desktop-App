using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Model
{
    public class LoginJsonRootObject
    {
        public string Password { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
