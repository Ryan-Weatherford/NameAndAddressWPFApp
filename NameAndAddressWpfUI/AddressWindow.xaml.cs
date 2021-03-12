using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NameAndAddressLibrary;

namespace NameAndAddressWpfUI
{
    /// <summary>
    /// Interaction logic for AddressWindow.xaml
    /// </summary>
    /// 
    public partial class AddressWindow : Window
    {
        MainWindow _window = new MainWindow();
        PersonModel _person = new PersonModel();

        public AddressWindow(MainWindow window, PersonModel person)
        {
            InitializeComponent();
            _window = window;
            _person = person;
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            _person.Address.Street = tBStreet.Text;
            _person.Address.City = tBCity.Text;
            _person.Address.State = tBState.Text;
            _person.Address.ZipCode = tBZipCode.Text;
            _window.peopleList.Add(_person);
            _window.Activate();
            _window.tBFirstName.Text = "";
            _window.tBLastName.Text = "";
            this.Close();
        }
    }
}
