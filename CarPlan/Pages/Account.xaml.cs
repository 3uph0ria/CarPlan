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

            var cars = CarPlanEntities.GetContext().Cars.ToList();
            cars = cars.Where(p => Convert.ToString(p.IdUser).Contains(Convert.ToString(CurrentUser.Id))).ToList();
            StringBuilder alerts = new StringBuilder();

            foreach(var car in cars)
            {
                var events = CarPlanEntities.GetContext().Events.ToList();
                events = events.Where(p => Convert.ToString(p.IdCar).Contains(Convert.ToString(car.Id))).ToList();
                events = events.Where(p => Convert.ToString(p.IdType).Contains(Convert.ToString(2))).ToList();
                var eventTmp = events.LastOrDefault();

               

                if (eventTmp != null)
                {
                    var result = (DateTime.Now - Convert.ToDateTime(eventTmp.Date)).Duration();


                    if (result.Days >= 30)
                    {
                        alerts.AppendLine("Автомобилю (марка - " + car.Mark + ", модель - " + car.Model + ", год выпуска - " + car.YearRelease + ") необходимо выполнуть ТО. Последние ТО было сделано: " + result.Days + " дней назад" + "(" + eventTmp.Date + ")");
                    }

                }
                else
                {
                    alerts.AppendLine("Автомобилю (марка - " + car.Mark + ", модель - " + car.Model + ", год выпуска - " + car.YearRelease + ") необходимо указать дату последнего ТО.");
                }
            }
 
            if(alerts.Length > 1)
            {
                MessageBox.Show(alerts + "");
            }

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

        private void BtnAdwerts_Click(object sender, RoutedEventArgs e)
        {
            var users = CarPlanEntities.GetContext().Users.ToList();
            users = users.Where(p => Convert.ToString(p.Id).Contains(Convert.ToString(CurrentUser.Id))).ToList();
            var user = users.LastOrDefault();

            if (user.IdPremission == 3)
            {
                NavManager.MainFrame.Navigate(new PageAdwerts());
                
            }
            else
            {
                MessageBox.Show("Для просмотря яобъявление нужен бизнес аккаунт");
                NavManager.MainFrame.Navigate(new PageBusiness());
            }
        }
    }
}
