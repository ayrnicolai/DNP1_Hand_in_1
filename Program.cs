using FileData;
using Hand_in_1.Models;
using Hand_in_1.Shared;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Hand_in_1 {
public class Program {
    public static void Main(string[] args) {
        CreateHostBuilder(args).Build().Run();
        User user = new User();
        FileContext file = new FileContext();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
}
}