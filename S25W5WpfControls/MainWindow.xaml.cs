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

namespace S25W5WpfControls
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

        private void btnGetHobbies_Click(object sender, RoutedEventArgs e)
        {
            string hobbies = "";

            if (chkSwimming.IsChecked == true)
                hobbies += chkSwimming.Content + "\n";
            if (chkGardening.IsChecked == true)
                hobbies += chkGardening.Content + "\n";
            if (chkGolfing.IsChecked == true)
                hobbies += chkGolfing.Content + "\n";

            lblOutput.Content = hobbies;
        }
    }
}