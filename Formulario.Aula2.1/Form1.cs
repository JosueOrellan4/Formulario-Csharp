using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario.Aula2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastro.Visible = true;

            if (int.Parse(textBox_Avaliacao.Text) == 1){
                estrela1.Visible = true;
            }
            else if (int.Parse(textBox_Avaliacao.Text) == 2){
                estrela1.Visible=true;
                estrela2.Visible = true;
            }
            else if (int.Parse(textBox_Avaliacao.Text) == 3)
            {
                estrela1.Visible = true;
                estrela2.Visible = true;
                estrela3.Visible = true;
            }
            else if (int.Parse(textBox_Avaliacao.Text) == 4)
            {
                estrela1.Visible = true;
                estrela2.Visible = true;
                estrela3.Visible = true;
                estrela4.Visible = true;
            }
            else if (int.Parse(textBox_Avaliacao.Text) == 5)
            {
                estrela1.Visible = true;
                estrela2.Visible = true;
                estrela3.Visible = true;
                estrela4.Visible = true;
                estrela5.Visible = true;
            }

            string nomeTitulo = "";
            string generoFilme = "";
            int anoFilme;
            int avalicacaoFilme;

            nomeTitulo = textBox_Titulo.Text;
            generoFilme = textBox_Genero.Text;
            anoFilme = int.Parse(textBox_Ano.Text);
            avalicacaoFilme = int.Parse(textBox_Avaliacao.Text);

            label_Titulo.Text = nomeTitulo;
            label_Avaliacao.Text = avalicacaoFilme.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_Titulo.Text = "";
            textBox_Genero.Text = "";
            textBox_Ano.Text = "";
            textBox_Avaliacao.Text = "";

            cadastro.Visible=false;

            label_Titulo.Text = "";
            label_Avaliacao.Text = "";

            estrela1.Visible = false;
            estrela2.Visible = false;
            estrela3.Visible = false;
            estrela4.Visible = false;
            estrela5.Visible = false;
        }
    }
}
