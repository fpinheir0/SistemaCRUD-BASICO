using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Interfaces;
using WpfApp1.Banco;
using System.Windows;
using MySql.Data.MySqlClient;


namespace WpfApp1
{
    //CLASSE QUE FAZ INTERMEDIO COM MEU BANCO DE DADOS
    class produtosDAO : IBancoIntermediario<produtos>
    {
        private static conexao conexao;

        public produtosDAO()
        {
            conexao = new conexao();
        }

        public void Delete(produtos tipo)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "DELETE FROM tb_produto where id_PRODUTO = @ID";

                query.Parameters.AddWithValue("@ID", tipo.Codigo);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("O Registro não foi removido do Banco de Daods, verifique e tente novamente");

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }

        public produtos GetById(string Codigo)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "SELECT * FROM tb_produto WHERE id_PRODUTO = @ID";

                query.Parameters.AddWithValue("@id", Codigo);

                MySqlDataReader reader = query.ExecuteReader();

                if (!reader.HasRows)
                    throw new Exception("Nenhum registro foi encontrado no Banco!");

                var produto = new produtos();

                while (reader.Read())
                {
                    produto.Codigo = reader.GetString("id_PRODUTO");
                    produto.Descricao = reader.GetString("DESCRICAO");
                    produto.QTDE = reader.GetInt32("QTDE");
                    produto.Marca = reader.GetString("MARCA");
                    produto.Modelo = reader.GetString("MODELO");
                }

                return produto;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Insert(produtos tipo)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "INSERT INTO tb_produto (id_PRODUTO, DESCRICAO, QTDE, MARCA, MODELO)" +
                                    "VALUES (@ID, @DESCRICAO, @QTDE, @MARCA, @MODELO)";

                query.Parameters.AddWithValue("@ID", tipo.Codigo);
                query.Parameters.AddWithValue("@DESCRICAO", tipo.Descricao);
                query.Parameters.AddWithValue("@QTDE", tipo.QTDE);
                query.Parameters.AddWithValue("@MARCA", tipo.Marca);
                query.Parameters.AddWithValue("@MODELO", tipo.Modelo);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("O Registro não foi inserido, verifique e tente novamente");

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<produtos> List()
        {
            try
            {
                List<produtos> lista = new List<produtos>();

                var query = conexao.Query();
                query.CommandText = "SELECT * FROM tb_produto";

                MySqlDataReader reader = query.ExecuteReader();

                while(reader.Read())
                {
                    lista.Add(new produtos()
                    {
                        Codigo = reader.GetString("id_PRODUTO"),
                        Descricao = reader.GetString("DESCRICAO"),
                        QTDE = reader.GetInt32("QTDE"),
                        Marca = reader.GetString("MARCA"),
                        Modelo = reader.GetString("MODELO")
                    });
                }

                return lista;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(produtos tipo)
        {
            try
            {
                var query = conexao.Query();
                query.CommandText = "UPDATE tb_produto SET id_PRODUTO = @ID, DESCRICAO = @DESCRICAO, QTDE = @QTDE, MARCA = @MARCA, MODELO = @MODELO" +
                                    "WHERE id_PRODUTO = @ID";

                query.Parameters.AddWithValue("@ID", tipo.Codigo);
                query.Parameters.AddWithValue("@DESCRICAO", tipo.Descricao);
                query.Parameters.AddWithValue("@QTDE", tipo.QTDE);
                query.Parameters.AddWithValue("@MARCA", tipo.Marca);
                query.Parameters.AddWithValue("@MODELO", tipo.Modelo);

                var result = query.ExecuteNonQuery();

                if (result == 0)
                    throw new Exception("Atualização do Registro falhou!");

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
