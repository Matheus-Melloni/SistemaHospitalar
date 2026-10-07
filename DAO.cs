using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Tls.Crypto;//Importar os elementos do MySQL
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
        public MySqlConnection conexao; // Armazenar no BD
        public int [] codigo;
        public string[] nome;
        public string[] area;
        public string [] telefone;
        public string[] email;
        public string[] especialidade;
        public int[] endereco_codigo;
        public string[] cip;
        public string[] crm;
        public int i;
        public int contador;



        public DAO()
        {
            this.conexao = new MySqlConnection("Server=localhost;Database=hospital;Uid=root;password=");
            try
            {
                this.conexao.Open();//abrir a conexao com o BD

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro);
            }
        }//fim do construtor

        public string CadastrarMedico(string nome, string especialidade, string crm, string telefone, string email, int endereco_codigo)
        {
            string inserir = $"INSERT INTO medico (nome, especialidade, crm, telefone, email, endereco_codigo) VALUES " +
                             $"('{nome}', '{especialidade}', '{crm}', '{telefone}', '{email}', '{endereco_codigo}')";

            MySqlCommand sql = new MySqlCommand(inserir, conexao);

            string resultado = sql.ExecuteNonQuery() + " Cadastrado!";

            return resultado;
        }//fim do metodo Cadastrar Médico


        public string CadastrarEnfermeiro(string nome , string area, string telefone, string email, int enderecoEN, string cip)
            {
                string inserir = $"INSERT INTO enfermeiro (nome, area, telefone, email, endereco_codigo, cip) VALUES " +
                            $"('{nome}', '{area}', '{telefone}', '{email}', '{enderecoEN}', '{cip}')";

                MySqlCommand sql = new MySqlCommand(inserir, conexao);

                string resultado = sql.ExecuteNonQuery() + " Cadastrado!";

                return resultado;
            }//fim do metodo cadastrae enfermeiro


        public void PreencherVetor()
        {
            string consultar = "select * from medico";

            //Instanciar 
            this.codigo          = new int[100];
            this.nome            = new string[100];
            this.especialidade   = new string[100];
            this.crm             = new string[100];
            this.telefone        = new string [100];
            this.email           = new string[100];
            this.endereco_codigo = new int[100];

            //comando de relação com o banco
            MySqlCommand sql = new MySqlCommand(consultar, this.conexao);
            

            //leitura do Banco
            MySqlDataReader leitura = sql.ExecuteReader();

            this.i = 0; // Organizar o preenchimento por posição
            this.contador = 0; //Quantidade de dados efetivamente no vetor

            //preencher
            while (leitura.Read())
            {
                this.codigo[i] = Convert.ToInt32(leitura["codigo"]);
                this.nome[i] = leitura["nome"] + "";
                this.especialidade[i] = leitura["especialidade"] + "";
                this.crm[i] = leitura["crm"] + "";
                this.telefone[i] = leitura["telefone"] + "";
                this.email[i] = leitura["email"] + "";
                this.endereco_codigo[i] = Convert.ToInt32(leitura["endereco_codigo"]);
                this.i++;//percorrer o vetor
                this.contador++;//contar quantos dados estão no vetor

            }//fim do while

            //Encerrar o comando DAO
            leitura.Close();
        }//fim do preencher vetor

        //metodos que mostra a quantidade de dados
        public int QuantidadeDeDados()
        {
            return this.contador;
        }//fim do metodo QuantidadeDeDados




    }//Fim da classe 
}//Fim do projeto
