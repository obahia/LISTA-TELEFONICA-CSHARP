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


        private void ConfigurarDatatGridView()
        {
           

            // Define o modo de seleção para selecionar uma linha por vez
            grelhaInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Esconde a última linha em branco do DataGridView
            grelhaInfo.AllowUserToAddRows = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // Verifica se o número inserido é válido
            if (!int.TryParse(txtTelefone.Text, out int telefone))
            {
                MessageBox.Show("Por favor, insira um número de telefone válido.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cria um novo objeto Contato e adiciona à lista de contatos
            Contato newContato = new Contato()
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Morada = txtMorada.Text,
                Telefone = txtTelefone.Text
            };
            listaContatos.Add(newContato);

            // Atualiza o DataGridView com os dados atualizados
            AtualizarDataGridView();

            // Limpa os campos de entrada
            LimparTextBox();
        }
        private void AtualizarDataGridView()
        {
            // Limpa as linhas existentes no DataGridView
            grelhaInfo.Rows.Clear();

            // Adiciona cada contato como uma nova linha no DataGridView
            foreach (var contato in listaContatos)
            {
                grelhaInfo.Rows.Add(contato.Nome, contato.Telefone, contato.Email, contato.Morada);
            }
        }


        private void LimparTextBox()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtMorada.Clear();
        }

        

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void grelhaInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
