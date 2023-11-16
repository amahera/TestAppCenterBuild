using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace TestAppCenter
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();

            AppCenter.Start("android=c3098eb0-98c5-4d0f-9059-7edcf7f81332;", typeof(Analytics), typeof(Crashes));
        }
    }
}
