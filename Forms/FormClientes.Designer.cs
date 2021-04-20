
namespace ModernArt.Forms
{
    partial class FormClientes
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
            this.emailCliente = new System.Windows.Forms.TextBox();
            this.telefoneCliente = new System.Windows.Forms.TextBox();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TabelaCliente = new System.Windows.Forms.DataGridView();
            this.adicionarCliente = new System.Windows.Forms.Button();
            this.atualizarCliente = new System.Windows.Forms.Button();
            this.deletarCliente = new System.Windows.Forms.Button();
            this.comboClientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // emailCliente
            // 
            this.emailCliente.Location = new System.Drawing.Point(77, 134);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(210, 20);
            this.emailCliente.TabIndex = 18;
            // 
            // telefoneCliente
            // 
            this.telefoneCliente.Location = new System.Drawing.Point(77, 108);
            this.telefoneCliente.Name = "telefoneCliente";
            this.telefoneCliente.Size = new System.Drawing.Size(210, 20);
            this.telefoneCliente.TabIndex = 17;
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(77, 82);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(210, 20);
            this.nomeCliente.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Clientes";
            // 
            // TabelaCliente
            // 
            this.TabelaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaCliente.Location = new System.Drawing.Point(338, 82);
            this.TabelaCliente.Name = "TabelaCliente";
            this.TabelaCliente.Size = new System.Drawing.Size(421, 275);
            this.TabelaCliente.TabIndex = 27;
            // 
            // adicionarCliente
            // 
            this.adicionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adicionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarCliente.Location = new System.Drawing.Point(338, 363);
            this.adicionarCliente.Name = "adicionarCliente";
            this.adicionarCliente.Size = new System.Drawing.Size(127, 38);
            this.adicionarCliente.TabIndex = 26;
            this.adicionarCliente.Text = "Adicionar";
            this.adicionarCliente.UseVisualStyleBackColor = true;
            this.adicionarCliente.Click += new System.EventHandler(this.adicionarCliente_Click);
            // 
            // atualizarCliente
            // 
            this.atualizarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.atualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarCliente.Location = new System.Drawing.Point(486, 363);
            this.atualizarCliente.Name = "atualizarCliente";
            this.atualizarCliente.Size = new System.Drawing.Size(127, 38);
            this.atualizarCliente.TabIndex = 25;
            this.atualizarCliente.Text = "Atualizar";
            this.atualizarCliente.UseVisualStyleBackColor = true;
            this.atualizarCliente.Click += new System.EventHandler(this.atualizarCliente_Click);
            // 
            // deletarCliente
            // 
            this.deletarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletarCliente.Location = new System.Drawing.Point(632, 363);
            this.deletarCliente.Name = "deletarCliente";
            this.deletarCliente.Size = new System.Drawing.Size(127, 38);
            this.deletarCliente.TabIndex = 24;
            this.deletarCliente.Text = "Deletar";
            this.deletarCliente.UseVisualStyleBackColor = true;
            this.deletarCliente.Click += new System.EventHandler(this.deletarCliente_Click);
            // 
            // comboClientes
            // 
            this.comboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(25, 193);
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(262, 21);
            this.comboClientes.TabIndex = 29;
            this.comboClientes.SelectedIndexChanged += new System.EventHandler(this.comboClientes_SelectedIndexChanged);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TabelaCliente);
            this.Controls.Add(this.adicionarCliente);
            this.Controls.Add(this.atualizarCliente);
            this.Controls.Add(this.deletarCliente);
            this.Controls.Add(this.emailCliente);
            this.Controls.Add(this.telefoneCliente);
            this.Controls.Add(this.nomeCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormClientes";
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailCliente;
        private System.Windows.Forms.TextBox telefoneCliente;
        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TabelaCliente;
        private System.Windows.Forms.Button adicionarCliente;
        private System.Windows.Forms.Button atualizarCliente;
        private System.Windows.Forms.Button deletarCliente;
        private System.Windows.Forms.ComboBox comboClientes;
    }
}