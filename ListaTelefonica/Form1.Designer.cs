namespace ListaTelefonica
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
            this.lista_info = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Info_Nome = new System.Windows.Forms.TextBox();
            this.Info_Contato = new System.Windows.Forms.TextBox();
            this.Info_Email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Info_Endereco = new System.Windows.Forms.TextBox();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lista_info
            // 
            this.lista_info.FormattingEnabled = true;
            this.lista_info.Location = new System.Drawing.Point(12, 267);
            this.lista_info.Name = "lista_info";
            this.lista_info.Size = new System.Drawing.Size(501, 212);
            this.lista_info.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista Telefónica";
            // 
            // Info_Nome
            // 
            this.Info_Nome.Location = new System.Drawing.Point(129, 68);
            this.Info_Nome.Name = "Info_Nome";
            this.Info_Nome.Size = new System.Drawing.Size(176, 20);
            this.Info_Nome.TabIndex = 3;
            // 
            // Info_Contato
            // 
            this.Info_Contato.Location = new System.Drawing.Point(129, 109);
            this.Info_Contato.Name = "Info_Contato";
            this.Info_Contato.Size = new System.Drawing.Size(176, 20);
            this.Info_Contato.TabIndex = 4;
            // 
            // Info_Email
            // 
            this.Info_Email.Location = new System.Drawing.Point(129, 147);
            this.Info_Email.Name = "Info_Email";
            this.Info_Email.Size = new System.Drawing.Size(176, 20);
            this.Info_Email.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Endereço";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Info_Endereco
            // 
            this.Info_Endereco.Location = new System.Drawing.Point(129, 186);
            this.Info_Endereco.Name = "Info_Endereco";
            this.Info_Endereco.Size = new System.Drawing.Size(176, 20);
            this.Info_Endereco.TabIndex = 9;
            // 
            // btn_Sair
            // 
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.Location = new System.Drawing.Point(519, 414);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(65, 65);
            this.btn_Sair.TabIndex = 15;
            this.btn_Sair.UseVisualStyleBackColor = true;
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deletar.Image")));
            this.btn_Deletar.Location = new System.Drawing.Point(519, 332);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(65, 65);
            this.btn_Deletar.TabIndex = 14;
            this.btn_Deletar.UseVisualStyleBackColor = true;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Image = global::ListaTelefonica.Properties.Resources.noun_update_370571_removebg_preview;
            this.btn_Atualizar.Location = new System.Drawing.Point(519, 216);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(65, 65);
            this.btn_Atualizar.TabIndex = 13;
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salvar.Image = global::ListaTelefonica.Properties.Resources.noun_save_1152048_removebg_preview;
            this.btn_Salvar.Location = new System.Drawing.Point(519, 128);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(65, 65);
            this.btn_Salvar.TabIndex = 12;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Image = global::ListaTelefonica.Properties.Resources.newicon1896676_removebg_preview;
            this.btn_Novo.Location = new System.Drawing.Point(519, 45);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(65, 65);
            this.btn_Novo.TabIndex = 11;
            this.btn_Novo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 491);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Info_Endereco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Info_Email);
            this.Controls.Add(this.Info_Contato);
            this.Controls.Add(this.Info_Nome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_info);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lista Telefónica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lista_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Info_Nome;
        private System.Windows.Forms.TextBox Info_Contato;
        private System.Windows.Forms.TextBox Info_Email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Info_Endereco;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Sair;
    }
}

