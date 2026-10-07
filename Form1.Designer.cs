namespace SistemaHospitalar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pacientes = new System.Windows.Forms.Button();
            this.atenderHoje = new System.Windows.Forms.Button();
            this.internacoes = new System.Windows.Forms.Button();
            this.exames = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientes
            // 
            this.pacientes.Location = new System.Drawing.Point(281, 80);
            this.pacientes.Name = "pacientes";
            this.pacientes.Size = new System.Drawing.Size(251, 363);
            this.pacientes.TabIndex = 1;
            this.pacientes.Text = "Consultar pacientes";
            this.pacientes.UseVisualStyleBackColor = true;
            this.pacientes.Click += new System.EventHandler(this.pacientes_Click);
            // 
            // atenderHoje
            // 
            this.atenderHoje.Location = new System.Drawing.Point(557, 80);
            this.atenderHoje.Name = "atenderHoje";
            this.atenderHoje.Size = new System.Drawing.Size(251, 363);
            this.atenderHoje.TabIndex = 2;
            this.atenderHoje.Text = "Atender Hoje";
            this.atenderHoje.UseVisualStyleBackColor = true;
            this.atenderHoje.Click += new System.EventHandler(this.atenderHoje_Click);
            // 
            // internacoes
            // 
            this.internacoes.Location = new System.Drawing.Point(827, 80);
            this.internacoes.Name = "internacoes";
            this.internacoes.Size = new System.Drawing.Size(251, 363);
            this.internacoes.TabIndex = 3;
            this.internacoes.Text = "Internações Ativas ";
            this.internacoes.UseVisualStyleBackColor = true;
            this.internacoes.Click += new System.EventHandler(this.internacoes_Click);
            // 
            // exames
            // 
            this.exames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exames.Location = new System.Drawing.Point(1097, 80);
            this.exames.Name = "exames";
            this.exames.Size = new System.Drawing.Size(251, 363);
            this.exames.TabIndex = 4;
            this.exames.Text = "Pendentes";
            this.exames.UseVisualStyleBackColor = false;
            this.exames.Click += new System.EventHandler(this.exames_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(286, 480);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1062, 329);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = global::SistemaHospitalar.Properties.Resources.imagem;
            this.pictureBox1.Location = new System.Drawing.Point(-389, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(617, 834);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 832);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.exames);
            this.Controls.Add(this.internacoes);
            this.Controls.Add(this.atenderHoje);
            this.Controls.Add(this.pacientes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pacientes;
        private System.Windows.Forms.Button atenderHoje;
        private System.Windows.Forms.Button internacoes;
        private System.Windows.Forms.Button exames;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

