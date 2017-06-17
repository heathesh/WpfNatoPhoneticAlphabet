using System.Windows;
using Microsoft.Practices.Unity;
using MobileDevCoZa.NatoPhoneticAlphabet.BusinessLogic;
using MobileDevCoZa.NatoPhoneticAlphabet.Interface.BusinessLogic;
using MobileDevCoZa.NatoPhoneticAlphabet.Interface.UserInterface;

namespace MobileDevCoZa.NatoPhoneticAlphabet.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Application.Startup" /> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.Windows.StartupEventArgs" /> that contains the event data.</param>
        protected override void OnStartup(StartupEventArgs e)
        {

            base.OnStartup(e);

            IUnityContainer container = new UnityContainer();

            container.RegisterType<IMainWindow, MainWindow>();
            container.RegisterType<IDataService, DataService>();
            container.RegisterType<IConversionService, ConversionService>();

            container.Resolve<MainWindow>().Show();
        }
    }
}
