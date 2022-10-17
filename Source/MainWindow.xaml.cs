using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Source
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            if(sender is Button b)
            {
                b.Background = new SolidColorBrush(Color.FromArgb(Convert.ToByte(random.Next(255)), Convert.ToByte(random.Next(255)), Convert.ToByte(random.Next(255)), Convert.ToByte(random.Next(255))));
                MessageBox.Show($"{b.Name}  {b.Background.ToString()}");
            }
        }

        private void btn_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Button b)
            {
                Container.Children.Remove(b);
                this.Title=b.Content.ToString();
            }
        }
    }
}
