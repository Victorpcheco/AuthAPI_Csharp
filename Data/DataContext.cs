
using AuthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace AuthAPI.Data;

public class DataContext : DbContext {

    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    public DbSet <UserModel> users { get; set; }
}