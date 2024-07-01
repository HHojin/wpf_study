using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace GradiateTheBrush
{
    class GradiateTheBrush : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new();
            app.Run(new GradiateTheBrush());
        }

        public GradiateTheBrush()
        {
            Title = "Gradiate the Brush";

            LinearGradientBrush brush = new(Colors.Red, Colors.Blue,
                                            new Point(0, 0), new Point(0.25, 0.25));
            brush.SpreadMethod = GradientSpreadMethod.Reflect; //Pad, Repeat

            Background = brush;
            Width = 500;
            Height = 500;
        }
    }
}
