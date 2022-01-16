using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shared.Interfaces.Business;
using AmberAlertBusiness;
using Shared.Interfaces.Repository;
using DataAccessLayer;

namespace PresentationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var loginForm = serviceProvider.GetRequiredService<LoginForm>();
                Application.Run(loginForm);
            }


                //Application.Run(new LoginForm());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<IFindingBusiness, FinidingBusiness>();
            services.AddScoped<IMissingBusiness, MissingBusiness>();
            services.AddScoped<IPoliceOfficerBusiness, PoliceOfficerBusiness>();

            services.AddScoped<IFindingRepository, FindingRepository>();
            services.AddScoped<IMissingRepository, MissingRepository>();
            services.AddScoped<IPoliceOfficerRepository, PoliceOfficerRepository>();

            services.AddScoped<LoginForm>();
        }
    }
}
