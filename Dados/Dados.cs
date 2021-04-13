using Npgsql;
using System.Collections.Generic;

namespace ModernArt
{
    class Dados
    {
        // Variáveis de configuração do banco, configurem de acordo
        static string servidorNome = "localhost";
        static string porta = "5432";
        static string usuario = "postgres";
        static string senha = "admin";
        static string nomeBanco = "modern_art";

        // Variáveis da configuração do banco juntando as variáveis acima
        string config = $"Server = {servidorNome}; Port = {porta}; Database = {nomeBanco}; User Id = {usuario}; Password = {senha};";


        /// <summary>
        /// Este método inclui novo registro na tabela <b>servicos</b>.
        /// </summary>
        public void InserirServico(string nomeServico, double valorBaseServico)
        {
            // Cria objeto da conexão com o banco de dados e escopo deste objeto
            using (NpgsqlConnection conexao = new NpgsqlConnection(config))
            {
                // Abre conexão com o banco
                conexao.Open();
                string valor = valorBaseServico.ToString(System.Globalization.CultureInfo.InvariantCulture);
                // Declara sentença SQL
                string inserir = "INSERT INTO public.servicos(servico_nome, servico_valor_base) VALUES (@servico_nome, @servico_valor_base);";
                // Cria escopo e objeto do comando SQL utilizando a sentença e a conexão como parâmetros
                using (NpgsqlCommand comando = new NpgsqlCommand(inserir, conexao))
                {
                    // Adiciona os parâmetros ao comando
                    comando.Parameters.AddWithValue("servico_nome", nomeServico);
                    comando.Parameters.AddWithValue("servico_valor_base", valorBaseServico);
                    // Executa o comando SQL no banco de dados
                    comando.ExecuteNonQuery();
                }
                // Fecha conexão com o banco de dados
                conexao.Close();
            }
        }

        /// <summary>
        /// Este método obtém todos os registros da tabela <b>servicos</b>
        /// </summary>
        /// <returns>Uma lista que contém objetos do tipo Servico</returns>
        public List<Servico> GetTodosServicos()
        {
            int id;
            string nome;
            double valorBase;
            Servico servico;
            List<Servico> servicos = new List<Servico>();
            // Cria objeto da conexão com o banco de dados e escopo deste objeto
            using (NpgsqlConnection conexao = new NpgsqlConnection(config))
            {
                // Abre conexão com o banco
                conexao.Open();
                // Declara sentença SQL
                string selecionar = "SELECT * FROM public.servicos ORDER BY id;";
                // Cria escopo e objeto do comando SQL utilizando a sentença e a conexão como parâmetros
                using (NpgsqlCommand comando = new NpgsqlCommand(selecionar, conexao))
                {
                    // Executa query
                    NpgsqlDataReader query = comando.ExecuteReader();
                    // Itera sobre os resultados da query
                    while (query.Read())
                    {
                        // Cria um objeto do tipo Servico com os dados das colunas
                        id = query.GetInt32(0);
                        nome = query.GetString(1).Trim();
                        valorBase = query.GetDouble(2);
                        servico = new Servico(id, nome, valorBase);
                        // Adiciona objeto na lista servicos
                        servicos.Add(servico);
                    }
                }
                // Fecha conexão com o banco de dados
                conexao.Close();
            }
            // Retorna a tabela
            return servicos;
        }

        /// <summary>
        /// Este método obtém um registro da tabela <b>servicos</b> correspondente ao id
        /// </summary>
        /// <returns>Um objeto do tipo Servico</returns>
        public Servico GetServicoPorId(int id)
        {
            // Declara parâmetros a serem usados na criação do objeto
            string nome;
            double valorBase;
            Servico servico;
            List<Servico> servicos = new List<Servico>(1);
            // Cria objeto da conexão com o banco de dados e escopo deste objeto
            using (NpgsqlConnection conexao = new NpgsqlConnection(config))
            {
                // Abre conexão com o banco
                conexao.Open();
                // Declara sentença SQL
                string selecionar = $"SELECT * FROM public.servicos WHERE id = {id};";
                // Cria escopo e objeto do comando SQL utilizando a sentença e a conexão como parâmetros
                using (NpgsqlCommand comando = new NpgsqlCommand(selecionar, conexao))
                {
                    // Executa query
                    NpgsqlDataReader query = comando.ExecuteReader();
                    // Itera sobre os resultados da query
                    while (query.Read())
                    {
                        // Cria um objeto do tipo Servico com os dados das colunas
                        nome = query.GetString(1).Trim();
                        valorBase = query.GetDouble(2);
                        servico = new Servico(id, nome, valorBase);
                        // Adiciona objeto na lista servicos
                        servicos.Add(servico);
                    }
                }
                // Fecha conexão com o banco de dados
                conexao.Close();
            }
            // Retorna o primeiro e único objeto da lista do tipo Servico
            return servicos[0];
        }

        /// <summary>
        /// Este método atualiza os campos nome e valor de uma entrada da tabela <b>servicos</b> selecionada por id.
        /// </summary>
        public void AtualizarServico(int id, string nomeServico, double valorBaseServico)
        {
            // Cria objeto da conexão com o banco de dados e escopo deste objeto
            using (NpgsqlConnection conexao = new NpgsqlConnection(config))
            {
                // Abre conexão com o banco
                conexao.Open();
                // Declara sentença SQL
                string atualizar = "UPDATE public.servicos SET servico_nome=@servico_nome, servico_valor_base=@servico_valor_base WHERE id = @id;";
                // Cria escopo e objeto do comando SQL utilizando a sentença e a conexão como parâmetros
                using (NpgsqlCommand comando = new NpgsqlCommand(atualizar, conexao))
                {
                    // Adiciona os parâmetros ao comando
                    comando.Parameters.AddWithValue("id", id);
                    comando.Parameters.AddWithValue("servico_nome", nomeServico);
                    comando.Parameters.AddWithValue("servico_valor_base", valorBaseServico);
                    // Executa o comando SQL no banco de dados
                    comando.ExecuteNonQuery();
                }
                // Fecha a conexão com o banco de dados
                conexao.Close();
            }
        }

        /// <summary>
        /// Este método deleta uma entrada da tabela <b>servicos</b> com base no ID
        /// </summary>
        public void DeletarServico(int id)
        {
            // Cria objeto da conexão com o banco de dados e escopo deste objeto
            using (NpgsqlConnection conexao = new NpgsqlConnection(config))
            {
                // Abre conexão com o banco
                conexao.Open();
                // Declara sentença SQL
                string deletar = "DELETE FROM public.servicos WHERE id = @id;";
                // Cria escopo e objeto do comando SQL utilizando a sentença e a conexão como parâmetros
                using (NpgsqlCommand comando = new NpgsqlCommand(deletar, conexao))
                {
                    // Adiciona os parâmetros ao comando
                    comando.Parameters.AddWithValue("id", id);
                    // Executa o comando SQL no banco de dados
                    comando.ExecuteNonQuery();
                }
                // Fecha a conexão com o banco de dados
                conexao.Close();
            }
        }
    }    
}
