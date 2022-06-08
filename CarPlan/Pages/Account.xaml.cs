using vcids.Classes;
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
using vcids.Models;

namespace vcids.Pages
{
    /// <summary>
    /// Логика взаимодействия для Account.xaml
    /// </summary>
    public partial class Account : Page
    {
        public Account()
        {
            InitializeComponent();
            Update();
        }

        private void BtnEvent_Click(object sender, RoutedEventArgs e)
        {
            var car = (sender as Button).DataContext as Cars;
            CurrentUser.IdCar = car.Id;
            NavManager.MainFrame.Navigate(new PageEvents(car.Id));
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageAddEditCars((sender as Button).DataContext as Cars));
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var car = (sender as Button).DataContext as Cars;

            if(MessageBox.Show("Вы дейстивительно хотите удалить авто " + car.Mark, "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    CarPlanEntities.GetContext().Cars.Remove(car);
                    CarPlanEntities.GetContext().SaveChanges();
                    MessageBox.Show("Авто успешно удалено");
                    NavManager.MainFrame.Navigate(new Account());
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void BtnAddCar_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageAddEditCars(null));
        }

        public void Update()
        {
            var cars = CarPlanEntities.GetContext().Cars.ToList();
            cars = cars.Where(p => Convert.ToString(p.IdUser).Contains(Convert.ToString(CurrentUser.Id))).ToList();

            if(cars.Count < 0)
            {
                MessageBox.Show("Здравствуйте, вы удачно авторезировались в аккаунте, теперь нужно добавить машину");
            }

            ListServices.ItemsSource = cars;
        }

        private void Business_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageBusiness());
        }
    }
}
