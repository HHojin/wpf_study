using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace AdjustTheGradient
{
    class AdjustTheGradient : Window
    {
        LinearGradientBrush brush;

        [STAThread]
        public static void Main()
        {
            Application app = new();
            app.Run(new AdjustTheGradient());
        }

        public AdjustTheGradient()
        {
            Title = "Adjust the Gradient";
            SizeChanged += WindowOnSizeChanged;

            brush = new(Colors.Blue, Colors.Red, 0)
            {
                MappingMode = BrushMappingMode.Absolute
            };
            Background = brush;
        }

        void WindowOnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            double width = ActualWidth - 2 * SystemParameters.ResizeFrameVerticalBorderWidth;
            double height = ActualHeight - 2 * SystemParameters.ResizeFrameHorizontalBorderHeight - SystemParameters.CaptionHeight;

            Point ptCenter = new(width / 2, height / 2);
            Vector vectDiag = new(width, -height);    // new Point(width, 0) - new Poing(0, height);
            Vector vectPerp = new(vectDiag.Y, -vectDiag.X);

            vectPerp.Normalize();
            vectPerp *= width * height / vectDiag.Length;

            brush.StartPoint = ptCenter + vectPerp;
            brush.EndPoint = ptCenter - vectPerp;
        }
    }
}
