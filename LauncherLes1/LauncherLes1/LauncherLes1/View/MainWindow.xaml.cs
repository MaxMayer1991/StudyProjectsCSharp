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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LauncherLes1.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string opis;
        public MainWindow()
        {
            InitializeComponent();
            //this.Reset();
        }
     /*   public void Reset()
        {
           // opis.Text = String.Empty;


            methods.Items.Clear();
            CheckBox method;
            foreach (string methodName in ringingMethods)
            {
                method = new CheckBox();
                method.Margin = new Thickness(0, 0, 0, 10);
                method.Content = methodName;
                methods.Items.Add(method);
            }
            isCaptain.IsChecked = false;
            novice.IsChecked = true;
            System.Windows.Forms.DateTimePicker memberDate =
                hostMemberSince.Child as System.Windows.Forms.DateTimePicker;
            memberDate.Value = DateTime.Today;

        }*/
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
