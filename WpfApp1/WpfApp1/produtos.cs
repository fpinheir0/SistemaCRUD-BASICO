using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    public class produtos
    {
        
        private string codigo;
        private string descricao;
        private int qtde;
        private string marca;
        private string modelo;
        private ObservableCollection<produtos> listaProdutos;

        public produtos()
        {

        }

        public produtos(ObservableCollection<produtos> listaProdutos)
        {
            this.listaProdutos = listaProdutos;
        }

        public produtos(string codigo, string descricao, int qtde, string marca, string modelo)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.qtde = qtde;
            this.marca = marca;
            this.modelo = modelo;
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int QTDE
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
    }
}
