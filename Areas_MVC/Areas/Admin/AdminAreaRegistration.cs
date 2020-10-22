using System.Web.Mvc;

namespace Areas_MVC.Areas.Admin
{
    public class AdminAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Admin";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Admin_default",
                "Admin/{controller}/{action}/{id}",
                new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                // Elimina erro do mesmo nome do controlador dentro da Area e na raiz do projeto
                namespaces: new[] { "Areas_MVC.Areas.Admin.Controllers" }
            );
        }
    }
}