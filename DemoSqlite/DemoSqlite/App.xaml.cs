using System;
using Xamarin.Forms;
using DemoSqlite.DataContext;
using DemoSqlite.Views;
namespace DemoSqlite
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            GetContext().Database.EnsureCreated();

            MainPage = new Page1();
        }
        public static DataContext.AppDbContext GetContext()
        {
            string DbPath = DependencyService.Get<Interfaces.IConfigDataBase>().GetFullPath("efCore.db");

            return new AppDbContext(DbPath);
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
