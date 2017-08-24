# Mvc Menu Navigator

This code will help you to highlight the active tab in your menu. Of course, different uses depend on your creativity. 


## Installing 

```
-Install-Package Betalgo.MvcMenuNavigator  
```

## Code Example
Add your pages to an enum
```csharp
    public enum HeaderTop
    {
        Dashboard,
        Product
    }
    public enum HeaderSub
    {
        Index
    }
```

Put to top of your Controllor or Action
```csharp
    [MenuNavigator(HeaderTop.Product, HeaderSub.Index)]
    public class ProductsController : Controller
    {
        public async Task<ActionResult> Index()
        {
            return View();
        }
        
        [MenuNavigator(HeaderTop.Dashboard, HeaderSub.Index)]
        public async Task<ActionResult> Dashboard()
        {
            return View();
        }
    }
```

And use it In your header layout like this
```html
@{
    var headerTop = (HeaderTop?)MvcNavigatorPageData.HeaderTop;
    var headerSub = (HeaderSub?)MvcNavigatorPageData.HeaderSub;
}
<div class="nav-collapse collapse navbar-collapse navbar-responsive-collapse">
    <ul class="nav navbar-nav">
        <li class="@(headerTop==HeaderTop.Dashboard?"active selected open":"")">
            <a href="@Url.Action("Index","Home")" class="text-uppercase">
                <i class="icon-home"></i> Dashboard
            </a>
        </li>
        <li class="@(headerTop==HeaderTop.Product?"active selected open":"")">
            <a href="@Url.Action("Index", "Products")" class="text-uppercase">
                <i class="icon-diamond"></i> Products
            </a>
        </li>
    </ul>
</div>
```


