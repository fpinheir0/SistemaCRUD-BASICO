using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
{
    public class MainWindowVM
    {
        public ObservableCollection<produtos> ListaProdutos { get; set; }

        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public int QTDE { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }

        //================================================================================================
        public RelayCommand Adicionar { get; private set; }
        public RelayCommand Remover { get; private set; }
        public RelayCommand Editar { get; private set; }
        public produtos UsuarioSelecionado { get; set; } 
        
        public MainWindowVM()
        {
            ListaProdutos = new ObservableCollection<produtos>()
            {
                new produtos()
                {
                   Codigo = "T-01",
                   Descricao = "Trator Pequeno",
                   QTDE = 10,
                   Marca = "john Deere",
                   Modelo = "AAGC101"
                }
            };
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
            Editar = new RelayCommand((object _) =>
            {
                EditaProduto tela = new EditaProduto();
                tela.DataContext = UsuarioSelecionado;
                tela.ShowDialog();
            }
            );
            //===========================================================================
            Remover = new RelayCommand((object _) =>
            {
                ListaProdutos.Remove(UsuarioSelecionado);
            });
            //===========================================================================
        }
    }

}
