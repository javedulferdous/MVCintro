using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVCApp.Controllers
{
    public class HelloController : Controller
    {
        //
        // GET: /Hello/
        public string SayHello(string name, int? value)
        {
            

            string message = "<h1> Hello "+name+ ", Welcome to MVC Application Developement </h1>";

            

            if (value>0 && value<15)
            {
                message += "<br/> Value is from zero to Fifteen!";
            }
            else if (value>=15 && value <100)
            {
                message += "<br/> value is less than hundred!";
            }
            else
            {
                message += "<br/> value out of bound!";
            }

            return message;

        }
	}
}