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
using Excel = Microsoft.Office.Interop.Excel;

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

            var sales = CarPlanEntities.GetContext().Events.ToList();
            sales = sales.Where(p => Convert.ToString(p.IdCar).Contains(Convert.ToString(car))).ToList();
            DGridClients3.ItemsSource = sales;
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
                    MessageBox.Show("Событие успешно удалено");
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
            events = events.Where(p => Convert.ToString(p.IdType).Contains(Convert.ToString(1))).ToList();
            DGridClients1.ItemsSource = events;

            events = CarPlanEntities.GetContext().Events.ToList();
            events = events.Where(p => Convert.ToString(p.IdCar).Contains(Convert.ToString(car))).ToList();
            events = events.Where(p => Convert.ToString(p.IdType).Contains(Convert.ToString(2))).ToList();
            DGridClients2.ItemsSource = events;
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            NavManager.MainFrame.Navigate(new Account());
        }

        private void DateStart_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Update2();
        }

        private void DateEnd_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            Update2();
        }

        public void Update2()
        {
            if (String.IsNullOrEmpty(DateStart.Text) == false && String.IsNullOrEmpty(DateEnd.Text) == false)
            {
                var sales = CarPlanEntities.GetContext().Events.ToList();
                sales = sales.Where(p => Convert.ToString(p.IdCar).Contains(Convert.ToString(car))).ToList();

                sales = sales.Where(p => p.Date > Convert.ToDateTime(DateStart.Text)).ToList();
                sales = sales.Where(p => p.Date < Convert.ToDateTime(DateEnd.Text)).ToList();
                DGridClients3.ItemsSource = sales;
            }

        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {

            if (String.IsNullOrEmpty(DateStart.Text) == true || String.IsNullOrEmpty(DateEnd.Text) == true)
            {
                MessageBox.Show("Укажите период для формирования отчета");
                return;
            }

            var application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Add();

            var sales = CarPlanEntities.GetContext().Events.ToList();
            sales = sales.Where(p => Convert.ToString(p.IdCar).Contains(Convert.ToString(car))).ToList();

            sales = sales.Where(p => p.Date > Convert.ToDateTime(DateStart.Text)).ToList();
            sales = sales.Where(p => p.Date < Convert.ToDateTime(DateEnd.Text)).ToList();

            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            worksheet.Name = "Отчет по событиям";

            Excel.Range headerRange = worksheet.Range[worksheet.Cells[1][1], worksheet.Cells[5][1]];
            headerRange.Merge();

            headerRange.Value = "Отчет по событиям (c " + DateStart.Text + " по " + DateEnd.Text + ")";

            headerRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            headerRange.Font.Italic = true;

            worksheet.Cells[1][2] = "Тип события";
            worksheet.Cells[2][2] = "Дата";
            worksheet.Cells[3][2] = "Пробег";
            worksheet.Cells[4][2] = "Цена";
            worksheet.Cells[5][2] = "Комментарий";


            int row = 3;
            foreach (var sale in sales)
            {
                worksheet.Cells[1][row] = sale.TypeEvents.Name;
                worksheet.Cells[2][row] = sale.Date;
                worksheet.Cells[3][row] = sale.Distance;
                worksheet.Cells[4][row] = sale.Cost;
                worksheet.Cells[5][row] = sale.Comment;

                row++;
            }

            application.Visible = true;
        }
    }
}
