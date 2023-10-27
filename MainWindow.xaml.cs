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

namespace CINEMA
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Reg(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLog.Text.Trim();
            string password = TextBoxPass.Password.Trim();
            string email = TextBoxEmail.Text.Trim();
            if (login.Length < 5)
            {
                TextBoxLog.ToolTip = "Поле введено не корректно(";
            }
            else if (password.Length < 5)
            {
                TextBoxPass.ToolTip = "Поле введено не корректно(";
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                TextBoxEmail.ToolTip = "Поле введено не корректно(";
            }
            else
            {
                MessageBox.Show("всё ОК");

            }

        }

        private void Button_Enter(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
