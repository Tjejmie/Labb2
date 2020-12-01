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

namespace Godiskalkylator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            candyCalculator = new CandyCalculator();
            InitializeComponent();
        }
        
        Person person;
        CandyCalculator candyCalculator;
        List<Person> listPeople= new List<Person>();

        private void updateUi()
        {
            lstBoxInfo.ItemsSource = null;
            lstBoxInfo.ItemsSource = candyCalculator.PeopleList;
        }
        private void AddPerson()
        {
            person = new Person();
            {
                person.FirstName = txtBoxFirstName.Text;
                person.LastName = txtBoxLastName.Text;
                person.Age = int.Parse(txtBoxAge.Text);
            }
            candyCalculator.PeopleList.Add(person);
            lstBoxInfo.ItemsSource = listPeople;
            updateUi();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddPerson();
            updateUi();
        }

        private void btnDistribute_Click(object sender, RoutedEventArgs e)
        {
            int candies = int.Parse(txtBoxCandy.Text);
            bool byFirstName = rbtnFirstName.IsChecked.Value;
            bool byLastName = rbtnLastName.IsChecked.Value;
            bool byAge = rbtnAge.IsChecked.Value;

            candyCalculator.DistributeCandy(candies, byFirstName, byLastName, byAge);
            lstBoxInfo.ItemsSource = candyCalculator.PeopleList;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtBoxFirstName.Clear();
            txtBoxLastName.Clear();
            txtBoxAge.Clear();
            txtBoxCandy.Clear();
            txtBoxFirstName.Focus();
            lstBoxInfo.ItemsSource = null;
            candyCalculator.PeopleList.Clear();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string filename = "People.json";
            FileHandler.Save(candyCalculator, filename);
            candyCalculator = FileHandler.Open<CandyCalculator>(filename);
        }
    }
}
