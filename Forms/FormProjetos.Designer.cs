
namespace ModernArt.Forms
{
    partial class FormProjetos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nomeProjeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabelaProjetos = new System.Windows.Forms.DataGridView();
            this.adicionarProjeto = new System.Windows.Forms.Button();
            this.atualizarProjeto = new System.Windows.Forms.Button();
            this.deletarProjeto = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.valorProjeto = new System.Windows.Forms.TextBox();
            this.comboFkClientes = new System.Windows.Forms.ComboBox();
            this.comboFkServicos = new System.Windows.Forms.ComboBox();
            this.statusOrcamento = new System.Windows.Forms.RadioButton();
            this.statusAndamento = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboFkDesigner = new System.Windows.Forms.ComboBox();
            this.statusFinalizado = new System.Windows.Forms.RadioButton();
            this.comboProjetos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeProjeto
            // 
            this.nomeProjeto.Location = new System.Drawing.Point(88, 82);
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.Size = new System.Drawing.Size(199, 20);
            this.nomeProjeto.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Projetos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // TabelaProjetos
            // 
            this.TabelaProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaProjetos.Location = new System.Drawing.Point(338, 82);
            this.TabelaProjetos.Name = "TabelaProjetos";
            this.TabelaProjetos.Size = new System.Drawing.Size(421, 275);
            this.TabelaProjetos.TabIndex = 19;
            // 
            // adicionarProjeto
            // 
            this.adicionarProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adicionarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarProjeto.Location = new System.Drawing.Point(338, 363);
            this.adicionarProjeto.Name = "adicionarProjeto";
            this.adicionarProjeto.Size = new System.Drawing.Size(127, 38);
            this.adicionarProjeto.TabIndex = 18;
            this.adicionarProjeto.Text = "Adicionar";
            this.adicionarProjeto.UseVisualStyleBackColor = true;
            this.adicionarProjeto.Click += new System.EventHandler(this.adicionarProjeto_Click);
            // 
            // atualizarProjeto
            // 
            this.atualizarProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.atualizarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarProjeto.Location = new System.Drawing.Point(486, 363);
            this.atualizarProjeto.Name = "atualizarProjeto";
            this.atualizarProjeto.Size = new System.Drawing.Size(127, 38);
            this.atualizarProjeto.TabIndex = 17;
            this.atualizarProjeto.Text = "Atualizar";
            this.atualizarProjeto.UseVisualStyleBackColor = true;
            this.atualizarProjeto.Click += new System.EventHandler(this.atualizarProjeto_Click);
            // 
            // deletarProjeto
            // 
            this.deletarProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletarProjeto.Location = new System.Drawing.Point(632, 363);
            this.deletarProjeto.Name = "deletarProjeto";
            this.deletarProjeto.Size = new System.Drawing.Size(127, 38);
            this.deletarProjeto.TabIndex = 16;
            this.deletarProjeto.Text = "Deletar";
            this.deletarProjeto.UseVisualStyleBackColor = true;
            this.deletarProjeto.Click += new System.EventHandler(this.deletarProjeto_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Valor Final";
            // 
            // valorProjeto
            // 
            this.valorProjeto.Location = new System.Drawing.Point(88, 188);
            this.valorProjeto.Name = "valorProjeto";
            this.valorProjeto.Size = new System.Drawing.Size(199, 20);
            this.valorProjeto.TabIndex = 33;
            // 
            // comboFkClientes
            // 
            this.comboFkClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFkClientes.FormattingEnabled = true;
            this.comboFkClientes.Location = new System.Drawing.Point(88, 108);
            this.comboFkClientes.Name = "comboFkClientes";
            this.comboFkClientes.Size = new System.Drawing.Size(199, 21);
            this.comboFkClientes.TabIndex = 34;
            // 
            // comboFkServicos
            // 
            this.comboFkServicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFkServicos.FormattingEnabled = true;
            this.comboFkServicos.Location = new System.Drawing.Point(88, 134);
            this.comboFkServicos.Name = "comboFkServicos";
            this.comboFkServicos.Size = new System.Drawing.Size(199, 21);
            this.comboFkServicos.TabIndex = 35;
            // 
            // statusOrcamento
            // 
            this.statusOrcamento.AutoSize = true;
            this.statusOrcamento.Checked = true;
            this.statusOrcamento.Location = new System.Drawing.Point(25, 268);
            this.statusOrcamento.Name = "statusOrcamento";
            this.statusOrcamento.Size = new System.Drawing.Size(77, 17);
            this.statusOrcamento.TabIndex = 30;
            this.statusOrcamento.TabStop = true;
            this.statusOrcamento.Text = "Orçamento";
            this.statusOrcamento.UseVisualStyleBackColor = true;
            // 
            // statusAndamento
            // 
            this.statusAndamento.AutoSize = true;
            this.statusAndamento.Location = new System.Drawing.Point(108, 268);
            this.statusAndamento.Name = "statusAndamento";
            this.statusAndamento.Size = new System.Drawing.Size(96, 17);
            this.statusAndamento.TabIndex = 31;
            this.statusAndamento.Text = "Em andamento";
            this.statusAndamento.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Designer";
            // 
            // comboFkDesigner
            // 
            this.comboFkDesigner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFkDesigner.FormattingEnabled = true;
            this.comboFkDesigner.Location = new System.Drawing.Point(88, 161);
            this.comboFkDesigner.Name = "comboFkDesigner";
            this.comboFkDesigner.Size = new System.Drawing.Size(199, 21);
            this.comboFkDesigner.TabIndex = 38;
            // 
            // statusFinalizado
            // 
            this.statusFinalizado.AutoSize = true;
            this.statusFinalizado.Location = new System.Drawing.Point(210, 268);
            this.statusFinalizado.Name = "statusFinalizado";
            this.statusFinalizado.Size = new System.Drawing.Size(72, 17);
            this.statusFinalizado.TabIndex = 39;
            this.statusFinalizado.Text = "Finalizado";
            this.statusFinalizado.UseVisualStyleBackColor = true;
            // 
            // comboProjetos
            // 
            this.comboProjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProjetos.FormattingEnabled = true;
            this.comboProjetos.Location = new System.Drawing.Point(25, 363);
            this.comboProjetos.Name = "comboProjetos";
            this.comboProjetos.Size = new System.Drawing.Size(257, 21);
            this.comboProjetos.TabIndex = 40;
            this.comboProjetos.SelectedIndexChanged += new System.EventHandler(this.comboProjetos_SelectedIndexChanged);
            // 
            // FormProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboProjetos);
            this.Controls.Add(this.statusFinalizado);
            this.Controls.Add(this.comboFkDesigner);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboFkServicos);
            this.Controls.Add(this.comboFkClientes);
            this.Controls.Add(this.valorProjeto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.statusAndamento);
            this.Controls.Add(this.statusOrcamento);
            this.Controls.Add(this.nomeProjeto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabelaProjetos);
            this.Controls.Add(this.adicionarProjeto);
            this.Controls.Add(this.atualizarProjeto);
            this.Controls.Add(this.deletarProjeto);
            this.Name = "FormProjetos";
            this.Text = "Projetos";
            this.Load += new System.EventHandler(this.FormProjetos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProjetos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nomeProjeto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TabelaProjetos;
        private System.Windows.Forms.Button adicionarProjeto;
        private System.Windows.Forms.Button atualizarProjeto;
        private System.Windows.Forms.Button deletarProjeto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox valorProjeto;
        private System.Windows.Forms.ComboBox comboFkClientes;
        private System.Windows.Forms.ComboBox comboFkServicos;
        private System.Windows.Forms.RadioButton statusOrcamento;
        private System.Windows.Forms.RadioButton statusAndamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboFkDesigner;
        private System.Windows.Forms.RadioButton statusFinalizado;
        private System.Windows.Forms.ComboBox comboProjetos;
    }
}