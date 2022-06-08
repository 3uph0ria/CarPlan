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
    /// Логика взаимодействия для PageAddEditCars.xaml
    /// </summary>
    public partial class PageAddEditCars : Page
    {
        private Cars _ccurrnetClients = new Cars();
        public PageAddEditCars(Cars selectClient)
        {
            InitializeComponent();
            if (selectClient != null)
            {
                _ccurrnetClients = selectClient;
            }

            DataContext = _ccurrnetClients;
        }

        private void BtnAddservice_Click(object sender, RoutedEventArgs e)
        {
            _ccurrnetClients.IdUser = CurrentUser.Id;
            

            try
            {
                if (_ccurrnetClients.Id == 0)
                    CarPlanEntities.GetContext().Cars.Add(_ccurrnetClients);

                CarPlanEntities.GetContext().SaveChanges();
                MessageBox.Show("Авто успешно сохранено");
                NavManager.MainFrame.Navigate(new Account());
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
            NavManager.MainFrame.Navigate(new Account());
        }
    }
}
