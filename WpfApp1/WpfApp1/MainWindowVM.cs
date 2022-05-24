using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp1;
using WpfApp1.Banco;

namespace mainVM
{
    public class MainWindowVM
    {

        //================================================================================================
        public ObservableCollection<produtos> ListaProdutos { get; set; }

 
        //================================================================================================
        //GET E SET DOS MEUS CAMPOS

/*      public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int QTDE { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
*/

        //================================================================================================
        //BOTÕES REFERENCIAS
        public RelayCommand Adicionar { get; private set; }
        public RelayCommand Remover { get; private set; }
        public RelayCommand Editar { get; private set; }
        public produtos UsuarioSelecionado { get; set; }

    //================================================================================================
    public MainWindowVM()
        {
            //conexao com Banco de Dados(tratamento de erros)
            try
            {
                var conexao = new conexao(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //conexao com Banco de Dados (tratamento de erros)
            //================================================================================================

            ListaProdutos = new ObservableCollection<produtos>();
            IniciaComandos();
        }

    public void IniciaComandos()
        {
                //===========================================================================

            Adicionar = new RelayCommand( (object _) =>
            {
                produtos ProdCadastro = new produtos(); 
                
                EditaProduto tela = new EditaProduto();
                tela.DataContext = ProdCadastro;
                tela.ShowDialog();

                ListaProdutos.Add(ProdCadastro);
            }
            );

            //===========================================================================

            //VERIFICAR O BOTAO UPDATE POIS NÃO ESTA FUNCIONAL
            Editar = new RelayCommand((object _) =>
            {
                if (UsuarioSelecionado == null)
                   throw new Exception ("por favor selcione um produto para editar!");
                try
                {
                    var produtoSelecionado = UsuarioSelecionado;

                    var dao = new produtosDAO();
                    var produto = dao.GetById(produtoSelecionado.Codigo);

                    EditaProduto tela = new EditaProduto();
                    tela.DataContext = UsuarioSelecionado;
                    tela.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro!!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }
            );

            //===========================================================================

            Remover = new RelayCommand((object _) =>
            {
                if (UsuarioSelecionado == null)
                {
                    MessageBox.Show("Por favor selecione um produto para deletar!");
                }else
                {
                    var produtoSelecionado = UsuarioSelecionado;
  
                    var result = MessageBox.Show($"Deseja realmente deletar o produto ? `{produtoSelecionado.Descricao}` ?", "Confirmação de Remoção",
                                 MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    try
                    {
                        if (result == MessageBoxResult.Yes)
                        {
                            var dao = new produtosDAO();
                            dao.Delete(produtoSelecionado);
                            /*LoadDataGrid();*/
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erro!!", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            });
            //===========================================================================
        }
    }

}
