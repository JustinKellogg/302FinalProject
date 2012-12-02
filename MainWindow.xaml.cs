using System;
using System.Collections.Generic;
using System.Linq;
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
using _302FinalProject;

namespace _302FinalProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Person> Users = new List<Person>();
        AddressBook book = new AddressBook();
        Person User = new Person("Jane Doe", "001 Main Street", "MO", "11111", "456-7890");
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddPerson_Click(object sender, RoutedEventArgs e)
        {
            string name = inputText.Text;
            string addr = textBox2.Text;
            string state = textBox3.Text;
            string zip = textBox4.Text;
            string num = textBox5.Text;
            Person newUser = new Person(name, addr, state, zip, num);
            listView1.Items.Add(newUser.name);
            Users.Add(newUser);
        }

        private void RemovePerson_Click(object sender, RoutedEventArgs e)
        {
            this.inputText.Text = "hope this works";
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}