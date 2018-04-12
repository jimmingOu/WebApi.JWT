using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.JWT.Models
{
    public class LoginRequest
    {
        public string account { set; get; }
        public string password { set; get; }
    }
}