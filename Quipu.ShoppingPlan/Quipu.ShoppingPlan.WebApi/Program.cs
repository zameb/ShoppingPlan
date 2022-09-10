using Microsoft.EntityFrameworkCore;
using Quipu.ShoppingPlan.Repository;
using Quipu.ShoppingPlan.Repository.EfRepository;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("default");
var migrationsAssembly = typeof(ShoppingPlanContext).Assembly.GetName().Name;

builder.Services.AddControllers();

builder.Services
  .AddDbContext<ShoppingPlanContext>(options =>
  {
      options.UseSqlServer(connectionString, o => o.MigrationsAssembly(migrationsAssembly));
  });
builder.Services.AddTransient<IArticlesRepository, ArticlesRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
