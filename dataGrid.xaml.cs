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

namespace TreeView_DataGrid
{
    /// <summary>
    /// Логика взаимодействия для dataGrid.xaml
    /// </summary>
    public partial class dataGrid : Window
    {
        internal class Musician
        {
            public string Name {get; set;}
            public string Album {get; set;}
            public string Year { get; set; }
        }

        List<Musician> musicians = new List <Musician>()
            {
                new Musician { Name = "Michael Jackson", Album = "Thriller", Year = "1982"},
                new Musician { Name = "Brian Johnson", Album = "Back in Black", Year = "1980"},
                new Musician { Name = "Bee Gees", Album = "Saturday Night Fever", Year = "1977"},
                new Musician { Name = "Pink Floyd", Album = "The Dark Side of the Moon", Year = "1973"},
            };

        public dataGrid()
        {
            InitializeComponent();
            table.ItemsSource = musicians;

        }

        private void table_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = table.SelectedIndex;
            Musician person = musicians[index];
            MessageBox.Show($" ID: {index+1} \n Исполнитель: {person.Name} \n Альбом: {person.Album} \n Год: {person.Year}", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void addMusician(object sender, RoutedEventArgs e)
        {
            if (mus_Name.Text == "" || mus_Album.Text == "" || mus_Year.Text == "")
            {
                MessageBox.Show("Заполните все поля, чтобы добавить запись в таблицу!", "Пустые поля", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                musicians.Add(new Musician { Name = mus_Name.Text, Album = mus_Album.Text, Year = mus_Year.Text});
                table.Items.Refresh();
            }
        }
    }
}
