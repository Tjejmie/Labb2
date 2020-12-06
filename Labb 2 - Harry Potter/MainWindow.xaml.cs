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

namespace Labb_2___Harry_Potter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        Wizard wizard;
        Gryffindor gryffindor;
        Hufflepuff hufflepuff;
        Ravenclaw ravenclaw;
        Slytherin slytherin;
        Hogwarts hogwarts;

        public MainWindow()
        {
            InitializeComponent();
            wizard = new Wizard();
            gryffindor = new Gryffindor();
            hufflepuff = new Hufflepuff();
            ravenclaw = new Ravenclaw();
            slytherin = new Slytherin();
            hogwarts = new Hogwarts();

            //Elevhem i Comboboxen
            cboHouses.Items.Add(hogwarts.Ravenclaw);
            cboHouses.Items.Add(hogwarts.Gryffindor);
            cboHouses.Items.Add(hogwarts.Slytherin);
            cboHouses.Items.Add(hogwarts.Hufflepuff);

            // Mascot ska synas under elevhemslistan
            lblHufflepuffMascot.Content = hogwarts.Hufflepuff.Mascot;
            lblRavenclawMascot.Content = hogwarts.Ravenclaw.Mascot;
            lblGryffindorMascot.Content = hogwarts.Gryffindor.Mascot;
            lblSlytherinMascot.Content = hogwarts.Slytherin.Mascot;
        }

        private void btnChangePassword_Click(object sender, RoutedEventArgs e) //Ändra lösenord
        {

            if (cboHouses.SelectedItem == hogwarts.Gryffindor && txtOldPassword.Text == hogwarts.Gryffindor.Password && hogwarts.Gryffindor.PasswordFormat(txtNewPassword.Text) == true)
            {
                hogwarts.Gryffindor.Password = txtNewPassword.Text;
                MessageBox.Show($"Ditt lösenord är ändrat till: {txtNewPassword.Text}");
            }

            else if (cboHouses.SelectedItem == hogwarts.Hufflepuff && txtOldPassword.Text == hogwarts.Hufflepuff.Password && hogwarts.Hufflepuff.PasswordFormat(txtNewPassword.Text) == true)
            {
                hogwarts.Hufflepuff.Password = txtNewPassword.Text;
                MessageBox.Show($"Ditt lösenord är ändrat till: {txtNewPassword.Text}");
            }

            else if (cboHouses.SelectedItem == hogwarts.Ravenclaw && txtOldPassword.Text == hogwarts.Ravenclaw.Password && hogwarts.Ravenclaw.PasswordFormat(txtNewPassword.Text) == true)
            {
                hogwarts.Ravenclaw.Password = txtNewPassword.Text;
                MessageBox.Show($"Ditt lösenord är ändrat till: {txtNewPassword.Text}");
            }

            else if (cboHouses.SelectedItem == hogwarts.Slytherin && txtOldPassword.Text == hogwarts.Slytherin.Password && hogwarts.Slytherin.PasswordFormat(txtNewPassword.Text) == true)
            {
                hogwarts.Slytherin.Password = txtNewPassword.Text;
                MessageBox.Show($"Ditt lösenord är ändrat till: {txtNewPassword.Text}");
            }

            else
            {
                MessageBox.Show("Antingen är ditt nuvarande lösenord felaktigt eller så uppfyller inte det nya lösenordet kraven. :(");
            }
        }
        
        private void WizardInfo()
        {

            txtName.Text = wizard.NameWizard;
            
            if (wizard.DeathEater == true)
            {
                chkDeatheater.IsChecked = true;
            }

            else
            {
                chkDeatheater.IsChecked = false;
            }

            if (wizard.DumbledoresArmy == true)
            {
                chkArmy.IsChecked = true;
            }
            else
            {
                chkArmy.IsChecked = false;
            }
        }

        private void btnSortingHat_Click(object sender, RoutedEventArgs e)
        {
            Wizard wizard = new Wizard();
            wizard.NameWizard = txtNewWizardName.Text;
            House house = hogwarts.SortingHat(wizard);
            txtName.Text = ($"{wizard}");
            txtNewWizardName.Clear();
            txtNewWizardName.Focus();

            lstHufflepuff.ItemsSource = null;
            lstHufflepuff.ItemsSource = hogwarts.Hufflepuff.Members;
            lstRavenclaw.ItemsSource = null;
            lstRavenclaw.ItemsSource = hogwarts.Ravenclaw.Members;
            lstGryffindor.ItemsSource = null;
            lstGryffindor.ItemsSource = hogwarts.Gryffindor.Members;
            lstSlytherin.ItemsSource = null;
            lstSlytherin.ItemsSource = hogwarts.Slytherin.Members;

            MessageBox.Show($"{wizard.NameWizard} är numera medlem nummer {house.Members.Count} i {house}. Spöket {house.HouseGhost} kommer ta väl hand om dig.");

            if (wizard.DeathEater == true)
            {
                chkDeatheater.IsChecked = true;
            }

            else
            {
                chkDeatheater.IsChecked = false;
            }

            if (wizard.DumbledoresArmy == true)
            {
                chkArmy.IsChecked = true;
            }
            else
            {
                chkArmy.IsChecked = false;
            }
        }


        private void lstHufflepuff_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstHufflepuff.SelectedItem;
            WizardInfo();
        }

        private void lstRavenclaw_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstRavenclaw.SelectedItem;
            WizardInfo();
        }

        private void lstGryffindor_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstGryffindor.SelectedItem;
            WizardInfo();
        }

        private void lstSlytherin_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            wizard = (Wizard)lstSlytherin.SelectedItem;
            WizardInfo();
        }
    }
}
