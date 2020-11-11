using System.Web;
using System.Web.Mvc;

namespace _18110209_DangNguyenHoaiThu_BTTuan06
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
