using ASP_Data_Visualization.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_Data_Visualization.Controllers;

public class JimmyController : Controller
{
    [HttpGet]
    public IActionResult Index(int count = 10)
    {
        var model = new List<JimmyModel>();
        for (var i = 0; i < count; i++)
        {
            model.Add(new JimmyModel());
        }
        
        return View(model);
    }
}