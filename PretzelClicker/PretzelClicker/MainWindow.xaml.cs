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
        Pretzel Pretzel = new Pretzel();
        PretzelUpdate PretzelUpdate = new PretzelUpdate();

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
            lblPretzelProClick.Visibility = Visibility.Visible;
        }//end ShowGame

        private void HideGame()
        {
            btnClickField.Visibility = Visibility.Hidden;
            lblPretzel.Visibility = Visibility.Hidden;
            lblPretzelProClick.Visibility = Visibility.Hidden;
        }//end HideGame

        private void BtnClickField_Click(object sender, RoutedEventArgs e)
        {
            lblPretzel.Content = PretzelUpdate.UpdatePretzelScore(Pretzel.Clicked());
        }//end BtnClickField_Click

  
        private void BtnAutoClick(object sender, RoutedEventArgs e)
        {

        }//end BtnAutoClicker
        private void BtnGrandma_Click(object sender, RoutedEventArgs e)
        {
            Pretzel.pretzel_pro_click = PretzelUpdate.Update(Pretzel, 1, 10);
            lblPretzelProClick.Content = PretzelUpdate.UpdatePretzelProClick(Pretzel.pretzel_pro_click);
        }//end BtnGrandma_Click

        private void BtnCafeteria_Click(object sender, RoutedEventArgs e)
        {
            Pretzel.pretzel_pro_click = PretzelUpdate.Update(Pretzel, 9 ,10);
            lblPretzelProClick.Content = PretzelUpdate.UpdatePretzelProClick(Pretzel.pretzel_pro_click);
        }//end BtnCafeteria_Click

        private void BtnBakery_Click(object sender, RoutedEventArgs e)
        {
            Pretzel.pretzel_pro_click = PretzelUpdate.Update(Pretzel, 99,10);
            lblPretzelProClick.Content = PretzelUpdate.UpdatePretzelProClick(Pretzel.pretzel_pro_click);
        }//end BtnBakery_Click

        private void BtnFactory_Click(object sender, RoutedEventArgs e)
        {
            Pretzel.pretzel_pro_click = PretzelUpdate.Update(Pretzel, 999,10);
            lblPretzelProClick.Content = PretzelUpdate.UpdatePretzelProClick(Pretzel.pretzel_pro_click);
        }//end BtnFactory_Click

        private void WinMain_Loaded(object sender, RoutedEventArgs e)
        {
            ShowMainMenu();
            HideGame();
            //player.PlayLooping(); //Loop background_music
        }//end WinMain_Loaded

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
