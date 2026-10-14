    using MySql.Data.MySqlClient;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace SistemaHospitalar
    {
        internal class DAO
        {
            // Conexão com o Banco de Dados
            public MySqlConnection conexao;

            // Vetores e Contadores para Médicos
            public int[] codigo;
            public string[] nome;
            public string[] area;
            public string[] telefone;
            public string[] email;
            public string[] especialidade;
            public int[] endereco_codigo;
            public string[] crm;
            public int contador;

            // Vetores e Contadores para Enfermeiros
            public int[] codigoEnfermeiro;
            public string[] nomeEnfermeiro;
            public string[] areaEnfermeiro;
            public string[] telefoneEnfermeiro;
            public string[] emailEnfermeiro;
            public int[] endereco_codigoEnfermeiro;
            public string[] cipEnfermeiro;
            public int contadorEnfermeiro;

            public DAO()
            {
                this.conexao = new MySqlConnection("Server=localhost;Database=hospital;Uid=root;password=");
                try
                {
                    this.conexao.Open(); // Abrir a conexão com o BD
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Algo deu errado! \n\n" + erro);
                }
            } // Fim do construtor

            public string CadastrarMedico(string nome, string especialidade, string crm, string telefone, string email, int endereco_codigo)
            {
                string inserir = $"INSERT INTO medico (nome, especialidade, crm, telefone, email, endereco_codigo) VALUES " +
                                 $"('{nome}', '{especialidade}', '{crm}', '{telefone}', '{email}', '{endereco_codigo}')";

                MySqlCommand sql = new MySqlCommand(inserir, conexao);
                string resultado = sql.ExecuteNonQuery() + " Cadastrado!";
                return resultado;
            } // Fim do método Cadastrar Médico

            public string CadastrarEnfermeiro(string nome, string area, string telefone, string email, int enderecoEN, string cip)
            {
                string inserir = $"INSERT INTO enfermeiro (nome, area, telefone, email, endereco_codigo, cip) VALUES " +
                                 $"('{nome}', '{area}', '{telefone}', '{email}', '{enderecoEN}', '{cip}')";

                MySqlCommand sql = new MySqlCommand(inserir, conexao);
                string resultado = sql.ExecuteNonQuery() + " Cadastrado!";
                return resultado;
            } // Fim do método Cadastrar Enfermeiro

            public void PreencherVetor()
            {
                string consultar = "SELECT * FROM medico";

                this.codigo = new int[100];
                this.nome = new string[100];
                this.especialidade = new string[100];
                this.crm = new string[100];
                this.telefone = new string[100];
                this.email = new string[100];
                this.endereco_codigo = new int[100];

                MySqlCommand sql = new MySqlCommand(consultar, this.conexao);
                MySqlDataReader leitura = sql.ExecuteReader();

                int i = 0;
                this.contador = 0;

                while (leitura.Read())
                {
                    this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                    this.nome[i] = leitura["nome"] + "";
                    this.especialidade[i] = leitura["especialidade"] + "";
                    this.crm[i] = leitura["crm"] + "";
                    this.telefone[i] = leitura["telefone"] + "";
                    this.email[i] = leitura["email"] + "";
                    this.endereco_codigo[i] = Convert.ToInt32(leitura["endereco_codigo"]);

                    i++;
                    this.contador++;
                }

                leitura.Close();
            } // Fim do PreencherVetor (Médico)

            // ENFERMEIRO
            public void PreencherVetorEnfermeiro()
            {
                string consultar = "SELECT * FROM enfermeiro";

                this.codigoEnfermeiro = new int[100];
                this.nomeEnfermeiro = new string[100];
                this.areaEnfermeiro = new string[100];
                this.telefoneEnfermeiro = new string[100];
                this.emailEnfermeiro = new string[100];
                this.endereco_codigoEnfermeiro = new int[100];
                this.cipEnfermeiro = new string[100];

                MySqlCommand sql = new MySqlCommand(consultar, this.conexao);
                MySqlDataReader leitura = sql.ExecuteReader();

                int i = 0;
                this.contadorEnfermeiro = 0;

                while (leitura.Read())
                {
                    this.codigoEnfermeiro[i] = Convert.ToInt32(leitura["codigo"]);
                    this.nomeEnfermeiro[i] = leitura["nome"] + "";
                    this.areaEnfermeiro[i] = leitura["area"] + "";
                    this.telefoneEnfermeiro[i] = leitura["telefone"] + "";
                    this.emailEnfermeiro[i] = leitura["email"] + "";
                    this.endereco_codigoEnfermeiro[i] = Convert.ToInt32(leitura["endereco_codigo"]);
                    this.cipEnfermeiro[i] = leitura["cip"] + "";

                    i++;
                    this.contadorEnfermeiro++;
                }

                leitura.Close();
            } // Fim do PreencherVetorEnfermeiro

            // Métodos que mostram a quantidade de dados
            public int QuantidadeDeDados()
            {
                return this.contador;
            }

            public int QuantidadeDeDadosEnfermeiro()
            {
                return this.contadorEnfermeiro; // Agora retorna corretamente a contagem de enfermeiros
            }

            public string AtualizarMedico(int codigo, string nome, string especialidade, string crm, string telefone, string email, int endereco_codigo)
            {
                  string query = $"UPDATE medico SET nome = '{nome}', especialidade = '{especialidade}', crm = '{crm}', telefone = '{telefone}', email = '{email}', endereco_codigo = {endereco_codigo} WHERE codigo = {codigo}";

                    MySqlCommand sql = new MySqlCommand(query, this.conexao);
                    string resultado = sql.ExecuteNonQuery() + " Atualizado";
                    return resultado;

                  
            }//fim atualizar medico





            public string ExcluirMedico(int codigo, string nome, string especialidade, string crm, string telefone, string email, int endereco_codigo)
            {
            string query = $"delete medico SET nome = '{nome}', especialidade = '{especialidade}', crm = '{crm}', telefone = '{telefone}', email = '{email}', endereco_codigo = {endereco_codigo} WHERE codigo = {codigo}";

            MySqlCommand sql = new MySqlCommand(query, this.conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado";
            return resultado;
        }//fim do excluir medico



        } // Fim da classe 
    } // Fim do projeto