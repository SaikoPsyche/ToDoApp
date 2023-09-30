using System;
using System.Collections.Generic;
using System.IO;
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

namespace ToDoApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Color _white = new Color();
        Color _black = new Color();

        ListEntry _toDoListEntry = new ListEntry();


        public MainWindow()
        {
            InitializeComponent();
            UpdateLabel();

            _white = Color.FromRgb(255, 255, 255);
            _black = Color.FromRgb(0, 0, 0);

            CompleteTDLEntry();
        }

        // Sets the date on the label.
        private void UpdateLabel()
        {
            DateTime date = DateTime.Now;
            ToDoListLabel.Content = "To Do List: " + date;
        }

        // Stores user data in a list then adds check boxes cannects data to ListEntry class.
        private void AddToListButton_Click(object sender, RoutedEventArgs e)
        {

            if (ToDoInput != null )
            {

                _toDoListEntry.Entry = ToDoInput.Text;

                ListEntry.ToDoList.Add(_toDoListEntry); // List Entries not displaying on app
                ToDoListLV.Items.Add(_toDoListEntry.Entry);

                ToDoInput.Text = null;
                ToDoInput.Focus();
            }
        }

        private void CompleteTDLEntry()
        {
            ToDoListLV.SelectionMode = SelectionMode.Multiple;
            ToDoListLV.SelectedItem = _toDoListEntry.Completed;
        }

        private void SaveToDoList_Click()
        {
            string tdlFilePath = "C:\\Users\\dougl\\Documents\\Misc\\toDoListSaveFile";
            File.WriteAllLines(tdlFilePath, _toDoListEntry.SaveList);
        }

        // Changes button color when the mouse enters the button.
        private void AddToListButton_MouseEnter(object sender, MouseEventArgs e)
        {
            AddToListButton.Background = new SolidColorBrush(_white);
            AddToListButton.Foreground = new SolidColorBrush(_black);
        }

        //Changes button color back to default when then mouse lases rthe button.
        private void AddToListButton_MouseLeave(object sender, MouseEventArgs e)
        {
            AddToListButton.Background = new SolidColorBrush(_black);
            AddToListButton.Foreground = new SolidColorBrush(_white);
        }
    }
}
