using Microsoft.AspNetCore.Mvc;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace HairSalon.Controllers
{
  public class ClientController : Controller 
  {
    private readonly HairSalonContext _db;

    public ClientController(HairSalonContext db)
    {
      _db = db;
    }

    public ActionResult Create(int id)
    {
      Stylist currentStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
      ViewBag.Stylist = currentStylist;
      return View();
    }

    [HttpPost]
    public ActionResult Create(Client newClient)
    {
      _db.Clients.Add(newClient);
      _db.SaveChanges();
      return RedirectToAction("Show", "Stylist", new { id = newClient.StylistId } );
    }
  }
}