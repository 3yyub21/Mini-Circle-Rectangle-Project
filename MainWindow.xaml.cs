using System.Security.Cryptography;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Xml.Linq;

namespace WPF_06._05._2024__Hausaufgabe_Projekt_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Tick += TimeTick;
        }

        private void TimeTick(object? sender, EventArgs e)
        {
            if (MeinGrid.Children.Contains(ellipse) && (MeinGrid.Children.Contains(rectangle)))
            {
                switch (rnd.Next(1, 5))
                {
                    case 1:
                        ellipse.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)(rnd.Next(1, 255))));
                        rectangle.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)(rnd.Next(1, 255))));
                        break;

                    case 2:
                        ellipse.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)(rnd.Next(1, 255))));
                        rectangle.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)(rnd.Next(1, 255))));
                        break;

                    case 3:
                        ellipse.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)(rnd.Next(1, 255))));
                        rectangle.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)(rnd.Next(1, 255))));
                        break;

                    case 4:
                        ellipse.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)(rnd.Next(1, 255))));
                        rectangle.Fill = new SolidColorBrush(Color.FromRgb((byte)rnd.Next(1, 255), (byte)rnd.Next(1, 255), (byte)(rnd.Next(1, 255))));
                        break;
                }
            }

            else
            {
                MeinGrid.Children.Add(ellipse);
                MeinGrid.Children.Add(rectangle);
            }
        }

        DispatcherTimer timer = new DispatcherTimer();

        Ellipse ellipse = new Ellipse
        {
            Height = 125,
            Width = 125,
            VerticalAlignment = VerticalAlignment.Center,
            HorizontalAlignment = HorizontalAlignment.Center,
            StrokeThickness = 3,
            Stroke = Brushes.Black,
        };

        Random rnd = new Random();

        Rectangle rectangle = new Rectangle
        {
            Height = 62.5,
            Width = 62.5,
            VerticalAlignment = VerticalAlignment.Center,
            HorizontalAlignment = HorizontalAlignment.Center,
            StrokeThickness = 1.5,
            Stroke = Brushes.Black,
        };

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            if (timer.IsEnabled)
            {
                timer.Stop();
            }

            else
            {
                timer.Start();
            }
        }
    }
}