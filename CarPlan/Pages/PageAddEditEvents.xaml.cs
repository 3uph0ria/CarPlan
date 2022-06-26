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
            CBComment.Text = "Заправка";
            Comment.Visibility = Visibility.Hidden;
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
            StringBuilder erros = new StringBuilder();

            long p;
            bool isNumeric = long.TryParse(Distance.Text, out p);

            long c;
            bool isNumeric2 = long.TryParse(Cost.Text, out c);



            if (isNumeric == false || isNumeric2 == false)
                erros.AppendLine("В полях 'Цена' и 'Дистанция' должны быть тольдцо цифры");

            if (erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
                return;
            }

            _ccurrnetClients.IdCar = CurrentUser.IdCar;
            TypeEvents o = (TypeEvents)CBoxEvents.SelectedItem;
            _ccurrnetClients.IdType = o.Id;
            _ccurrnetClients.Comment = CBComment.Text;

            if (_ccurrnetClients.Id == 0)
            {
                _ccurrnetClients.Date = DateTime.Now;
                CarPlanEntities.GetContext().Events.Add(_ccurrnetClients);
            }

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

        private void CBoxEvents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(CBoxEvents.SelectedIndex == 1)
            {
                Comment.Visibility = Visibility.Visible;
            }
            else
            {
                Comment.Visibility = Visibility.Hidden;
            }
        }
    }
}
