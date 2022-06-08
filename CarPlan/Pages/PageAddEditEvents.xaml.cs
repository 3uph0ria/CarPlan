using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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
    /// Логика взаимодействия для PageAddEditEvents.xaml
    /// </summary>
    public partial class PageAddEditEvents : Page
    {
        private Events _ccurrnetClients = new Events();
        public PageAddEditEvents(Events selectClient)
        {
            InitializeComponent();
            if (selectClient != null)
            {
                _ccurrnetClients = selectClient;
                CBoxEvents.SelectedItem = selectClient.TypeEvents;
            }

            DataContext = _ccurrnetClients;

            CBoxEvents.ItemsSource = CarPlanEntities.GetContext().TypeEvents.ToList();
        }

        private void BtnAddservice_Click(object sender, RoutedEventArgs e)
        {
            _ccurrnetClients.IdCar = CurrentUser.IdCar;
            TypeEvents o = (TypeEvents)CBoxEvents.SelectedItem;
            _ccurrnetClients.IdType = o.Id;
            _ccurrnetClients.Date = DateTime.Now;

            if (_ccurrnetClients.Id == 0)
                CarPlanEntities.GetContext().Events.Add(_ccurrnetClients);

            try
            {
                CarPlanEntities.GetContext().SaveChanges();
                MessageBox.Show("Событие успешно сохранено");
                NavManager.MainFrame.Navigate(new PageEvents(_ccurrnetClients.IdCar));
            }
            catch (DbEntityValidationException ex)
            {
                if (ApplicationConfig.IsDev)
                {
                    foreach (var errors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in errors.ValidationErrors)
                        {
                            MessageBox.Show(validationError.ErrorMessage);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Произошла ошибка", "Внимание", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageEvents(CurrentUser.IdCar));
        }
    }
}
