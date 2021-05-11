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

namespace BartlomiejSajdok_S00196895
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        GameData db = new GameData();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string[] gamePlatforms = { "PC", "PS", "Xbox", "Switch" };
            gameSelection.ItemsSource = gamePlatforms;


            var query = from gd in db.Games
                        orderby gd.Name
                        select gd;

            var results = query.ToList();

            lbxGames.ItemsSource = results;
        }
        private void GameSelection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedPlatform = gameSelection.SelectedItem as string;

            var query = from gd in db.Games
                        where gd.Platform == selectedPlatform || gd.MetricScore == 88
                        select gd;

            var results = query.ToList();
 
            lbxGames.ItemsSource = results;
        }

        private void LbxGames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Game selectedGame = lbxGames.SelectedItem as Game;

            if (selectedGame != null)
            {
                gameImage.Source = new BitmapImage(new Uri(selectedGame.GameImage, UriKind.Relative));
                tblkDescription.Text = selectedGame.Description + " With an average score of " + selectedGame.MetricScore;
                tblkPrice.Text = "€" + selectedGame.Price.ToString();
            }
        }
    }
}
