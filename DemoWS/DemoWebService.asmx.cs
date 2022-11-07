using DemoWS.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace DemoWS
{
    /// <summary>
    /// Summary description for DemoWebService
    /// </summary>
    [WebService(Namespace = "http://student-test.org")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DemoWebService : System.Web.Services.WebService
    {

        public static List<Student> students = new List<Student>();

        [WebMethod]
        public int addStudent(String name, String address)
        {
            try
            {
                students.Add(new Student() { name = name, address = address});
                return students.Count();
            }
            catch(Exception ex)
            {
                throw new System.Exception(ex.Message);
            }
            return -1;
        }

        [WebMethod]
        /*[System.Web.Script.Services.ScriptMethod(ResponseFormat = System.Web.Script.Services.ResponseFormat.Json)]*/
        public List<Student> getAll()
        {
            //students.Add(new Student() { name = "Le Tuan", address = "123" });
            return students;
        }
    }
}
