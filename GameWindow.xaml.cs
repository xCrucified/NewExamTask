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
using System.Windows.Shapes;

namespace NewExamTask
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        ViewModel viewModel;

        public GameWindow()
        {
            InitializeComponent();

            viewModel = new ViewModel();
            this.DataContext = viewModel;

            
        }

        private void Move_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Border_ExitBtn(object sender, MouseButtonEventArgs e)
        {
            this.Hide();

            MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
        }

        private void Border_Pause(object sender, MouseButtonEventArgs e)
        {
            this.Opacity = 69;
        }
    }
}
