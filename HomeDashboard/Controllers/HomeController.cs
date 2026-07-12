using HomeDashboard.Data.Context;
using HomeDashboard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class HomeController : Controller
{
    private readonly HomeDashboardDbContext _context;


    public HomeController(
        HomeDashboardDbContext context)
    {
        _context = context;
    }


    public async Task<IActionResult> Index()
    {
        var model = new DashboardViewModel
        {
            RoomCount =
                await _context.Rooms.CountAsync(),

            VehicleCount =
                await _context.Vehicles.CountAsync(),

            ApplianceCount =
                await _context.Appliances.CountAsync(),

            ReminderCount =
                await _context.Reminders
                .CountAsync(x => !x.Completed)
        };


        return View(model);
    }
}