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
        public int Pretzel = 0;
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
            lblPretzel.Visibility = Visibility.Visible;
        }

        private void HideGame()
        {
            btnClickField.Visibility = Visibility.Hidden;
            lblPretzel.Visibility = Visibility.Hidden;
        }

        private void UpdateScore()
        {
            lblPretzel.Content = "Pretzel: " + Pretzel;
        }

        private void BtnClickField_Click(object sender, RoutedEventArgs e)
        {
            Pretzel++;
            UpdateScore();
        }

        private void WinMain_Loaded(object sender, RoutedEventArgs e)
        {
            ShowMainMenu();
            HideGame();
        }

        private void BtnGrandma_Click(object sender, RoutedEventArgs e)
        {
            Pretzel = Pretzel + 2;
            UpdateScore();
        }

        private void LoadSettings()
        {
            Score = Properties.Settings.Default.Score;
        }

        private void CloseGame()
        {
            Properties.Settings.Default.Score = Score;
        }

        private void WinMain_Closed(object sender, EventArgs e)
        {
            CloseGame();
        }
    }
}
