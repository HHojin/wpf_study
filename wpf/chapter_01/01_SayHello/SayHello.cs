using System;
using System.Windows;
using System.Windows.Input;

namespace SayHello
{
    class SayHello
    {
        [STAThread]
        public static void Main()
        {
            Window win = new()
            {
                Title = "Say Hello"
            };
            win.Show();

            Application app = new();
            app.Run();  //app.Run(win);
        }
    }
}
