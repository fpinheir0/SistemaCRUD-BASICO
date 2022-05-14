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

namespace WpfApp1
{
    /// <summary>
    /// Lógica interna para EditaProduto.xaml
    /// </summary>
    public partial class EditaProduto : Window
    {
        public EditaProduto()
        {
            InitializeComponent();
        }
        private void okButton_Click(object sender, RoutedEventArgs e) =>
        DialogResult = true;

        private void cancelButton_Click(object sender, RoutedEventArgs e) =>
        DialogResult = false;

        public void btn_adicionar(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
