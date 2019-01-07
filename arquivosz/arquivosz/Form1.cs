using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arquivosz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToShortTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblData.Text = DateTime.Now.ToShortDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:s");
        }

        private void formatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtBloco.Text = "";
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult resposta;
            resposta = MessageBox.Show("EasyPad é um software gratuito e de codigo aberto, para que você tenha uma experiencia diferente","", MessageBoxButtons.OK,MessageBoxIcon.Question);

            if (resposta == DialogResult.OK)
            {
                MessageBox.Show("Bom uso");
            }
            else
                MessageBox.Show("Para mais informaçoes : Google.com");
            
             
        }

        private void dlgSalvar_Click(object sender, EventArgs e)
        {

            DialogResult esc = dlgSalvar1.ShowDialog();


            if (esc == DialogResult.Cancel)
            {
                return;
            }

            StreamWriter arquivo = new StreamWriter(dlgSalvar1.FileName);

            arquivo.Write(txtBloco.Text);
            arquivo.Flush(); //Salva
            arquivo.Close(); //Fecha




        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = opnFile.ShowDialog();

            if (resultado == DialogResult.Cancel)
                return;
            else
            {

                StreamReader arquivo = new StreamReader(opnFile.FileName);

                txtBloco.Text = arquivo.ReadToEnd();
                arquivo.Close();

            }
        }
    }
}
