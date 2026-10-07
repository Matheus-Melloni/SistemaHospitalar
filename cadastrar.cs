    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace SistemaHospitalar
    {
        public partial class cadastrar : Form
        {
            DAO bd;
            public cadastrar()
            {
                InitializeComponent();
                bd = new DAO();

                //configurar o GRID
                ConfigurarGrid();
                NomeDados();
                bd.PreencherVetor();//Método de consulta DAO
                AdicionarLinhas();//Colocar os dados GRID
                
            }//fim do metodo cadastrar

            private void nomeMedico_TextChanged(object sender, EventArgs e)
            {

            }



            private void telefoneMedico_TextChanged(object sender, EventArgs e)
            {

            }

            private void emailMedico_TextChanged(object sender, EventArgs e)
            {

            }

            private void enderecoMedico_TextChanged(object sender, EventArgs e)
            {

            }

            private void crm_TextChanged(object sender, EventArgs e)
            {

            }

            private void bntCadastrarMedico_Click(object sender, EventArgs e)
            {
                try
                {
                    string nome = nomeMedico.Text;
                    string epecialidade = especialidadeMedico.Text;
                    string telefone = telefoneMedico.Text;
                    string email = emailMedico.Text;
                    int endereco = Convert.ToInt32(enderecoMedico.Text);
                    string CRM = crm.Text;

                    //Cadastrar no banco

                    MessageBox.Show(bd.CadastrarMedico(nome, epecialidade, CRM, telefone, email, endereco));


                //Limpar a tela 
                LimparTela();

            }
                catch (Exception erro) 
                {
                    MessageBox.Show("Algo deu errado! \n\n" + erro);
                }
            }

            private void nomeEnfermeiro_TextChanged(object sender, EventArgs e)
            {

            }

            private void areaEnfermeiro_TextChanged(object sender, EventArgs e)
            {

            }

            private void telefoneEnfermeiro_TextChanged(object sender, EventArgs e)
            {

            }

            private void emailEnfermeiro_TextChanged(object sender, EventArgs e)
            {

            }

            private void enderecoEnfermeiro_TextChanged(object sender, EventArgs e)
            {

            }

            private void CIP_TextChanged(object sender, EventArgs e)
            {

            }

        private void especialidadeMedico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarEnfermeiro_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeEN = nomeEnfermeiro.Text;
                string areaEn = areaEnfermeiro.Text;
                string telefoneEN = telefoneEnfermeiro.Text;
                string emailEn = emailEnfermeiro.Text;
                int enderecoEN = Convert.ToInt32(enderecoEnfermeiro.Text);
                string cip = CIP.Text;

                //Cadastrar no banco

                MessageBox.Show(bd.CadastrarEnfermeiro(nomeEN, areaEn, telefoneEN, emailEn, enderecoEN, cip));


                //Limpar a tela 
                LimparTela();

            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro);
            }
        }//fim metodo cadastrar enfermeiro



        public void LimparTela()
        {
            nomeEnfermeiro.Text = "";
            areaEnfermeiro.Text = "";
            telefoneEnfermeiro.Text = "";
            emailEnfermeiro.Text = "";
            enderecoEnfermeiro.Text = "";
            CIP.Text = "";
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cadastrar_Load(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void nomeAp_TextChanged(object sender, EventArgs e)
        {

        }

        private void areAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnApagar_Click(object sender, EventArgs e)
        {

        }

        private void nomeCON_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoCON_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCon_Click(object sender, EventArgs e)
        {

        }

        private void area_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//fim do data grid view

        public void NomeDados()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Especialidade";
            dataGridView1.Columns[3].Name = "CRM";
            dataGridView1.Columns[4].Name = "Telefone";
            dataGridView1.Columns[5].Name = "Email";
            dataGridView1.Columns[6].Name = "Endereço";
        }//fim nome dados

        //Método que mostra quantidade de dados

        public void AdicionarLinhas()
        {
            for(int i = 0; i < bd.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(bd.codigo[i], bd.nome[i], bd.especialidade[i], bd.crm[i], bd.telefone[i],bd.email[i], bd.endereco_codigo[i]);
                
            }//fim do for
        }//fim do AdicionarLinhas

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;//Usuário não pode adicionar Linhas
            dataGridView1.AllowUserToDeleteRows = false;//Usuário não pode apagar linhas
            dataGridView1.AllowUserToResizeRows = false;//Usuário não pode redimensionar linhas
            dataGridView1.AllowUserToResizeColumns = false;//Usuário não pode redimensionar colunas
            dataGridView1.ColumnCount = 7;//Quantidade de colunas

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAtualizarMedico_Click(object sender, EventArgs e)
        {
            // Limpa as linhas atuais
            dataGridView1.Rows.Clear();

            // Consulta novamente o banco
            bd.PreencherVetor();

            // Adiciona os dados atualizados no Grid
            AdicionarLinhas();
        }
    }//fim da classe
}//fim do projeto
    
