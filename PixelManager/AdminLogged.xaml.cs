using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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

namespace PixelManager
{
    /// <summary>
    /// Логика взаимодействия для AdminLogged.xaml
    /// </summary>
    public partial class AdminLogged : Window
    {
        private static readonly HttpClient client = new HttpClient();

        public AdminLogged()
        {
            InitializeComponent();
        }

        private async void BT_SwitchEnableService_Click(object sender, RoutedEventArgs e)
        {
            string selectedCategory = CB_DisableService.Text;
            if (selectedCategory != string.Empty)
            {
                var responseString = await client.GetStringAsync("https://localhost:44303/api/Category/" + selectedCategory);
                var category = Newtonsoft.Json.JsonConvert.DeserializeObject<Category>(responseString);

                if (category.Title != null)
                {
                    HttpContent changedAvailableCategory = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(category));
                    changedAvailableCategory.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    var result = await client.PutAsync($"https://localhost:44303/api/Category?Title=" + category.Title + "&IsAvailable=" + !category.IsAvailable + "&Id=" + category.Id, changedAvailableCategory);
                    BT_DisableService.Content = !category.IsAvailable ? "Отключить услугу" : "Включить услугу";
                }
            }
        }

        private async void CB_DisableService_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            TextBlock selectedCategory = ((sender as ComboBox).SelectedItem as TextBlock);
            //if (selectedCategory.Text == String.Empty) selectedCategory = "Визитки";
            var responseString = await client.GetStringAsync("https://localhost:44303/api/Category/" + selectedCategory.Text);
            var category = Newtonsoft.Json.JsonConvert.DeserializeObject<Category>(responseString);

            BT_DisableService.Content = category.IsAvailable ? "Отключить услугу" : "Включить услугу";
        }
    }
}
