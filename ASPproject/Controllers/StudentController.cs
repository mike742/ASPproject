using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPproject.Controllers
{
    public class StudentController : Controller
    {
        public string Index(int id, string name)
        {
            return "Hello from Student Controller  id = " + id
                // + " name " + Request.Query["name"]
                + " name =  " + name
                ;
        }

        public string GetDetails()
        {
            return "GetDetails() has been invoked!";
        }
    }
}
