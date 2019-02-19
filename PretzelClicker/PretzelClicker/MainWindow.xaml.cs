using System;
using System.Windows;
using System.Media;

namespace PretzelClicker
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer player = new SoundPlayer("Sounds/background_music.wav");//Background music

        public int Pretzel = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnPlay_Click(object sender, RoutedEventArgs e)
        {
            HideMainMenu();
            ShowGame();
        }//end BtnPlay_Click

        private void HideMainMenu()
        {
            btnExit.Visibility = Visibility.Hidden;
            btnOptions.Visibility = Visibility.Hidden;
            btnPlay.Visibility = Visibility.Hidden;
        }//end HideMainMenu

        private void ShowMainMenu()
        {
            btnExit.Visibility = Visibility.Visible;
            btnOptions.Visibility = Visibility.Visible;
            btnPlay.Visibility = Visibility.Visible;

        }//end ShowMainMenu

        private void ShowGame()
        {
            btnClickField.Visibility = Visibility.Visible;
            lblPretzel.Visibility = Visibility.Visible;
        }//end ShowGame

        private void HideGame()
        {
            btnClickField.Visibility = Visibility.Hidden;
            lblPretzel.Visibility = Visibility.Hidden;
        }//end HideGame

        private void UpdateScore()
        {
            lblPretzel.Content = "Pretzel: " + Pretzel;
        }//end UpdateScore

        private void BtnClickField_Click(object sender, RoutedEventArgs e)
        {
            Pretzel++;
            UpdateScore();
        }//end BtnClickField_Click

        private void WinMain_Loaded(object sender, RoutedEventArgs e)
        {
            ShowMainMenu();
            HideGame();
            player.PlayLooping(); //Loop background_music
        }//end WinMain_Loaded

        private void BtnGrandma_Click(object sender, RoutedEventArgs e)
        {
            Pretzel = Pretzel + 2;
            UpdateScore();
        }//end BtnGrandma_Click

        private void LoadSettings()
        {
            //Pretzel = Properties.Settings.Default.Pretzel;
        }

        private void CloseGame()
        {
            //Properties.Settings.Default.Pretzel = Pretzel;
            
        }

        private void WinMain_Closed(object sender, EventArgs e)
        {
            CloseGame();
        }
    }
}
