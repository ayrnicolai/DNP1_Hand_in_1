using System;
using System.Security.Claims;
using DNP1___Hand_in_1.Data;
using Hand_in_1.Authentication;
using Hand_in_1.Data;
using Hand_in_1.Data.Impl;
using Hand_in_1.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hand_in_1 {
public class Startup {
    public Startup(IConfiguration configuration) {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services) {
        services.AddRazorPages();
        services.AddServerSideBlazor();
        services.AddSingleton<IAdultData, AdultJSONData>();

        services.AddScoped<IUserService, InMemoryUserService>();
        
        services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

        services.AddAuthorization(options => {

            options.AddPolicy("SecurityLevel4",  a => 
                a.RequireAuthenticatedUser().RequireClaim("SecurityLevel", "4","5"));
            
            options.AddPolicy("MustBeTeacher",  a => 
                a.RequireAuthenticatedUser().RequireClaim("Role", "Teacher"));
            
            options.AddPolicy("SecurityLevel2", policy =>
                policy.RequireAuthenticatedUser().RequireAssertion(context => {
                    Claim levelClaim = context.User.FindFirst(claim => claim.Type.Equals("SecurityLevel"));
                    if (levelClaim == null) return false;
                    return int.Parse(levelClaim.Value) >= 2;
                }));
        });
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env) {
        if (env.IsDevelopment()) {
            app.UseDeveloperExceptionPage();
        } else {
            app.UseExceptionHandler("/Error");

            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseEndpoints(endpoints => {
            endpoints.MapBlazorHub();
            endpoints.MapFallbackToPage("/_Host");
        });
    }
}
}