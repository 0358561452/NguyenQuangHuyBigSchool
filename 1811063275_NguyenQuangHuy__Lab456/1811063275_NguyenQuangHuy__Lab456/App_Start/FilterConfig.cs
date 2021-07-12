using System.Web;
using System.Web.Mvc;

namespace _1811063275_NguyenQuangHuy__Lab456
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
