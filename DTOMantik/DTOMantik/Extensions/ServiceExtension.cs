using Business.Abstract;
using Business.Concrete;
using DataAccesss.Abstract;
using DataAccesss.Concrete;

namespace DTOMantik.Extensions
{
    public static class ServiceExtension
    {

        public static void MyconfigureServices(this IServiceCollection services)//bunu program.cs e tanıtman lazzım
        {
            services.AddScoped<IStudentManager, StudentManager>();
            services.AddScoped<IStudentDal, StudentDal>();


            services.AddScoped<IUniversityManager, UniversityManager>();
            services.AddScoped<IUniversityDal, UniversityDal>();
        }
    }
}
