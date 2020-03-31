using BoatSkills.Database;
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
using System.Windows.Shapes;

namespace BoatSkills.Forms
{
    /// <summary>
    /// Логика взаимодействия для RegisterForm.xaml
    /// </summary>
    public partial class RegisterForm : Window
    {
        User currentUser = new User();
        public RegisterForm()
        {
            InitializeComponent();
            DataContext = currentUser;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            { b
                if (DataHelper.GetContext().User.Where(n => n.Login == LoginText.Text).Single() != null)
                {
                    MessageBox.Show("Данный логин уже занят!");
                    return;
                }
            }
            catch
            {

            }

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(currentUser.Login))
                errors.AppendLine("Введите логин пользователя");
            if (string.IsNullOrWhiteSpace(currentUser.Password))
                errors.AppendLine("Введите пароль пользователя");
            if (PasswordText.Text != RepeatPasswordText.Text && PasswordText.Text != "")
                errors.AppendLine("Введенные пароли не совпадают!");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString(), "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            try
            {
                currentUser.RegisterDate = DateTime.Now;
                currentUser.PasswordChangeDate = DateTime.Now;
                DataHelper.GetContext().User.Add(currentUser);
                DataHelper.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            this.Close();
        }
    }
}
