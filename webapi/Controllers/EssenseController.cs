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
      public IEnumerable<SelectAllCoursesjoinByylanugaeID_Result> Get(int id)

        {
            using (essensetestEntities entities=new essensetestEntities())
            {
                var Result= entities.SelectAllCoursesjoinByylanugaeID(1).Where(x=>x.ID==id).ToList();           
                return Result;
            }

        }
             
    }
}