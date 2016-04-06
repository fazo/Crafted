using Crafted.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CraftedWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            WebServer ws = new WebServer(RouteRequest, "http://localhost:8080/test/");
            ws.Run();
            Console.WriteLine("Press any key to stop the server");
            Console.ReadKey();
            ws.Stop();
        }

        public static string RouteRequest(HttpListenerRequest request)
        {
            return string.Format("<HTML><BODY>My web page.<br>{0}</BODY></HTML>", DateTime.Now);
        }
    }
}
