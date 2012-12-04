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

        //Adds a Person to the address book, attributes read from text boxes. 
        //Updates listview, clears text from text boxes. 
        private void AddPersonClick(object sender, RoutedEventArgs e)
        {
            listView1.Items.Clear();
            string name = inputText.Text;
            string addr = textBox2.Text;
            string state = textBox3.Text;
            string zip = textBox4.Text;
            string num = textBox5.Text;
            Person newUser = new Person(name, addr, state, zip, num); 
            
            Users.Add(newUser); 
            book.AddUser(newUser);
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

        //Removes Person currently selected in list view. 
        private void RemovePersonClick(object sender, RoutedEventArgs e)
        {
            if (book.Users.Count()>0 && listView1.SelectedIndex>=0)
            {
                book.Users.RemoveAt(listView1.SelectedIndex);
                Users.RemoveAt(listView1.SelectedIndex);
                listView1.Items.Clear();
                foreach (Person User in book.Users)
                {
                    listView1.Items.Add(User.name);
                }
            }
        }

        //Edits a Person's attributes, new attributes read from text boxes. 
        //Updates listview, clears text boxes. 
        private void Button3Click(object sender, RoutedEventArgs e)
        {
            if (book.Users.Count() > 0 && listView1.SelectedIndex >=0)
            {
                string newName = inputText.Text;
                string newAddr = textBox2.Text;
                string newSt = textBox3.Text;
                string newZip = textBox4.Text;
                string newNum = textBox5.Text;
                book.EditUser(book.Users[listView1.SelectedIndex], newName, newAddr, newSt, newZip, newNum);
                inputText.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        //Sorts users by name in both the AddressBooks list, and in listview. 
        private void Button2Click1(object sender, RoutedEventArgs e)
        {
            listView1.Items.Clear();
            List<Person> temp = new List<Person>(book.Users);
            book.SortByName();
            foreach (Person User in temp.OrderBy(x=>x.name).ToList())
            {
                listView1.Items.Add(User.name);
            }
        }

        //Sorts users by name in both the AddressBooks list, and in listview. 
        //Also shows each Person's Zip to right of name in listview. 
        private void Button1Click1(object sender, RoutedEventArgs e)
        {
            listView1.Items.Clear();
            List<Person> temp = new List<Person>(book.Users);
            book.SortByZip();
            foreach (Person User in temp.OrderBy(x=>x.zip).ToList())
            {
                listView1.Items.Add(User.name+"          "+User.zip);
            }            
        }

        //When a Person is selected in list view, displays their current information in text boxes. 
        private void ListView1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (book.Users.Count() > 0 && listView1.SelectedIndex >= 0)
            {
                inputText.Text = book.Users[listView1.SelectedIndex].name;
                textBox2.Text = book.Users[listView1.SelectedIndex].addr;
                textBox3.Text = book.Users[listView1.SelectedIndex].state;
                textBox4.Text = book.Users[listView1.SelectedIndex].zip;
                textBox5.Text = book.Users[listView1.SelectedIndex].num;
            }
        }
    }
}