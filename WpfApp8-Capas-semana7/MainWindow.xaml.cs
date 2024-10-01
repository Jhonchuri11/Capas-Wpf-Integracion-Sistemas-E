using Bussnes;
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

namespace WpfApp8_Capas_semana7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        // creamos un objeto global de BProducto
        BProduct productBussines = new BProduct();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_listProduct(object sender, RoutedEventArgs e)
        {
            try
            {
                listProduct.ItemsSource = productBussines.listProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed get product");
                throw;
            }
        }
    }
}