namespace ASP_CORE_APPILACTION
{
	public class Startup
	{
		
			public void ConfigureServices(IServiceCollection services)
			{
				// Configuration of services
				services.AddControllersWithViews();
			}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			// Configuration of middleware
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Task}/{action=Index}/{id?}");


				endpoints.MapControllerRoute(
					   name: "task_add",
					   pattern: "{controller=Task}/{action=Add}");

				// Add the following route for the Edit action
				endpoints.MapControllerRoute(
						name: "task_edit",
						pattern: "{controller=Task}/{action=Edit}/{id?}");

				// Add the following route for the Delete action
				endpoints.MapControllerRoute(
						name: "task_delete",
						pattern: "{controller=Task}/{action=Delete}/{id?}");
			});


		}
	}
}
