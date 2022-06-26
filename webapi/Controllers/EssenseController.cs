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
                List<SelectAllCoursesjoinByylanugaeID_Result> precourseList = new List<SelectAllCoursesjoinByylanugaeID_Result>();
                var Result= entities.SelectAllCoursesjoinByylanugaeID(1).Where(x=>x.ID==id).ToList();
                foreach (var item in Result)
                {
                    precourseList.Add(new SelectAllCoursesjoinByylanugaeID_Result() { course_name1 = item.course_name1, ID = item.ID });

                }
                return precourseList;
            }

        }
             
    }
}