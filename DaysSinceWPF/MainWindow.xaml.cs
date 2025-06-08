using DaysSinceWPF.Interfaces;
using DaysSinceWPF.Models;
using DaysSinceWPF.Views;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DaysSinceWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IAddNew
    {
		
		public MainWindow()
        {
            InitializeComponent();
            AppStart();
        }

		public ObservableCollection<Days> days = new ObservableCollection<Days>();
		public void AppStart()
		{
            AddSampleData();
            days_grid.ItemsSource = days;
		}

        public void AddSampleData()
        {
            days.Add(new Days("Example 1", new DateOnly(2025, 3, 2)));
		}

		public void AddNew(Days day)
		{
            days.Add(day);
		}

		private void btn_addnew_Click(object sender, RoutedEventArgs e)
		{
            AddNew createnew = new AddNew(this);
            createnew.ShowDialog();
		}

		private void btn_delete_Click(object sender, RoutedEventArgs e)
		{
			DataGridRow row = DataGridRow.GetRowContainingElement(sender as Button);
			int index = row.GetIndex();
			days.RemoveAt(index);
		}
	}


}