using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace ListaTelefonica
{
    public partial class Form1 : Form
    {
        List<Contato> listaContatos = new List<Contato>();
        int proximoID = 1;
        public Form1()
        {
            InitializeComponent();
            ConfigurarDatatGridView();
        }
        //Class para objetos 
        public class Contato
        {
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }
            public int ID { get; set; }
            public string Morada { get; set; }

        }

        //Configuração da tabela
        private void ConfigurarDatatGridView()
        {


            // Define o modo de seleção para selecionar uma linha por vez
            grelhaInfo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Esconde a última linha em branco do DataGridView
            grelhaInfo.AllowUserToAddRows = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //verificar se pretende abrir um arquivo ja existente
            DialogResult result =
                MessageBox.Show("Gostaria de abrir uma lista telefónica existente?", "Abrir Lista Telefónica"
                                 , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AbrirFicheiro();
            }
            else
            {
                
            }
        }

        //Função abrir o ficheiro existente
        private void AbrirFicheiro()
        {
            //Abre uma caixa de dialogo de abrir o arquivo para o usuario selecionar o arquivo .txt
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivo de Texto (*.txt)|*.txt";
            openFileDialog.Title = "Abrir Lista Telefónica";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName !="")
            {
                try
                {
                    using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                    { 
                        //Ler os dados do arquivo e preencher a lista
                        string linha;
                        while ((linha = reader.ReadLine()) != null)
                        {

                            //Analisa as linhas do arquivo e adicione os contatos a lista
                            string[] dados = linha.Split(',');
                            if (dados.Length == 4)
                            {
                                listaContatos.Add(new Contato()
                                {
                                    Nome = dados[0].Trim(),
                                    Telefone = dados[1].Trim(),
                                    Email = dados[2].Trim(),
                                    Morada = dados[3].Trim()
                                });
                            }
                        }
                    }
                    //Atualizar a tabela
                    AtualizarDataGridView();
                    //Garantir o tamanho da tela do aplicativo
                    this.WindowState = FormWindowState.Normal;
                }catch(Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao abrir a lista telefónica: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //Verificar se os campos estão preenchidos
            if (string.IsNullOrEmpty(txtNome.Text)|| string.IsNullOrEmpty(txtTelefone.Text) 
                || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMorada.Text)) 
            { 
                MessageBox.Show("Por favor, preencha todos os campos obrigátorios.", "Campos Vazios", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            
            // Verifica se o número inserido é válido
            if (!int.TryParse(txtTelefone.Text, out int telefone) || txtTelefone.Text.Replace(" ", "").Length != 9)
            {
                MessageBox.Show("Por favor, insira um número de telefone válido.", "Número Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Verificar se o email inserido é válido
            string email = txtEmail.Text.Trim();
            if (!ValidarEmail(email))
            {
                MessageBox.Show("Por favor, insira um email válido.", "Email Inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Cria um novo objeto Contato e adiciona à lista de contatos
            Contato newContato = new Contato()
            {
                ID = proximoID,
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Morada = txtMorada.Text,
                Telefone = txtTelefone.Text
            };
            listaContatos.Add(newContato);

            proximoID++;

            // Atualiza o DataGridView com os dados atualizados
            AtualizarDataGridView();

            // Limpa os campos de entrada
            LimparTextBox();
        }

        //Função Atualizar a lista
        private void AtualizarDataGridView()
        {
            // Limpa as linhas existentes no DataGridView
            grelhaInfo.Rows.Clear();

            // Adiciona cada contato como uma nova linha no DataGridView
            foreach (var contato in listaContatos)
            {
                grelhaInfo.Rows.Add(contato.ID,contato.Nome, contato.Telefone, contato.Email, contato.Morada);
            }
        }

        //Função Validar o Email
        private bool ValidarEmail(string email)
        {
            string validar = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            return Regex.IsMatch(email, validar);
        }

        //Função limpar o campo de leitura de informações
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

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivo de texto (*.txt) |*.txt";
            saveFileDialog.Title = "Salvar Lista Telefónica";
            saveFileDialog.ShowDialog();

            //se o usuário selecionar um arquivo e clicar em salvar

            if (saveFileDialog.FileName != "")
            {
                try
                {
                    using (StreamWriter write =
                        new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (var contato in listaContatos)
                        {
                            write.WriteLine($"Nome: {contato.Nome}, Telefone: {contato.Telefone}," +
                                $" Email: {contato.Email}, Morada {contato.Morada}"
                               );

                        }
                    }
                    MessageBox.Show("Lista telefónica salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao salvar a lista telefónica: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {

            string idPesquisa = Interaction.InputBox("Digite o ID do contato a ser pesquisado:", "Pesquisar Contato por ID", "", 90, 100);

            if (!int.TryParse(idPesquisa, out int id))
            {
                MessageBox.Show("Por favor, insira um ID válido.", "ID Inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Contato contatopesquisar = listaContatos.FirstOrDefault(contato => contato.ID == id);

            if (contatopesquisar !=null)
            {
                MessageBox.Show($"Contato encontrado: \n\nID: {contatopesquisar.ID}\nNome: {contatopesquisar.Nome}\nTelefone: {contatopesquisar.Telefone}\nEmail: {contatopesquisar.Email}" +
                               $"\nMorada: {contatopesquisar.Morada}", "Contato Encotrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Contato não encotrado.", "Contato Não Encotrado", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }


        }   
    }
}
