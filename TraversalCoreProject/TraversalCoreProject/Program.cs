using BusinessLayer.Container;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc.Razor;
using TraversalCoreProject.CQRS.Handlers.DestinationHandlers;
using TraversalCoreProject.Mapping.AutoMapperProfile;
using TraversalCoreProject.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddScoped<GetAllDestinationQueryHandler>();
builder.Services.AddScoped<GetDestinationByIDQueryHandler>();
builder.Services.AddScoped<CreateDestinationCommandHandler>();
builder.Services.AddScoped<RemoveDestinationHandler>();
builder.Services.AddScoped<UpdateDestinationCommandHandler>();

builder.Services.AddMediatR(typeof(Program)); // typeof bize veri t�r�n� geri d�nd�r�r burada parametre olarak program.cs i�erisindne oldu�unu g�steriyoruz
// logging i�lemleri loglama ?
builder.Services.AddLogging(x =>
{
    x.ClearProviders(); // sa�lay�c�lar� temizle
    x.SetMinimumLevel(LogLevel.Debug); // loglama i�lemlerimizin seviyelerini belirleme kodlar�m�z (information , warning vb)
    x.AddDebug();
});

// Startup dosyas� i�erisine yaz�lmas� gerekiyordu 
builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>().AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();
builder.Services.AddHttpClient();
// BusinessLayer �zerinde Static bir Class ve method sayesinde burada Ef ba��ml�l���n� kald�r�yoruz ( tek tek burada yazmak yerine Extensions class�nda toplad�k
builder.Services.ContainerDependencies();

builder.Services.AddAutoMapper(typeof(MapProfile));  // startup.cs olmad��� i�in olu�turulan MapProfile.cs type g�sterilerek yaz�l�yor 

builder.Services.CustomValidator(); // BL Container i�erisinden �a��r�yoruz


// Authorization i�lemlerini yapt�k.
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

builder.Services.AddLocalization(opt =>
{
    opt.ResourcesPath = "Resources";
});

builder.Services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix).AddDataAnnotationsLocalization();


builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Login/SignIn";
});


builder.Host.ConfigureLogging(loggerFactory =>
{
    var path = Directory.GetCurrentDirectory();
    loggerFactory.AddFile($"{path}\\Logs\\log1.txt");
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseStatusCodePagesWithReExecute("/ErrorPage/Error404", "?code={0}");
app.UseHttpsRedirection();
app.UseStaticFiles();


app.UseRouting();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseAuthentication();
app.UseAuthorization();

var supportedCultures = new[] { "tr", "en", "gb", "de", "fr", "gr" };
var localizationOptions = new RequestLocalizationOptions().SetDefaultCulture(supportedCultures[0]).AddSupportedCultures(supportedCultures).
                                                                                                                           AddSupportedUICultures(supportedCultures);
app.UseRequestLocalization(localizationOptions);
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
});


app.Run();
