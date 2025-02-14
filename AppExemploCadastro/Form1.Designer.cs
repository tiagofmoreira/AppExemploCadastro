namespace AppExemploCadastro
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
            this.label5 = new System.Windows.Forms.Label();
            this.btConsultaLista = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btLista = new System.Windows.Forms.Button();
            this.btCadastro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(573, 26);
            this.label5.TabIndex = 22;
            this.label5.Text = "MENU";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConsultaLista
            // 
            this.btConsultaLista.Image = global::AppExemploCadastro.Properties.Resources.CONSULTA2;
            this.btConsultaLista.Location = new System.Drawing.Point(380, 217);
            this.btConsultaLista.Name = "btConsultaLista";
            this.btConsultaLista.Size = new System.Drawing.Size(117, 91);
            this.btConsultaLista.TabIndex = 26;
            this.btConsultaLista.UseVisualStyleBackColor = true;
            this.btConsultaLista.Click += new System.EventHandler(this.btConsultaLista_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.Image = global::AppExemploCadastro.Properties.Resources.CONSULTA;
            this.btConsulta.Location = new System.Drawing.Point(102, 217);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(117, 91);
            this.btConsulta.TabIndex = 25;
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btLista
            // 
            this.btLista.Image = global::AppExemploCadastro.Properties.Resources.LISTA2;
            this.btLista.Location = new System.Drawing.Point(380, 62);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(117, 91);
            this.btLista.TabIndex = 24;
            this.btLista.UseVisualStyleBackColor = true;
            this.btLista.Click += new System.EventHandler(this.btLista_Click);
            // 
            // btCadastro
            // 
            this.btCadastro.Image = global::AppExemploCadastro.Properties.Resources.rEGISTRO3;
            this.btCadastro.Location = new System.Drawing.Point(102, 62);
            this.btCadastro.Name = "btCadastro";
            this.btCadastro.Size = new System.Drawing.Size(117, 91);
            this.btCadastro.TabIndex = 23;
            this.btCadastro.UseVisualStyleBackColor = true;
            this.btCadastro.Click += new System.EventHandler(this.btCadastro_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Feito por: Tiago Francisco";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 354);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConsultaLista);
            this.Controls.Add(this.btConsulta);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.btCadastro);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "SISTEMA DE CADASTRO";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btCadastro;
        private System.Windows.Forms.Button btLista;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btConsultaLista;
        private System.Windows.Forms.Label label1;
    }
}

