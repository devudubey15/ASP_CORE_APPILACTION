using Microsoft.AspNetCore.Hosting;

namespace ASP_CORE_APPILACTION
{
	public class Program
	{
		public static void Main(string[] args)
		{
			//	//CreateBuilder is the static method of WebApplication class which returns the instance of WebApplicationBuilder class
			//	//which is then assigned to builder . which will used to configure services, middleware and other aspect of application.
			//	var builder = WebApplication.CreateBuilder(args);


			//	// Add services to the container.
			//	builder.Services.AddControllersWithViews();



			//	var app = builder.Build();

			//	// Configure the HTTP request pipeline.
			//	if (!app.Environment.IsDevelopment())
			//	{
			//		app.UseExceptionHandler("/Home/Error");
			//		// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
			//		app.UseHsts();
			//	}

			//	app.UseHttpsRedirection();
			//	app.UseStaticFiles();

			//	app.UseRouting();

			//	app.UseAuthorization();

			//	app.MapControllerRoute(
			//		name: "default",
			//		pattern: "{controller=Home}/{action=Index}/{id?}");



			//	//app.Run(async (context) => { await context.Response.WriteAsync("ASP .net core "); }
			//	//	);


			//	app.Run();

			CreateHostBuilder(args).Build().Run();

		}

		public static IHostBuilder CreateHostBuilder(string[] args) =>
		Host.CreateDefaultBuilder(args)
			.ConfigureWebHostDefaults(webBuilder =>
			{
				webBuilder.UseStartup<Startup>();
			});
	}
}