using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atv2___Forms
{
    public partial class Form1 : Form
    {
        Contatos pessoas = new Contatos();
        public Form1()
        {
            Contatos pessoas = new Contatos();
            pessoas.adicionar(new Contato("miemail1", "Maria", "1398820", new Data(03, 07, 2001)));
            pessoas.adicionar(new Contato("miemail2", "Roberta", "135410", new Data(13, 02, 2001)));
            pessoas.adicionar(new Contato("meuemail3", "Antonio", "139920", new Data(23, 04, 2001)));
            pessoas.adicionar(new Contato("miemail4", "João", "19872", new Data(12, 03, 2001)));
            InitializeComponent();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxEmail.Text = "";
            textBoxNome.Text = "";
            textBoxTel.Text = "";
            textBoxDia.Text = "";
            textBoxMes.Text = "";
            textBoxAno.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data dtNasc = new Data(int.Parse(textBoxDia.Text), int.Parse(textBoxMes.Text), int.Parse(textBoxAno.Text));

            string emailAtual = pessoas.pesquisar(textBoxEmail.Text).Email;

            if (emailAtual != textBoxEmail.Text)
            {
                pessoas.adicionar(new Contato(textBoxEmail.Text, textBoxNome.Text, textBoxTel.Text, dtNasc));
            }
            else 
            {      
                pessoas.alterar(new Contato(emailAtual, textBoxNome.Text, textBoxTel.Text, dtNasc));
            }


            
        }

        private void buttonPesquisa_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text;
            MessageBox.Show(pessoas.pesquisar(email).Email != email ? "Nao encontrado" : pessoas.pesquisar(email).ToString());

        }

        private void buttonListar_Click(object sender, EventArgs e)
        {
            listBoxPessoas.Items.Clear();
            string ListPessoas = pessoas.listarContatos();
            var array = ListPessoas.Split(new char[] { '#' }, StringSplitOptions.RemoveEmptyEntries);

            foreach(string a in array)
            {
                listBoxPessoas.Items.Add(a);
            }
            
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            Data dtNasc = new Data(int.Parse(textBoxDia.Text), int.Parse(textBoxMes.Text), int.Parse(textBoxAno.Text));
            MessageBox.Show(pessoas.remover(new Contato(textBoxEmail.Text, textBoxNome.Text, textBoxTel.Text, dtNasc)) ? "REMOVIDO!" : "CONTATO NÃO ENCONTRADO");
        }
    }
}
