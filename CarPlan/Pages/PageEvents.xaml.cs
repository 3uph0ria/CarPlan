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
using vcids.Classes;
using vcids.Models;

namespace vcids.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageEvents.xaml
    /// </summary>
    public partial class PageEvents : Page
    {
        public static int car;
        public PageEvents(int IdCar)
        {
            car = IdCar;
            InitializeComponent();
            Update();
        }

        private void BtnEditClient_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageAddEditEvents((sender as Button).DataContext as Events));
        }

        private void BtndelService_Click(object sender, RoutedEventArgs e)
        {
            var car = (sender as Button).DataContext as Events;

            if (MessageBox.Show("Вы дейстивительно хотите удалить событие " + car.TypeEvents.Name + "?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    CarPlanEntities.GetContext().Events.Remove(car);
                    CarPlanEntities.GetContext().SaveChanges();
                    MessageBox.Show("Авто успешно удалено");
                    NavManager.MainFrame.Navigate(new PageEvents(CurrentUser.IdCar));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnAddCar_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageAddEditEvents(null));
        }

        public void Update()
        {
            var events = CarPlanEntities.GetContext().Events.ToList();
            events = events.Where(p => Convert.ToString(p.IdCar).Contains(Convert.ToString(car))).ToList();


            DGridClients.ItemsSource = events;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new Account());
        }
    }
}
