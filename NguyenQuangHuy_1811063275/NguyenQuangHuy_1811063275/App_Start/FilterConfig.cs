using System.Web;
using System.Web.Mvc;

namespace NguyenQuangHuy_1811063275
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
