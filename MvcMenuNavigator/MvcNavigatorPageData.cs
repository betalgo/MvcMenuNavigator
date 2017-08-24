using System.Web;

namespace MvcMenuNavigator
{
    /// <summary>
    /// Page data information
    /// </summary>
    public static partial class MvcNavigatorPageData
    {
        public static object HeaderTop => HttpContext.Current.Session["MvcMenuNavigator.HeaderTop"];
        public static object HeaderSub => HttpContext.Current.Session["MvcMenuNavigator.HeaderSub"];
    }
}
