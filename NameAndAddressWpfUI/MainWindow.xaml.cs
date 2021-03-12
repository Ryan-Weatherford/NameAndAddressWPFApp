using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using NameAndAddressLibrary;

namespace NameAndAddressWpfUI
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGridOurPeople.ItemsSource = peopleList;
        }

        public BindingList<PersonModel> peopleList = new BindingList<PersonModel>();

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new PersonModel()
            {
                FirstName = tBFirstName.Text,
                LastName = tBLastName.Text
            };

            AddressWindow addressWindow = new AddressWindow(this, person);
            addressWindow.Show();
            addressWindow.Activate();
        }
    }
}
