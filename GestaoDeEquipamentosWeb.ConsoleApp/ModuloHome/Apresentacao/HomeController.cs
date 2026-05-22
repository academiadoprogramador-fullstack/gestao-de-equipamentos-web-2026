using Microsoft.AspNetCore.Mvc;

namespace GestaoDeEquipamentosWeb.ConsoleApp.ModuloHome.Apresentacao;

public class HomeController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }
}
