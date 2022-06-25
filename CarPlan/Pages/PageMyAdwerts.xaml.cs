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
    /// Логика взаимодействия для PageMyAdwerts.xaml
    /// </summary>
    public partial class PageMyAdwerts : Page
    {
        public PageMyAdwerts()
        {
            InitializeComponent();
            Update();
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            Update();
        }

        public void Update()
        {
            var services = CarPlanEntities.GetContext().Adverts.ToList();
            services = services.Where(p => p.Name.ToLower().Contains(Search.Text.ToLower())).ToList();
            services = services.Where(p => Convert.ToString(p.Users.Id).Contains(Convert.ToString(CurrentUser.Id))).ToList();
            ListServices.ItemsSource = services;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new Account());
        }

        private void BtnAddCar_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new PageAddEditAdwerts(null));
        }
    }
}
