using System.Web;
using System.Web.Mvc;

namespace Demo_ASP.netMVC05
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
