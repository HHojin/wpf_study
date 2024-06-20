using System;
using System.Windows;
using System.Windows.Input;

namespace _02_HandleAnEvent
{
    class HandleAnEvent
    {
        [STAThread]
        public static void Main()
        {
            Application app = new();

            Window win = new()
            {
                Title = "Handle An Event"
            };
            win.MouseDown += WindowOnMouseDown;

            app.Run(win);
        }

        static void WindowOnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Window win = sender as Window;
            string strMessage =
                string.Format("Window clicked with {0} button at point ({1})",
                               e.ChangedButton, e.GetPosition(win));
            MessageBox.Show(strMessage, win.Title);  //MessageBox.Show(strMessage, Application.Current.MainWindow.Title);
        }
    }
}
