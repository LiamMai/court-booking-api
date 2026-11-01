
namespace CourtBookingApi.Data;

using CourtBookingApi.Models.Court;
using Microsoft.EntityFrameworkCore;

class CourtBookingDbContext : DbContext
{
    public CourtBookingDbContext(DbContextOptions<CourtBookingDbContext> options): base(options)
    {
    }

    public DbSet<Court> Courts { get; set; }
}