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
using Microsoft.Win32;

namespace Submission_of_Applications_Kazakov.Pages
{
    /// <summary>
    /// Логика взаимодействия для Education.xaml
    /// </summary>
    public partial class Education : Page
    {
        public Education()
        {
            InitializeComponent();
        }

        private void NextButton(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Status());
        }

        private void BrowsePassport_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                dialog.ShowDialog();
            }
        }
    }
}
