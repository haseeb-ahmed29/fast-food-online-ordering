using Microsoft.EntityFrameworkCore;
using FastFoodOnlineOrdering.Models;

namespace FastFoodOnlineOrdering.Data;
public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<MenuItem> MenuItems => Set<MenuItem>();
}
