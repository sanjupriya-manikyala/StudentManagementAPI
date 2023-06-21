using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StudentManagement.API.DataAccess;
using StudentManagement.API.DataAccess.StudentNS;
using StudentManagement.API.DataAccess.StudentNS.Interface;
using StudentManagement.API.StudentManagement.Services.StudentNS;
using StudentManagement.API.StudentManagement.Services.StudentNS.Interface;

namespace StudentManagement
{
  public class Startup
  {
    public Startup(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    // This method gets called by the runtime. Use this method to add services to the container.
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddControllers();
      services.AddSwaggerGen();
      services.AddScoped<IStudentData, StudentData>();
      services.AddScoped<IStudentService, StudentService>();

      //Entity Framework  
      services.AddDbContext<StudentDbContext>(item => item.UseSqlServer(Configuration.GetConnectionString("StudentDBConnection")));
    }

    // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
      if (env.IsDevelopment())
      {
        app.UseDeveloperExceptionPage();
      }

      app.UseHttpsRedirection();

      app.UseRouting();

      app.UseAuthorization();

      app.UseEndpoints(endpoints =>
      {
        endpoints.MapControllers();
      });
      app.UseSwagger();
      app.UseSwaggerUI(c =>
      {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Test1 Api v1");
      });
    }
  }
}
