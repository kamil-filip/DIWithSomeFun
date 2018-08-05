using DIWinFormsView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;
using CSVRepository;
using SqlRepository;
using Unity;
using Repository.Interface;
using Unity.Lifetime;

namespace ApplicatiobBootstraper
{



    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            var myContainer = new UnityContainer();

            myContainer.RegisterType<IRepository, MyCsvRepository>
                ( new ContainerControlledLifetimeManager());


            Application.Run(new WinFormsView(myContainer.Resolve<MyViewModel>()));


            /*myContainer.RegisterType<IViewModel>

            var myRepo = new MySqlRepository();
            var myViewModel = new MyViewModel(myRepo);
            */

        }
    }
}
