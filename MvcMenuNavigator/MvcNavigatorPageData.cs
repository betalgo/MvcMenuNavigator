using System.Web;
using MvcMenuNavigator.NavigationMenu;

namespace MvcMenuNavigator
{
    /// <summary>
    /// Page data information
    /// </summary>
    public static partial class MvcNavigatorPageData
    {
        public static HeaderTop HeaderTop => (HeaderTop)HttpContext.Current.Session["MvcMenuNavigator.HeaderTop"];
        public static HeaderTop HeaderSub => (HeaderTop)HttpContext.Current.Session["MvcMenuNavigator.HeaderSub"];
    }
}
