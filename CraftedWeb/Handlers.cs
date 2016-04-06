using Crafted.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafted.Handlers
{
    public static class Handlers
    {
        public static TestPageData TestPage()
        {
            return new TestPageData()
            {
                Title = "My Page",
                Today = DateTime.Today
            };
        }
    }
}
