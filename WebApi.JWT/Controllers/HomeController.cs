using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.JWT.Controllers
{
    public class HomeController : ApiController
    {
        public Object Get()
        {
            return new
            {
                status = true
            };
        }
    }
}
