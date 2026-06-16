using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP03_Martinez_Loufer.Models;

namespace TP03_Martinez_Loufer.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        PalabrasAhorcado palabrasAhorcado = new PalabrasAhorcado();
        ViewBag.palabra = palabrasAhorcado.obtenerPalabra();
        return View();
    }
    public IActionResult Formulario()
    {
        return View();
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [HttpGet]
    public IActionResult agregarPalabra(string palabra)
    {
        BD bd = new BD();
        bd.agregarPalabra(palabra);
        return RedirectToAction("Index");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
