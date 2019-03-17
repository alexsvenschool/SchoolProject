using System;
using System.Windows;
using System.Media;
using System.Collections.Generic;
using System.Numerics;

namespace PretzelClicker
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SoundPlayer player = new SoundPlayer(@"Sounds/background_music.wav");//Background music
        SoundPlayer button_sound = new SoundPlayer(@"Sounds/ClickField.wav");//Button Sound

        Pretzel Pretzel = new Pretzel();
        PretzelUpdate PretzelUpdate = new PretzelUpdate();
        List<AutoClicker> lstAutoClicker = new List<AutoClicker>();

        public MainWindow()
        {
            InitializeComponent();
            player.Play();
            RefreshAutoPretzel();
            RefreshCosts();
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

        private void BtnClickField_Click(object sender, RoutedEventArgs e)
        {
            button_sound.Play();
            lblPretzel.Content = PretzelUpdate.UpdatePretzelScore(Pretzel.Clicked());
        }//end BtnClickField_Click

  
        private void BtnAutoClick(object sender, RoutedEventArgs e)
        {
            NewAutoClicker();            
        }//end BtnAutoClicker
        public void NewAutoClicker(int number = 1)
        {
            for(int i = 0; i < number; i++) { 
                lstAutoClicker.Add(new AutoClicker());
            }
            RefreshCosts();
            RefreshAutoPretzel();
        }

        public void RefreshCosts()
        {
            //lblAutoClickerCosts.Content = lstAutoClicker[lstAutoClicker.Count - 1].Costs();
        }

        public void RefreshAutoPretzel()
        {
            BigInteger val = 0;
            val += AutoClicker.Value();
        }

        private void BtnGrandma_Click(object sender, RoutedEventArgs e)
        {
            Pretzel.pretzel_pro_click = PretzelUpdate.Update(Pretzel, 1, 10);
        }//end BtnGrandma_Click

        private void BtnCafeteria_Click(object sender, RoutedEventArgs e)
        {
            Pretzel.pretzel_pro_click = PretzelUpdate.Update(Pretzel, 9 ,10);
        }//end BtnCafeteria_Click

        private void BtnBakery_Click(object sender, RoutedEventArgs e)
        {
            Pretzel.pretzel_pro_click = PretzelUpdate.Update(Pretzel, 99,10);
        }//end BtnBakery_Click

        private void BtnFactory_Click(object sender, RoutedEventArgs e)
        {
            Pretzel.pretzel_pro_click = PretzelUpdate.Update(Pretzel, 999,10);
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
