using System;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace FlipThroughtTheBrushes
{
    class FlipThroughtTheBrushes : Window
    {
        int index = 0;
        PropertyInfo[] props;

        [STAThread]
        public static void Main()
        {
            Application app = new();
            app.Run(new FlipThroughtTheBrushes());
        }

        public FlipThroughtTheBrushes()
        {
            props = typeof(Brushes).GetProperties(BindingFlags.Public | BindingFlags.Static);
            SetTitleAndBackgound();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if(e.Key == Key.Down || e.Key == Key.Up)
            {
                index += e.Key == Key.Up ? 1 : props.Length - 1;
                index %= props.Length;
                SetTitleAndBackgound();
            }
            base.OnKeyDown(e);
        }

        void SetTitleAndBackgound()
        {
            Title = "Flip Through the Brushes - " + props[index].Name;
            Background = (Brush)props[index].GetValue(null, null);
        }
    }
}
