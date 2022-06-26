using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using essenseClassLibrary;

namespace webapi.Controllers
{
    public class EssenseController : ApiController
    {
        [System.Web.Http.HttpGet]
      public IEnumerable<Cours> Get(int id)

        {
            using (essensetestEntities entities=new essensetestEntities())
            {
               
                return entities.Courses.ToList().Where(x => x.Course_Preid == id).ToList();
            }

        }
             
    }
}