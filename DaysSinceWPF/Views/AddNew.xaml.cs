using DaysSinceWPF.Interfaces;
using DaysSinceWPF.Models;
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
using System.Windows.Shapes;

namespace DaysSinceWPF.Views
{
    /// <summary>
    /// Interaction logic for AddNew.xaml
    /// </summary>
    public partial class AddNew : Window, IAddNew
    {
        private IAddNew _mainwindow;
        public AddNew(IAddNew mainwindow)
        {
            InitializeComponent();
            datepicker.SelectedDate = DateTime.Today;
            _mainwindow = mainwindow;
        }

		void IAddNew.AddNew(Days day)
		{
			throw new NotImplementedException();
		}

        public void CloseWindow()
        {
            Close();
        }

		private void btn_add_Click(object sender, RoutedEventArgs e)
		{
            _mainwindow.AddNew(new Days(title.Text, new DateOnly(datepicker.SelectedDate.Value.Year, datepicker.SelectedDate.Value.Month, datepicker.SelectedDate.Value.Day )));
            CloseWindow();
		}

		private void btn_cancel_Click(object sender, RoutedEventArgs e)
		{
            CloseWindow();
		}
	}
}
