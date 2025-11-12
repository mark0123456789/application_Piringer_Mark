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

namespace application_Piringer_Mark
{
    /// <summary>
    /// Interaction logic for bejelentkezes.xaml
    /// </summary>
    public partial class bejelentkezes : Page
    {
        public bejelentkezes()
        {
            InitializeComponent();
        }
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            string user = txtUsername.Text;
            string pass = txtPassword.Password;

            if (DataBaseMentes.Login(user, pass))
            {
                AdminPage admin = new AdminPage();
                admin.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Hibás felhasználónév vagy jelszó!");
            }
        }
    }
}
