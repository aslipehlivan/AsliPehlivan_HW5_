using AsliPehlivan_HW5.Data;
using AsliPehlivan_HW5.Service;
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

namespace AsliPehlivan_HW5
{
    /// <summary>
    /// Interaction logic for ChangePass.xaml
    /// </summary>
    public partial class ChangePass : Window { 
   
        private CetUser loginUser;
        private LibraryDb1 db = new LibraryDb1();
    
        public ChangePass(CetUser cetUser)
        {
            loginUser = cetUser;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CetUserService cetUserService = new CetUserService();

            string tempeskisifre = cetUserService.hashPassword(oldpass.Password.ToString());

            if (tempeskisifre == loginUser.Password)
            {
                string tempyenisifre = cetUserService.hashPassword(newpass.Password.ToString());
                string tempyenisifretekrar = cetUserService.hashPassword(newpassagain.Password.ToString());
                if (tempyenisifre == tempyenisifretekrar)
                {
                    loginUser.Password = tempyenisifre;
                    db.CetUsers.Update(loginUser);
                    db.SaveChangesAsync();
                    MessageBox.Show("Şifreniz başarıyla değiştirildi.");
                }
                else MessageBox.Show("Hatalı Giriş");
            }
            else MessageBox.Show("Hatalı Giriş");
        }
    }
}
