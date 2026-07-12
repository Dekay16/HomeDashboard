using HomeDashboard.Business.Interfaces;
using HomeDashboard.Data.Context;
using HomeDashboard.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeDashboard.Business.Services
{
    public class RoomService : IRoomService
    {
        private readonly HomeDashboardDbContext _context;

        public RoomService(HomeDashboardDbContext context)
        {
            _context = context;
        }


        public async Task<List<Room>> GetRoomsAsync()
        {
            return await _context.Rooms
                .Include(x => x.Appliances)
                .Include(x => x.PaintColors)
                .ToListAsync();
        }
    }
}
