using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Localisation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var args = Environment.GetCommandLineArgs();
            foreach (var arg in args)
            {
                if (arg.EndsWith("/red"))
                {
                    this.Background = new SolidColorBrush(Colors.Red);
                }
                else if(arg.EndsWith("/text"))
                {
                    lab1.Background= new SolidColorBrush(Colors.Blue);
                    lab1.Foreground = new SolidColorBrush(Colors.Yellow);
                }
                else if (arg.EndsWith("/grid"))
                {
                    Grid1.Visibility = Visibility.Visible;
                }
                else if (arg.EndsWith("/ua"))
                {
                    lab2.Visibility= Visibility.Visible;
                    lab3.Visibility = Visibility.Visible; 
                }
                else if (arg.EndsWith("/red"))
                {
                    Slide.Visibility = Visibility.Visible;
                }
            }
        }

        private void Ukr_Click(object sender, RoutedEventArgs e)
        {
            lab1.Content = "Вітаю";
        }

        private void Eng_Click(object sender, RoutedEventArgs e)
        {
            lab1.Content = "Congratulations";
        }

        private void Pol_Click(object sender, RoutedEventArgs e)
        {
            lab1.Content = "Gratulacje";
        }
    }
}
