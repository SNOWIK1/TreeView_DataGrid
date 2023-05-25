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

namespace TreeView_DataGrid
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void delete_Node(Object sender, RoutedEventArgs e)
        {
            try
            {
                var parent = (TreeViewItem)((TreeViewItem)tree.SelectedItem).Parent;

                if (parent != null)
                {   
                    parent.Items.Remove((TreeViewItem)tree.SelectedItem);
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void open_Grid(Object sender, RoutedEventArgs e)
        {
            dataGrid grid = new dataGrid();
            grid.Show();
        }
    }
}
