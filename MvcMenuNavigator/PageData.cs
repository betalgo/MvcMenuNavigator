using System.Web;
using MvcMenuNavigator.NavigationMenu;

namespace MvcMenuNavigator
{
    static class MvcNavigatorPageData
    {
        public static HeaderTop HeaderTop => (HeaderTop) HttpContext.Current.Session["MvcMenuNavigator.HeaderTop"];
        public static HeaderTop HeaderSub => (HeaderTop) HttpContext.Current.Session["MvcMenuNavigator.HeaderSub"];
    }
}
