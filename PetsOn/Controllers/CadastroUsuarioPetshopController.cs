using Microsoft.AspNetCore.Mvc;

namespace PetsOn.Controllers
{
    public class CadastroUsuarioPetshopController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }

    }
}