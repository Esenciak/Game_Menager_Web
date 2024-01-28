using Game_Menager.DataAccess.Data;
using Game_Menager.DataAccess.Repository;
using Game_Menager.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

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


   builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<ApplicationDbContext>();

   builder.Services.AddIdentity<IdentityUser,IdentityRole>(/*options => options.SignIn.RequireConfirmedAccount = true wyłączam potwierdzenie mailem*/).AddEntityFrameworkStores<ApplicationDbContext>();
												// dodałem role
			builder.Services.AddRazorPages();


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

			//app.UseAuthentication(); jak ju� zrobimy to musi by� przed autoryzacj�
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{area=Gracz}/{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}
