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
using ClassLibrary;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        showsModel shows;

        public MainWindow()
        {
            InitializeComponent();
            ApiHelper.InitializeClient();
        }



        private async void loadshows_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (input_title.Text == "")
                {
                    throw new NoInputTitleException("Enter title");
                }
                else
                {

                    shows = await showsProcessor.Loadshows(input_title.Text);
                }
            }
            catch (NoInputTitleException ex) { MessageBox.Show(ex.Message); }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an error:\n{ex.Message}");
            }

            loadshows();
        }

        public void loadshows()
        {
            shows_name.Text = shows.Name;
            shows_summary.Text = StringFilter.FormatString(shows.Summary);
            shows_genres.Text = String.Join(", ", shows.Genres);
            shows_type.Text = shows.Type;
            shows_status.Text = shows.Status;
            shows_rating.Text = $"{shows.Rating.Average}";
            shows_site.Text = shows.OfficialSite;
            shows_network.Text = shows.Network.Name;
            

            BitmapImage pic = new BitmapImage();
            pic.BeginInit();
            pic.UriSource = new Uri(shows.Image.Original, UriKind.Absolute);
            pic.EndInit();
            shows_image.Source = pic;

            background_image.Source = pic;

            list_seasons.ItemsSource = shows.Seasons;
        }

        private void seasons_mouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            SeasonModel season = list_seasons.SelectedItem as SeasonModel;
            list_episodes.ItemsSource = season.Episodes;
            list_episodes.Items.Refresh();

        }

        public void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            tbox.Text = string.Empty;
            tbox.GotFocus -= TextBox_GotFocus;
            label_name.Content = string.Empty;
        }

        private void hyperlink_requestNavigate(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Uri.AbsoluteUri);
        }
    }
}