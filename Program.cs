using Game_Menager_Web.Data;
using Microsoft.EntityFrameworkCore;

namespace Game_Menager_Web
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			builder.Services.AddControllersWithViews();

			builder.Services.AddDbContext<ApplicationDbContext>(options=> 
				options.UseSqlServer(builder.Configuration.GetConnectionString("DeafaultConnection")));

            // builder.Services.AddDbContext<ApplicationDbContext>(); Do seedera
            // builder.Services.AddScoped<DandDSeeder>();    Do seedera


            var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			//app.UseAuthentication(); jak ju� zrobimy to musi by� przed autoryzacj�
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}