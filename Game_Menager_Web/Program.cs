using Game_Menager.DataAccess.Data;
using Game_Menager.DataAccess.Repository;
using Game_Menager.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Game_Menager.Utility;
using Microsoft.AspNetCore.Identity.UI.Services;

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

   builder.Services.AddIdentity<IdentityUser,IdentityRole>(/*options => options.SignIn.RequireConfirmedAccount = true wyłączam potwierdzenie mailem*/).AddEntityFrameworkStores<ApplicationDbContext>();
												// dodałem role
			builder.Services.AddRazorPages();
			builder.Services.AddScoped<IEmailSender, EmailSender>();

			builder.Services.AddScoped<IHeroesRepository, HeroesRepository>();


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

			app.UseAuthentication();
			app.UseAuthorization();
			app.MapRazorPages();

			app.MapControllerRoute(
				name: "default",
				pattern: "{area=Gracz}/{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
