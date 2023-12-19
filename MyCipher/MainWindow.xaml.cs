using System.Windows;
using System.Windows.Controls;

namespace MyCipher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private CipheringService _cs { get; set; } = new CipheringService();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void algorithm_Changed(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (ComboBox_Layout != null)
                ComboBox_Layout.SelectedIndex = 0;
            
            if (comboBox.SelectedIndex == 1)
            {
                ComboBox_Layout.Visibility = Visibility.Visible;
                _cs.SetAlgorithm(new D123());

                if (TextBox_IO.Text == "")
                    TextBox_IO.Text = "Warning: using characters \"!)@(#*\" is not recommended and may cause errors";
            }
            else if (comboBox.SelectedIndex == 2)
            {
                ComboBox_Layout.Visibility = Visibility.Hidden;
                _cs.SetAlgorithm(new NUM2());
            }
            else if (comboBox.SelectedIndex == 3)
            {
                ComboBox_Layout.Visibility = Visibility.Visible;
                _cs.SetAlgorithm(new CHA());
            }
            else
            {
                if(ComboBox_Layout != null)
                    ComboBox_Layout.Visibility = Visibility.Hidden;
                _cs = new CipheringService();
            }
        }

        private void layout_Changed(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (TextBox_IO.Text == "Choose layout" || TextBox_IO.Text == "Warning: using characters \"!)@(#*\" is not recommended and may cause errors")
                TextBox_IO.Text = "";
            
            if (_cs.CipheringAlgorithm is ILayoutSelectible)
            {
                var alg = (ILayoutSelectible)_cs.CipheringAlgorithm;

                if (comboBox.SelectedIndex == 1)
                {
                    alg.SetLayout("lat");
                }

                if (comboBox.SelectedIndex == 2)
                {
                    alg.SetLayout("cyr");
                }
            }
        }

        private void encrypt(object sender, RoutedEventArgs e)
        {
            if (_cs != null && _cs.CipheringAlgorithm != null && TextBox_IO.Text != "")
            {
                string encrypted = _cs.Encrypt(TextBox_IO.Text);
                TextBox_IO.Text = encrypted;
            }
        }

        private void decrypt(object sender, RoutedEventArgs e)
        {
            if (_cs != null && _cs.CipheringAlgorithm != null && TextBox_IO.Text != "")
            {
                string decrypted = _cs.Decrypt(TextBox_IO.Text);
                TextBox_IO.Text = decrypted;
            }
        }

        private void clear_TextBox(object sender, RoutedEventArgs e)
        {
            TextBox_IO.Text = "";
        }
    }
}