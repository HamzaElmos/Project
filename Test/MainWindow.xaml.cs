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

namespace Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {

            using (Context ctx = new Context())
            {

                ctx.LoginData.Add(new LoginData()
                {
                    Profile = cbProfile.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text

                }
               
                    );
                ctx.SaveChanges();
            }

            //MessageBox.Show($"{txtUsername.Text} is added to list");
            txtUsername.Clear();
            txtPassword.Clear();

            switch (cbProfile.Text)
            {
                case "Administrator":
                    Verkoper verkoper = new Verkoper();
                    verkoper.Show();
                    this.Close();
                    break;

                case "Verkoper":
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Close();
                    break;

            }

            // MainWindow dashboard = new MainWindow();
            //dashboard.Show();
            //this.Close(); 
        }

    }
}
