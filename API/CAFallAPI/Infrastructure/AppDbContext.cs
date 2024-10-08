namespace CAFallAPI.Infrastructure;
options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

public class AppDbContext
{
    
}