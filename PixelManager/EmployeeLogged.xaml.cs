using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PixelManager
{
    /// <summary>
    /// Логика взаимодействия для EmployeeLogged.xaml
    /// </summary>
    public partial class EmployeeLogged : Window
    {
        private static readonly HttpClient client = new HttpClient();

        public EmployeeLogged()
        {
            InitializeComponent();
            BT_AllOrders.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
        }

        private async void BT_AllOrders_Click(object sender, RoutedEventArgs e)
        {
            client.DefaultRequestHeaders.Accept.TryParseAdd("application/json");
            var responseString = await client.GetStringAsync("https://localhost:44303/api/Order");
            var orders = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(responseString);
            DG_Orders.ItemsSource = orders;
        }

        private async void BT_GetOrderById_Click(object sender, RoutedEventArgs e)
        {
            if (TB_OrderId.Text != String.Empty)
            {
                List<Order> orderById = new List<Order>();
                var responseString = await client.GetStringAsync("https://localhost:44303/order/" + TB_OrderId.Text);
                //var order = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Order>>(responseString);
                var order = Newtonsoft.Json.JsonConvert.DeserializeObject<Order>(responseString);
                orderById.Add(order);
                DG_Orders.ItemsSource = orderById;
            }
            else MessageBox.Show("Укажите номер заказа");
        }

        public async void ChangeData(object sender, DataGridCellEditEndingEventArgs e)
        {
            Order order = e.Row.Item as Order;
            HttpContent updatedOrder = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(order));
            updatedOrder.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            var result = await client.PutAsync($"https://localhost:44303/api/Order?Fio=" + order.Fio + "&PhoneNumber=" + order.PhoneNumber + "&Email=" + order.Email + "&WareName=" + "sss" + "&Details=" + order.Details + "&File=" + order.File + "&WareId=" + order.WareId + "&Id=" + order.Id, updatedOrder);
        }

        private async void BT_AccpeyOrder_Click(object sender, RoutedEventArgs e)
        {
            var currentOrder = DG_Orders.SelectedItem as Order;
            if (currentOrder != null)
            {
                var responseString = await client.GetStringAsync("https://localhost:44303/api/OrderHronology/" + currentOrder.Id);
                var orderHronologyList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderHronology>>(responseString);
                var orderHronology = orderHronologyList[0];

                HttpContent updatedOrderHronology = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(orderHronology));
                updatedOrderHronology.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = await client.PutAsync($"https://localhost:44303/api/OrderHronology?DateCreationOrder=" + orderHronology.DateCreationOrder.ToString("yyyy-MM-ddTHH:mm:ss") + "&DateAcceptionOrder=" + DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss") + " &Production=" + orderHronology.Production + "&isDone=" + orderHronology.isDone + "&IdOrder=" + orderHronology.IdOrder + "&Id=" + orderHronology.Id, updatedOrderHronology);
            }
            else MessageBox.Show("Выберите заказ из таблицы");
        }

        private async void BT_Production_Click(object sender, RoutedEventArgs e)
        {
            var currentOrder = DG_Orders.SelectedItem as Order;
            if (currentOrder != null)
            {
                var responseString = await client.GetStringAsync("https://localhost:44303/api/OrderHronology/" + currentOrder.Id);
                var orderHronologyList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderHronology>>(responseString);
                var orderHronology = orderHronologyList[0];

                HttpContent updatedOrderHronology = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(orderHronology));
                updatedOrderHronology.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = await client.PutAsync($"https://localhost:44303/api/OrderHronology?DateCreationOrder=" + orderHronology.DateCreationOrder.ToString("yyyy-MM-ddTHH:mm:ss") + "&DateAcceptionOrder=" + orderHronology.DateAcceptionOrder.ToString("yyyy-MM-ddTHH:mm:ss") + " &Production=" + !orderHronology.Production + "&isDone=" + orderHronology.isDone + "&IdOrder=" + orderHronology.IdOrder + "&Id=" + orderHronology.Id, updatedOrderHronology);
            }
            else MessageBox.Show("Выберите заказ из таблицы");
        }

        private async void BT_Done_Click(object sender, RoutedEventArgs e)
        {
            var currentOrder = DG_Orders.SelectedItem as Order;
            if (currentOrder != null)
            {
                var responseString = await client.GetStringAsync("https://localhost:44303/api/OrderHronology/" + currentOrder.Id);
                var orderHronologyList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderHronology>>(responseString);
                var orderHronology = orderHronologyList[0];

                HttpContent updatedOrderHronology = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(orderHronology));
                updatedOrderHronology.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = await client.PutAsync($"https://localhost:44303/api/OrderHronology?DateCreationOrder=" + orderHronology.DateCreationOrder.ToString("yyyy-MM-ddTHH:mm:ss") + "&DateAcceptionOrder=" + orderHronology.DateAcceptionOrder.ToString("yyyy-MM-ddTHH:mm:ss") + " &Production=" + orderHronology.Production + "&isDone=" + !orderHronology.isDone + "&IdOrder=" + orderHronology.IdOrder + "&Id=" + orderHronology.Id, updatedOrderHronology);
            }
            else MessageBox.Show("Выберите заказ из таблицы");
        }

        private async void BT_Remove_Click(object sender, RoutedEventArgs e)
        {
            var currentOrder = DG_Orders.SelectedItem as Order;
            if (currentOrder != null)
            {
                var responseString = await client.GetStringAsync("https://localhost:44303/api/OrderHronology/" + currentOrder.Id);
                var orderHronologyList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderHronology>>(responseString);
                var orderHronology = orderHronologyList[0];

                HttpContent removedOrderHronology = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(orderHronology));
                removedOrderHronology.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var res = await client.DeleteAsync("https://localhost:44303/api/Order?id=" + currentOrder.Id);
                var result = await client.DeleteAsync("https://localhost:44303/api/OrderHronology?id=" + orderHronology.Id);
                BT_AllOrders.RaiseEvent(new RoutedEventArgs(ButtonBase.ClickEvent));
            }
            else MessageBox.Show("Выберите заказ из таблицы");
        }

        public void TB_OrderId_RemovePlaceholder(object sender, RoutedEventArgs e)
        {
            TB_OrderId.Foreground = new SolidColorBrush(Colors.Black);
            if (TB_OrderId.Text == "Номер заказа") TB_OrderId.Text = "";
        }

        public void TB_OrderId_SetPlaceholder(object sender, RoutedEventArgs e)
        {
            if (TB_OrderId.Text == "") 
            {
                TB_OrderId.Text = "Номер заказа";
                TB_OrderId.Foreground = new SolidColorBrush(Color.FromArgb(70, 0, 0, 0));
            }
        }

        public async void DG_Orders_GetSelectedItem(object sender, RoutedEventArgs e)
        {
            var selectedOrder = DG_Orders.SelectedItem as Order;
            if (selectedOrder != null)
            {
                var responseString = await client.GetStringAsync("https://localhost:44303/api/OrderHronology/" + selectedOrder.Id);
                var orderHronologyList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<OrderHronology>>(responseString);
                var orderHronology = orderHronologyList[0];
                
                L_SelectedOrder.Content = "Заказ № " + selectedOrder.Id.ToString();

                L_DateCreationOrder.Content = "Дата оформления " + orderHronology.DateCreationOrder.ToString();

                if (orderHronology.DateAcceptionOrder.ToString() == "01.01.0001 0:00:00")
                {
                    L_DateAcceptionOrder.Foreground = new SolidColorBrush(Colors.Red);
                    L_DateAcceptionOrder.Content = "Заказ еще не принят";
                }
                else
                {
                    L_DateAcceptionOrder.Foreground = new SolidColorBrush(Colors.Green);
                    L_DateAcceptionOrder.Content = "Заказ принят " + orderHronology.DateAcceptionOrder.ToString();
                }

                if (!orderHronology.Production)
                {
                    L_Production.Foreground = new SolidColorBrush(Colors.Red);
                    L_Production.Content = "Заказ не выполняется";
                }
                else
                {
                    L_Production.Foreground = new SolidColorBrush(Colors.Green);
                    L_Production.Content = "Заказ выполняется";
                }

                if (!orderHronology.isDone)
                {
                    L_Done.Foreground = new SolidColorBrush(Colors.Red);
                    L_Done.Content = "Заказ не готов";
                }
                else
                {
                    L_Done.Foreground = new SolidColorBrush(Colors.Green);
                    L_Done.Content = "Заказ готов!";
                }
            }
        }

    }
}
