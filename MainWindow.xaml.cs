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

namespace NewExamTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
        }
        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Hide();

            GameWindow gameWindow = new GameWindow();
            gameWindow.Show();
        }

        private void Border_Exit(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Border_ChangeDifficult(object sender, MouseButtonEventArgs e)
        {
            Difficults difficults = new Difficults();
            difficults.Show();
        }

        private void Border_Rules(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(@"
In this game, the player must combine tiles containing the
same numbers until they reach the number 2048.
The tiles can contain only integer values starting from 2,
and that are a power of two, like 2, 4, 8, 16,
32, and so on. Ideally, the player should reach the 2048
tile within the smallest number of steps.");

        }
    }
}
