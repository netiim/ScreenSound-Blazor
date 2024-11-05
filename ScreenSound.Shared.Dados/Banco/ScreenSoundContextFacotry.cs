using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ScreenSound.Banco;

public class ScreenSoundContextFactory : IDesignTimeDbContextFactory<ScreenSoundContext>
{
    public ScreenSoundContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ScreenSoundContext>();

        optionsBuilder.UseSqlServer("Server=localhost;Database=ScreenSoundV0;User ID=sa;Password=YourStrongPassword1!;TrustServerCertificate=True;");

        return new ScreenSoundContext(optionsBuilder.Options);
    }
}