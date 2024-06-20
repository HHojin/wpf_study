using System;
using System.Windows;
using System.Windows.Input;

namespace _04_ThrowWindowParty
{
    class ThrowWindowParty : Application
    {
        [STAThread]
        public static void Main()
        {
            ThrowWindowParty app = new()
           {
               //ShutdownMode = ShutdownMode.OnMainWindowClose
           };
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window winMain = new()
            {
                Title = "Main Window"
            };
            winMain.MouseDown += WondowOnMouseDown;
            winMain.Show();

            for(int i = 0; i < 2; i ++)
            {
                Window win = new()
                {
                    Title = "Extra Window No. " + (i + 1)
                };
                win.Show();
                win.Owner = winMain;
            }

            //ShutdownMode = ShutdownMode.OnMainWindowClose;
        }

        private void WondowOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Window win = new()
            {
                Title = "Modal Dialog Box"
            };
            win.ShowDialog();
        }
    }
}
