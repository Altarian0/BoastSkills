﻿using BoatSkills.Database;
using BoatSkills.Forms;
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

namespace BoatSkills.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void AuthButton_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            try
            {
                user = DataHelper.GetContext().User.Where(n => n.Login == LoginText.Text && n.Password == PasswordText.Text).Single();
                NavigationService.Navigate(new AdministratorPage(user));
            }
            catch
            {
                MessageBox.Show("Неверные логин или пароль!");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
