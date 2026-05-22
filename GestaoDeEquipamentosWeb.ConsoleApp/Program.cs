using Microsoft.AspNetCore.Mvc.Razor;

// ASP.NET Core - Aplicação Web
// Builder de um servidor web
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// MVC com configuração de view locations
builder.Services.AddControllersWithViews()
    .AddRazorOptions(options =>
    {
        options.ViewLocationFormats.Clear();

        options.ViewLocationFormats.Add("/{1}/Apresentacao/Views/{0}.cshtml");
        options.ViewLocationFormats.Add("/Modulo{1}/Apresentacao/Views/{0}.cshtml");

        options.ViewLocationFormats.Add("/Compartilhado/Apresentacao/Views/{0}.cshtml");
    });

// Criação da instância do servidor web
WebApplication app = builder.Build();

// Middlewares - Funções que executam em cada chamada que o nosso servidor vai receber
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();

// Inicia o loop da aplicação
app.Run();
