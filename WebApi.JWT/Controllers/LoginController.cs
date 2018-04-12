using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.JWT.Models;
using WebApi.JWT.Security;

namespace WebApi.JWT.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Login/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Login
        public Object Post(LoginRequest loginRequest)
        {
            if( loginRequest.account == "jim" && loginRequest.password == "12345")
            {
                JwtAuthUtil jwtAuthUtil = new JwtAuthUtil();
                string jwtToken = jwtAuthUtil.GenerateToken();
                return new
                {
                    status = true ,
                    token = jwtToken
                };
            }
            else
            {
                return new
                {
                    status = false,
                    token = "Account Or Password Error"
                };
            }
        }

        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
