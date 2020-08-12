using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;

namespace SmallColorPicker.Demo
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ResetColor_Click(object sender, RoutedEventArgs e)
        {
            ColorPicker.SelectedColor = Colors.Red;
        }

        private void ColorPicker_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            //if (Changes!=null) Changes.Items.Add(ColorPicker.SelectedColor.ToString());
            Debug.WriteLine("Changed to " + ColorPicker.SelectedColor.ToString());
        }

        private void ResetColor2_Click(object sender, RoutedEventArgs e)
        {
            ColorPicker2.SelectedColor = Colors.Red;
        }

        private void RandomColor_Click(object sender, RoutedEventArgs e)
        {
            ColorPicker.SelectedColor = RandomColor();
        }

        private void RandomColor2_Click(object sender, RoutedEventArgs e)
        {
            ColorPicker2.SelectedColor = RandomColor();
        }

        private Color RandomColor()
        {
            Random r = new Random();
            return Color.FromArgb((byte)r.Next(256), (byte)r.Next(256), (byte)r.Next(256), (byte)r.Next(256));
        }

        private void ColorPicker2_ColorChanged(object sender, RoutedPropertyChangedEventArgs<Color> e)
        {
            Debug.WriteLine("Changed to " + ColorPicker2.SelectedColor.ToString());
        }
    }
}