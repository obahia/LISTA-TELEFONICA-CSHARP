using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaTelefonica
{
    public partial class Form1 : Form
    {
        List<Contato> listaContatos = new List<Contato>();
        public Form1()
        {
            InitializeComponent();
        }
        //Class para objetos 
        public class Contato
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }

            public string Morada { get; set; }

            public override string ToString()
            {
                return $"Nome: {Nome} || Telefone: {Telefone} || Email: {Email} || Morada: {Morada}";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //Verifica se o número inserido é válido
            if(!int.TryParse(txtTelefone.Text, out int
                telefone))
            {
                MessageBox.Show("Por favor, insira um número de telefone válido.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Contato newcontato = new Contato()
            {
                Nome     = txtNome.Text,
                Email    = txtEmail.Text,
                Morada   = txtMorada.Text,
                Telefone = txtTelefone.Text
            };
            
            listaContatos.Add(newcontato);
            //adiciona entao na listbox
            AtualizarList();

            LimparTextBox();
        }

        public void AtualizarList()
        {
            lista_info.Items.Clear();

            // Adicionar rótulos de coluna acima da ListBox
            string header = string.Format("{0,-20} | {1,-15} | {2,-30} | {3,-50}",
                                           "Nome", "Telefone", "Email", "Morada");
            lista_info.Items.Add(header);

            // Adicionar separador de colunas
            string separator = new string('-', header.Length);
            lista_info.Items.Add(separator);

            // Adicionar cada contato formatado como uma linha da tabela na ListBox
            foreach (var contato in listaContatos)
            {
                // Adicionar apenas os detalhes do contato
                string contatoFormatado = string.Format("{0,-20} | {1,-15} | {2,-30} | {3,-50}",
                                                        contato.Nome, contato.Telefone, contato.Email, contato.Morada);
                lista_info.Items.Add(contatoFormatado);
            }
        }


        private void LimparTextBox()
        {

        }

        

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
