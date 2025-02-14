using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; //para ter acesso ao MessageBox
using MySql.Data.MySqlClient;//Para trabalhar com as classes de conexão com o banco dados Mysql
using AppExemploCadastro.Models;
using System.Reflection; //Para ter acesso as classes dentro da pasta Models

namespace AppExemploCadastro.Contexto
{
    public class PessoaContext
    {
        private string dados_conexao;
        private MySqlConnection conexao = null;

        //método construtor para carregar as informações dentro do objeto "conexao" para  conectar com o banco Mysql
        public PessoaContext()
        {
            dados_conexao = "server=localhost;port=3360;database=bd_pessoa;user=root;password=root;Persist Security Info=False;Connect Timeout=300;";
            conexao = new MySqlConnection(dados_conexao);//conexão preparada => objeto criado e pronto para conectar ao banco
        }//fim do método construtor

        public List<Pessoa> ListarPessoas()
        {
            List<Pessoa> listaPessoaParaExportar = new List<Pessoa>();// para retornar (return) o resutaldo e ser utilizado na aplicação 
            string sql = "SELECT * FROM PESSOA"; //consulta SQL para trazer todas as pessoas
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);//objeto "comando" responsável por ir até o banco e realizar ações

                conexao.Open();//abrir a porta do banco para realizar a consulta

                MySqlDataReader dados = comando.ExecuteReader(); //"comando" vai realizar a consulta e enviar tudo para dentro do objeto "dados"

                //laço responsável por percorrer todos os registros que estão dentro do objeto "dados". 
                while (dados.Read())
                {
                    Pessoa pessoa = new Pessoa();
                    pessoa.Id = Convert.ToInt32(dados["Id"]);
                    pessoa.Nome = dados["Nome"].ToString();
                    pessoa.Cpf = dados["Cpf"].ToString();
                    pessoa.RegistroGeral = dados["RegistroGeral"].ToString();
                    pessoa.Email = dados["Email"].ToString();
                    listaPessoaParaExportar.Add(pessoa);
                }
                conexao.Close(); // Fechar a porta do banco após  resultado da consulta

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);

            }
            return listaPessoaParaExportar; //retornar o resultado (exportar para aplicação) 

        }//fim do método para consultar e listar  Pessoas (ListarPessoas)

        public void InserirPessoa(Pessoa pessoa)
        {
            string sql = "INSERT INTO PESSOA (Nome, Cpf, RegistroGeral,Email) VALUES (@Nome, @Cpf, @RegistroGeral,@Email)"; //para inserir uma pessoa no banco
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                comando.Parameters.AddWithValue("@RegistroGeral", pessoa.RegistroGeral);
                comando.Parameters.AddWithValue("@Email", pessoa.Email);

                conexao.Open(); // Abrir as portas do banco
                int linhasAfestadas = comando.ExecuteNonQuery(); //executa o comando e mostrar quantas linhas foram afetadas
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir veículo: " + ex.Message);

            }
            finally
            {
                conexao.Close(); // Fecha as portas do banco, mesmo que ocorra erro
            }
        }// fim do método para Inserir pessoas

        public void AtualizarPessoa(Pessoa pessoa)
        {
            // Comando SQL para atualizar os dados da pessoa
            string sql = "UPDATE PESSOA SET Nome = @Nome, Cpf = @Cpf, RegistroGeral = @RegistroGeral, Email = @Email WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                comando.Parameters.AddWithValue("@RegistroGeral", pessoa.RegistroGeral);
                comando.Parameters.AddWithValue("@Email", pessoa.Email);
                comando.Parameters.AddWithValue("@Id", pessoa.Id); // Identifica qual registro será atualizado

                conexao.Open(); // Abrir conexão com o banco
                int linhasAfetadas = comando.ExecuteNonQuery(); // Executa o comando e retorna quantas linhas foram alteradas

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Pessoa atualizada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi atualizado. Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar pessoa: " + ex.Message);
            }
            finally
            {
                conexao.Close(); // Fecha a conexão com o banco
            }

        } //fim do Atualizar Pessoa

        public void DeletarPessoa(Pessoa pessoa)
        {
            string sql = "DELETE FROM PESSOA WHERE Id = @Id";

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexao);

                // Adicionando parâmetros para evitar SQL Injection
                comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@Cpf", pessoa.Cpf);
                comando.Parameters.AddWithValue("@RegistroGeral", pessoa.RegistroGeral);
                comando.Parameters.AddWithValue("@Email", pessoa.Email);
                comando.Parameters.AddWithValue("@Id", pessoa.Id); 


                conexao.Open(); // Abrir conexão com o banco
                int linhasAfetadas = comando.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {
                    MessageBox.Show("Pessoa deletada com sucesso!");
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi deletado.Verifique o ID informado.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar pessoa: " + ex.Message);
            }
            finally
            {
                conexao.Close(); // Fecha a conexão com o banco
            }

        }//fim  da classe
    }

} //fim do nameSpace








