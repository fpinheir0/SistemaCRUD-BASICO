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

        public void btn_adicionar(object sender, RoutedEventArgs e)
        {
                try
                {
                    produtos produtos = new produtos();
                    produtos.Codigo = tbox_codigo.Text;
                    produtos.Descricao = tbox_descricao.Text;
                    produtos.QTDE = Convert.ToInt16(tbox_qtde.Text);
                    produtos.Marca = tbox_marca.Text;
                    produtos.Modelo = tbox_modelo.Text;

                    produtosDAO produtosDAO = new produtosDAO();
                    produtosDAO.Insert(produtos);

                    MessageBox.Show("Registro inserido no banco com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                    var result = MessageBox.Show("Deseja continuar adicionando registros?", "Continuar", MessageBoxButton.YesNo, MessageBoxImage.Question);

                if (result == MessageBoxResult.No)
                    this.Close();
                else
                    ClearInputs();
                        

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
        }
        private void ClearInputs()
        {
            tbox_codigo.Text = "";
            tbox_descricao.Text = "";
            tbox_qtde.Text = "";
            tbox_marca.Text = "";
            tbox_modelo.Text = "";            
        }
    }
}
