using Radzen;

using TaskBook_WebBlazor.Components;

namespace TaskBook_WebBlazor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddRadzenComponents();
            builder.Services.AddBootstrapBlazor();
            builder.Services.AddSwaggerGen();
            builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
            var app = builder.Build();
            app.UseMvcWithDefaultRoute();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            }
            app.UseHsts();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>().AddInteractiveServerRenderMode();

            //app.MapTask_BookEndpoints();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Blazor API V1");
            });

            app.Run();
        }
    }
}
