using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebService2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        //[WebMethod]
        /*
         public string show()
        {
            return "Method from first web service";
        }
        */

        
        [WebMethod(Description = "Method of called web service")]
        public string display()
        {
            localhost.MathService obj = new localhost.MathService();
            return obj.show1();
        }
        

        [WebMethod(Description ="Method of called web service")]
        public System.Single display2()
        {
            localhost.MathService obj2 = new localhost.MathService();
            return obj2.Multiply(6,4);
        }
    }
}
