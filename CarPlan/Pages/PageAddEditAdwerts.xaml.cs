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
    /// Логика взаимодействия для PageAddEditAdwerts.xaml
    /// </summary>
    public partial class PageAddEditAdwerts : Page
    {
        private Adverts _ccurrnetClients = new Adverts();
        public PageAddEditAdwerts(Adverts selectClient)
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

            StringBuilder erros = new StringBuilder();

            long p;
            bool isNumeric = long.TryParse(Phone.Text, out p);

            long c;
            bool isNumeric2 = long.TryParse(Cost.Text, out c);

       

            if (isNumeric == false || isNumeric2 == false)
                erros.AppendLine("В полях 'Цена' и 'Телефон' должны быть тольдцо цифры");
           

            if (erros.Length > 0)
            {
                MessageBox.Show(erros.ToString());
                return;
            }


            try
            {
                if (_ccurrnetClients.Id == 0)
                    CarPlanEntities.GetContext().Adverts.Add(_ccurrnetClients);

                CarPlanEntities.GetContext().SaveChanges();
                MessageBox.Show("Объявление успешно сохранено");
                NavManager.MainFrame.Navigate(new PageMyAdwerts());
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
            NavManager.MainFrame.Navigate(new PageMyAdwerts());
        }
    }
}
