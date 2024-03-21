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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMorada = new System.Windows.Forms.TextBox();
            this.grelhaInfo = new System.Windows.Forms.DataGridView();
            this.RowID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowTelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Pesquisar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Deletar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grelhaInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista Telefónica";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(129, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(176, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(129, 109);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(176, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(129, 147);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(176, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Telefone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Endereço";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMorada
            // 
            this.txtMorada.Location = new System.Drawing.Point(129, 186);
            this.txtMorada.Name = "txtMorada";
            this.txtMorada.Size = new System.Drawing.Size(176, 20);
            this.txtMorada.TabIndex = 9;
            // 
            // grelhaInfo
            // 
            this.grelhaInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grelhaInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RowID,
            this.RowNome,
            this.RowTelefone,
            this.RowEmail,
            this.RowEndereco});
            this.grelhaInfo.Location = new System.Drawing.Point(26, 225);
            this.grelhaInfo.Name = "grelhaInfo";
            this.grelhaInfo.Size = new System.Drawing.Size(487, 334);
            this.grelhaInfo.TabIndex = 16;
            // 
            // RowID
            // 
            this.RowID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RowID.FillWeight = 10F;
            this.RowID.HeaderText = "ID";
            this.RowID.Name = "RowID";
            this.RowID.Width = 43;
            // 
            // RowNome
            // 
            this.RowNome.HeaderText = "Nome";
            this.RowNome.Name = "RowNome";
            // 
            // RowTelefone
            // 
            this.RowTelefone.HeaderText = "Telefone";
            this.RowTelefone.Name = "RowTelefone";
            // 
            // RowEmail
            // 
            this.RowEmail.HeaderText = "Email";
            this.RowEmail.Name = "RowEmail";
            // 
            // RowEndereco
            // 
            this.RowEndereco.HeaderText = "Endereço";
            this.RowEndereco.Name = "RowEndereco";
            // 
            // btn_Pesquisar
            // 
            this.btn_Pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pesquisar.Image = global::ListaTelefonica.Properties.Resources.noun_magnifying_glass_1142952_removebg_preview;
            this.btn_Pesquisar.Location = new System.Drawing.Point(550, 206);
            this.btn_Pesquisar.Name = "btn_Pesquisar";
            this.btn_Pesquisar.Size = new System.Drawing.Size(65, 65);
            this.btn_Pesquisar.TabIndex = 17;
            this.btn_Pesquisar.UseVisualStyleBackColor = true;
            this.btn_Pesquisar.Click += new System.EventHandler(this.btn_Pesquisar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sair.Image")));
            this.btn_Sair.Location = new System.Drawing.Point(550, 491);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(65, 65);
            this.btn_Sair.TabIndex = 15;
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Deletar
            // 
            this.btn_Deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Deletar.Image")));
            this.btn_Deletar.Location = new System.Drawing.Point(550, 407);
            this.btn_Deletar.Name = "btn_Deletar";
            this.btn_Deletar.Size = new System.Drawing.Size(65, 65);
            this.btn_Deletar.TabIndex = 14;
            this.btn_Deletar.UseVisualStyleBackColor = true;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Atualizar.Image = global::ListaTelefonica.Properties.Resources.noun_update_370571_removebg_preview1;
            this.btn_Atualizar.Location = new System.Drawing.Point(550, 287);
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
            this.btn_Salvar.Location = new System.Drawing.Point(550, 125);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(65, 65);
            this.btn_Salvar.TabIndex = 12;
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Image = global::ListaTelefonica.Properties.Resources.newicon1896676_removebg_preview;
            this.btn_Novo.Location = new System.Drawing.Point(550, 42);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(65, 65);
            this.btn_Novo.TabIndex = 11;
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 580);
            this.Controls.Add(this.btn_Pesquisar);
            this.Controls.Add(this.grelhaInfo);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Deletar);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Salvar);
            this.Controls.Add(this.btn_Novo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMorada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista Telefónica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelhaInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMorada;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Deletar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.DataGridView grelhaInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowTelefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowEndereco;
        private System.Windows.Forms.Button btn_Pesquisar;
    }
}

