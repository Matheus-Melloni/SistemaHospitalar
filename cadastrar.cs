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
        cadastrar cad;
        public cadastrar()
        {
            InitializeComponent();
            bd = new DAO();
            cad = new cadastrar();

            // Configurar o GRID 1 (Médicos)
            ConfigurarGrid();
            NomeDados();
            bd.PreencherVetor(); // Método de consulta DAO para médicos
            AdicionarLinhas();   // Colocar os dados no Grid 1

            // Configurar o GRID 2 (Enfermeiros)
            ConfigurarGrid2();
            NomeDados2();
            bd.PreencherVetorEnfermeiro(); // Método de consulta DAO para enfermeiros
            AdicionarLinhas2();            // Colocar os dados no Grid 2

        } // Fim do método cadastrar

        private void nomeMedico_TextChanged(object sender, EventArgs e) { }
        private void telefoneMedico_TextChanged(object sender, EventArgs e) { }
        private void emailMedico_TextChanged(object sender, EventArgs e) { }
        private void enderecoMedico_TextChanged(object sender, EventArgs e) { }
        private void crm_TextChanged(object sender, EventArgs e) { }

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

                // Cadastrar no banco
                MessageBox.Show(bd.CadastrarMedico(nome, epecialidade, CRM, telefone, email, endereco));

                // Limpar a tela 
                LimparTelaMedico();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro);
            }
        }

        private void nomeEnfermeiro_TextChanged(object sender, EventArgs e) { }
        private void areaEnfermeiro_TextChanged(object sender, EventArgs e) { }
        private void telefoneEnfermeiro_TextChanged(object sender, EventArgs e) { }
        private void emailEnfermeiro_TextChanged(object sender, EventArgs e) { }
        private void enderecoEnfermeiro_TextChanged(object sender, EventArgs e) { }
        private void CIP_TextChanged(object sender, EventArgs e) { }
        private void especialidadeMedico_TextChanged(object sender, EventArgs e) { }

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

                // Cadastrar no banco
                MessageBox.Show(bd.CadastrarEnfermeiro(nomeEN, areaEn, telefoneEN, emailEn, enderecoEN, cip));

                // Limpar a tela 
                LimparTelaEnfermeiro();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado! \n\n" + erro);
            }
        } // Fim método cadastrar enfermeiro

        public void LimparTelaEnfermeiro()
        {
            nomeEnfermeiro.Text = "";
            areaEnfermeiro.Text = "";
            telefoneEnfermeiro.Text = "";
            emailEnfermeiro.Text = "";
            enderecoEnfermeiro.Text = "";
            CIP.Text = "";
        }

        public void LimparTelaMedico()
        {
            nomeMedico.Text = "";
            especialidadeMedico.Text = "";
            telefoneMedico.Text = "";
            emailMedico.Text = "";
            enderecoMedico.Text = "";
            crm.Text = "";
        }

        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void cadastrar_Load(object sender, EventArgs e) { }
        private void label13_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void label14_Click(object sender, EventArgs e) { }
        private void nomeAp_TextChanged(object sender, EventArgs e) { }
        private void areAP_TextChanged(object sender, EventArgs e) { }
        private void codigoAP_TextChanged(object sender, EventArgs e) { }
        private void btnApagar_Click(object sender, EventArgs e)
        {

        }
        private void nomeCON_TextChanged(object sender, EventArgs e) { }
        private void codigoCON_TextChanged(object sender, EventArgs e) { }
        private void btnCon_Click(object sender, EventArgs e) { }
        private void area_Click(object sender, EventArgs e) { }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        } // Fim do data grid view

        public void NomeDados()
        {
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Especialidade";
            dataGridView1.Columns[3].Name = "CRM";
            dataGridView1.Columns[4].Name = "Telefone";
            dataGridView1.Columns[5].Name = "Email";
            dataGridView1.Columns[6].Name = "Endereço";
        } // Fim nome dados

        public void AdicionarLinhas()
        {
            for (int i = 0; i < bd.QuantidadeDeDados(); i++)
            {
                dataGridView1.Rows.Add(bd.codigo[i], bd.nome[i], bd.especialidade[i], bd.crm[i], bd.telefone[i], bd.email[i], bd.endereco_codigo[i]);
            }
        } // Fim do AdicionarLinhas

        public void ConfigurarGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnCount = 7;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAtualizarMedico_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            bd.PreencherVetor();
            AdicionarLinhas();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void NomeDados2()
        {
            dataGridView2.Columns[0].Name = "Código";
            dataGridView2.Columns[1].Name = "Nome";
            dataGridView2.Columns[2].Name = "Área";
            dataGridView2.Columns[3].Name = "Telefone";
            dataGridView2.Columns[4].Name = "Email";
            dataGridView2.Columns[5].Name = "Endereço";
            dataGridView2.Columns[6].Name = "CIP";
        }

        public void AdicionarLinhas2()
        {
            for (int i = 0; i < bd.QuantidadeDeDadosEnfermeiro(); i++)
            {
                dataGridView2.Rows.Add(
                    bd.codigoEnfermeiro[i],
                    bd.nomeEnfermeiro[i],
                    bd.areaEnfermeiro[i],
                    bd.telefoneEnfermeiro[i],
                    bd.emailEnfermeiro[i],
                    bd.endereco_codigoEnfermeiro[i],
                    bd.cipEnfermeiro[i]
                );
            }
        }

        public void ConfigurarGrid2()
        {
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.AllowUserToResizeRows = false;
            dataGridView2.AllowUserToResizeColumns = false;
            dataGridView2.ColumnCount = 7;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnAtualizarEnfermeiro_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            bd.PreencherVetorEnfermeiro();
            AdicionarLinhas2();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void bntAtulizarDadosEnfermeiro_Click(object sender, EventArgs e)
        {

        }

        private void bntAtulizarDadosMedico_Click(object sender, EventArgs e)
        {
            //coletar dados
            long 
        
        }//fim do atualizar dados medico

        
    }
}