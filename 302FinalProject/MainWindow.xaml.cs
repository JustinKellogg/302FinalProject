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
            listView1.Items.Clear();
            string name = inputText.Text;
            string addr = textBox2.Text;
            string state = textBox3.Text;
            string zip = textBox4.Text;
            string num = textBox5.Text;
            Person newUser = new Person(name, addr, state, zip, num); 
            
            Users.Add(newUser); 
            book.addUser(newUser);
           foreach (Person User in book.Users)
            {
                listView1.Items.Add(User.name);
            }

           
            inputText.Text="";
            textBox2.Text="";
            textBox3.Text="";
            textBox4.Text="";
            textBox5.Text="";
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

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            textBox6.Text = "";
            textBox6.Text = listView1.SelectedValue.ToString() + listView1.SelectedIndex.ToString();
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            listView1.Items.Clear();
            List<Person> temp = new List<Person>(book.Users);
            
            foreach (Person User in temp.OrderBy(x=>x.name).ToList())
            {
                listView1.Items.Add(User.name);
            }
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            listView1.Items.Clear();
            List<Person> temp = new List<Person>(book.Users);
            
            foreach (Person User in temp.OrderBy(x=>x.zip).ToList())
            {
                listView1.Items.Add(User.name+"          "+User.zip);
            }            
        }
    }
}