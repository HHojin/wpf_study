using System;
using System.Windows;
using System.Windows.Input;

namespace InheritTheWin
{
    class InheritTheWin : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new();
            app.Run(new InheritTheWin());   //new Application().Run(new InheritTheWin());
        }

        public InheritTheWin()
        {
            Title = "Inherit the Win";
        }
    }
}
