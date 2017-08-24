using System.Web;
using System.Web.Mvc;

namespace MvcMenuNavigator
{
    public class MenuNavigator : ActionFilterAttribute, IActionFilter
    {
        private readonly object _headerTop;
        private readonly object _headerSub;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="headerTop">Main Menu</param>
        /// <param name="headerSub">Sub Menu</param>
        public MenuNavigator(object headerTop, object headerSub)
        {
            _headerTop = headerTop;
            _headerSub = headerSub;
        }

        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Session["MvcMenuNavigator.HeaderTop"] = _headerTop;
            filterContext.HttpContext.Session["MvcMenuNavigator.HeaderSub"] = _headerSub;

            OnActionExecuting(filterContext);
        }
    }
}
