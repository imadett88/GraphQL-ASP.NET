using GraphqlWithAsp.Data;
using GraphqlWithAsp.GraphQL;
using HotChocolate.AspNetCore;
using HotChocolate.AspNetCore.Playground;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(
    op => op.UseSqlServer(builder
    .Configuration.GetConnectionString("DefaultConnection")));

//Add service GraphQL
builder.Services.AddScoped<Query>();
builder.Services.AddGraphQL(p => SchemaBuilder.New().AddServices(p)
                                 .AddType<UserTypes>().AddQueryType<Query>().Create());

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


//Use the Services
app.UsePlayground(new PlaygroundOptions
{
    QueryPath = "/api",
    Path = "/playground"
});


app.UseRouting();

app.MapGraphQL("/api");

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
