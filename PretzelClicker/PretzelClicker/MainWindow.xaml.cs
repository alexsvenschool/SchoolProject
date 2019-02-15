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

namespace PretzelClicker
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Score = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            HideMainMenu();
            ShowGame();
        }

        private void HideMainMenu()
        {
            btnExit.Visibility = Visibility.Hidden;
            btnOptions.Visibility = Visibility.Hidden;
            btnPlay.Visibility = Visibility.Hidden;

        }

        private void ShowMainMenu()
        {
            btnExit.Visibility = Visibility.Visible;
            btnOptions.Visibility = Visibility.Visible;
            btnPlay.Visibility = Visibility.Visible;

        }
        
        private void ShowGame()
        {
            btnClickField.Visibility = Visibility.Visible;
            lblScore.Visibility = Visibility.Visible;
        }

        private void HideGame()
        {
            btnClickField.Visibility = Visibility.Hidden;
            lblScore.Visibility = Visibility.Hidden;
        }

        private void UpdateScore()
        {
            lblScore.Content = "Score: " + Score;
        }

        private void BtnClickField_Click(object sender, RoutedEventArgs e)
        {
            Score++;
            UpdateScore();
        }

        private void WinMain_Loaded(object sender, RoutedEventArgs e)
        {
            ShowMainMenu();
            HideGame();
        }
    }
}
