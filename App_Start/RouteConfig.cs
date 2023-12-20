using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FTIS_IDCARD
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.Add(new Route("testroute-{para1}.cshtml", new AjaxGetRouteHandler()));      //配置当前路由规则下的 IRouteHandler处理类
            //routes.MapRoute(name: "testroute", url: "testroute-{para1}.cshtml");  //自己配置的全新路由规则，
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
        public class AjaxGetRouteHandler : IRouteHandler
        {
            public IHttpHandler GetHttpHandler(RequestContext requestContext)
            {
                //在当前类中可以对用于处理请求的controller,action等个各个参数进行赋值操作，可以在公开的地址栏对URL进行DES加密，这里进行解密从而得到真正的请求地址。
                requestContext.RouteData.Values["controller"] = "home";
                requestContext.RouteData.Values["action"] = "index";//requestContext.RouteData.Values["para1"].ToString().ToLower(); 
                return new MvcHandler(requestContext);
            }

        }
    }
}
