using System.Web;
using System.Web.Mvc;

namespace Examen_Parcial2_Sergio_Lopez
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
