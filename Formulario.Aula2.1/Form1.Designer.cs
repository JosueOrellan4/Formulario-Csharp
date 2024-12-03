namespace Formulario.Aula2._1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Titulo = new System.Windows.Forms.TextBox();
            this.textBox_Genero = new System.Windows.Forms.TextBox();
            this.textBox_Ano = new System.Windows.Forms.TextBox();
            this.textBox_Avaliacao = new System.Windows.Forms.TextBox();
            this.cadastro = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Avaliacao = new System.Windows.Forms.Label();
            this.estrela5 = new System.Windows.Forms.PictureBox();
            this.estrela2 = new System.Windows.Forms.PictureBox();
            this.estrela4 = new System.Windows.Forms.PictureBox();
            this.estrela1 = new System.Windows.Forms.PictureBox();
            this.estrela3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.estrela5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrela2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrela4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrela1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrela3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(709, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(882, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(344, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cadastro de Filmes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(159, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Genero";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ano";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Avaliação (1 - 5)";
            // 
            // textBox_Titulo
            // 
            this.textBox_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Titulo.Location = new System.Drawing.Point(329, 163);
            this.textBox_Titulo.Name = "textBox_Titulo";
            this.textBox_Titulo.Size = new System.Drawing.Size(270, 26);
            this.textBox_Titulo.TabIndex = 1;
            // 
            // textBox_Genero
            // 
            this.textBox_Genero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Genero.Location = new System.Drawing.Point(329, 212);
            this.textBox_Genero.Name = "textBox_Genero";
            this.textBox_Genero.Size = new System.Drawing.Size(270, 26);
            this.textBox_Genero.TabIndex = 2;
            // 
            // textBox_Ano
            // 
            this.textBox_Ano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Ano.Location = new System.Drawing.Point(329, 263);
            this.textBox_Ano.Name = "textBox_Ano";
            this.textBox_Ano.Size = new System.Drawing.Size(270, 26);
            this.textBox_Ano.TabIndex = 3;
            // 
            // textBox_Avaliacao
            // 
            this.textBox_Avaliacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Avaliacao.Location = new System.Drawing.Point(329, 323);
            this.textBox_Avaliacao.Name = "textBox_Avaliacao";
            this.textBox_Avaliacao.Size = new System.Drawing.Size(270, 26);
            this.textBox_Avaliacao.TabIndex = 4;
            // 
            // cadastro
            // 
            this.cadastro.AutoSize = true;
            this.cadastro.BackColor = System.Drawing.SystemColors.Control;
            this.cadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.cadastro.Font = new System.Drawing.Font("Lucida Bright", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastro.ForeColor = System.Drawing.Color.DarkRed;
            this.cadastro.Image = ((System.Drawing.Image)(resources.GetObject("cadastro.Image")));
            this.cadastro.Location = new System.Drawing.Point(73, 426);
            this.cadastro.Name = "cadastro";
            this.cadastro.Size = new System.Drawing.Size(509, 72);
            this.cadastro.TabIndex = 13;
            this.cadastro.Text = "CADASTRADO";
            this.cadastro.Visible = false;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.Location = new System.Drawing.Point(682, 426);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(0, 22);
            this.label_Titulo.TabIndex = 14;
            // 
            // label_Avaliacao
            // 
            this.label_Avaliacao.AutoSize = true;
            this.label_Avaliacao.Font = new System.Drawing.Font("Lucida Bright", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Avaliacao.Location = new System.Drawing.Point(682, 476);
            this.label_Avaliacao.Name = "label_Avaliacao";
            this.label_Avaliacao.Size = new System.Drawing.Size(0, 22);
            this.label_Avaliacao.TabIndex = 15;
            // 
            // estrela5
            // 
            this.estrela5.Image = ((System.Drawing.Image)(resources.GetObject("estrela5.Image")));
            this.estrela5.Location = new System.Drawing.Point(921, 463);
            this.estrela5.Name = "estrela5";
            this.estrela5.Size = new System.Drawing.Size(33, 35);
            this.estrela5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrela5.TabIndex = 16;
            this.estrela5.TabStop = false;
            this.estrela5.Visible = false;
            // 
            // estrela2
            // 
            this.estrela2.Image = ((System.Drawing.Image)(resources.GetObject("estrela2.Image")));
            this.estrela2.Location = new System.Drawing.Point(802, 463);
            this.estrela2.Name = "estrela2";
            this.estrela2.Size = new System.Drawing.Size(33, 35);
            this.estrela2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrela2.TabIndex = 17;
            this.estrela2.TabStop = false;
            this.estrela2.Visible = false;
            // 
            // estrela4
            // 
            this.estrela4.Image = ((System.Drawing.Image)(resources.GetObject("estrela4.Image")));
            this.estrela4.Location = new System.Drawing.Point(882, 463);
            this.estrela4.Name = "estrela4";
            this.estrela4.Size = new System.Drawing.Size(33, 35);
            this.estrela4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrela4.TabIndex = 18;
            this.estrela4.TabStop = false;
            this.estrela4.Visible = false;
            // 
            // estrela1
            // 
            this.estrela1.Image = ((System.Drawing.Image)(resources.GetObject("estrela1.Image")));
            this.estrela1.Location = new System.Drawing.Point(763, 463);
            this.estrela1.Name = "estrela1";
            this.estrela1.Size = new System.Drawing.Size(33, 35);
            this.estrela1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrela1.TabIndex = 19;
            this.estrela1.TabStop = false;
            this.estrela1.Visible = false;
            // 
            // estrela3
            // 
            this.estrela3.Image = ((System.Drawing.Image)(resources.GetObject("estrela3.Image")));
            this.estrela3.Location = new System.Drawing.Point(841, 463);
            this.estrela3.Name = "estrela3";
            this.estrela3.Size = new System.Drawing.Size(33, 35);
            this.estrela3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.estrela3.TabIndex = 20;
            this.estrela3.TabStop = false;
            this.estrela3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1063, 553);
            this.Controls.Add(this.estrela3);
            this.Controls.Add(this.estrela1);
            this.Controls.Add(this.estrela4);
            this.Controls.Add(this.estrela2);
            this.Controls.Add(this.estrela5);
            this.Controls.Add(this.label_Avaliacao);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.cadastro);
            this.Controls.Add(this.textBox_Avaliacao);
            this.Controls.Add(this.textBox_Ano);
            this.Controls.Add(this.textBox_Genero);
            this.Controls.Add(this.textBox_Titulo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estrela5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrela2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrela4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrela1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estrela3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Titulo;
        private System.Windows.Forms.TextBox textBox_Genero;
        private System.Windows.Forms.TextBox textBox_Ano;
        private System.Windows.Forms.TextBox textBox_Avaliacao;
        private System.Windows.Forms.Label cadastro;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_Avaliacao;
        private System.Windows.Forms.PictureBox estrela5;
        private System.Windows.Forms.PictureBox estrela2;
        private System.Windows.Forms.PictureBox estrela4;
        private System.Windows.Forms.PictureBox estrela1;
        private System.Windows.Forms.PictureBox estrela3;
    }
}

