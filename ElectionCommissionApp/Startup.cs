using ElectionCommissionApp.BusinessLogic;
using ElectionCommissionApp.DAL;
using System.Configuration;

namespace ElectionCommissionApp
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IVoter, VotersBusinessLogic>();
            services.AddMvc();          

        }
    }
}
