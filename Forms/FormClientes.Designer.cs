
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnLimpaCampos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // emailCliente
            // 
            this.emailCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(78)))));
            this.emailCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.emailCliente.Location = new System.Drawing.Point(28, 215);
            this.emailCliente.Name = "emailCliente";
            this.emailCliente.Size = new System.Drawing.Size(247, 19);
            this.emailCliente.TabIndex = 18;
            // 
            // telefoneCliente
            // 
            this.telefoneCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(78)))));
            this.telefoneCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefoneCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefoneCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.telefoneCliente.Location = new System.Drawing.Point(28, 155);
            this.telefoneCliente.Name = "telefoneCliente";
            this.telefoneCliente.Size = new System.Drawing.Size(210, 19);
            this.telefoneCliente.TabIndex = 17;
            // 
            // nomeCliente
            // 
            this.nomeCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(78)))));
            this.nomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeCliente.ForeColor = System.Drawing.SystemColors.Window;
            this.nomeCliente.Location = new System.Drawing.Point(28, 94);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(247, 19);
            this.nomeCliente.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(28, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(28, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Telefone";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(28, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(341, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 28;
            this.label4.Text = "Clientes";
            // 
            // TabelaCliente
            // 
            this.TabelaCliente.AllowUserToAddRows = false;
            this.TabelaCliente.AllowUserToDeleteRows = false;
            this.TabelaCliente.AllowUserToResizeColumns = false;
            this.TabelaCliente.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabelaCliente.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaCliente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.TabelaCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabelaCliente.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TabelaCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaCliente.DefaultCellStyle = dataGridViewCellStyle3;
            this.TabelaCliente.GridColor = System.Drawing.Color.White;
            this.TabelaCliente.Location = new System.Drawing.Point(338, 50);
            this.TabelaCliente.MultiSelect = false;
            this.TabelaCliente.Name = "TabelaCliente";
            this.TabelaCliente.ReadOnly = true;
            this.TabelaCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TabelaCliente.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.TabelaCliente.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TabelaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaCliente.Size = new System.Drawing.Size(421, 307);
            this.TabelaCliente.TabIndex = 27;
            this.TabelaCliente.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.TabelaCliente_ColumnAdded);
            this.TabelaCliente.SelectionChanged += new System.EventHandler(this.TabelaCliente_SelectionChanged);
            // 
            // adicionarCliente
            // 
            this.adicionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adicionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adicionarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.atualizarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.atualizarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.deletarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deletarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
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
            this.comboClientes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboClientes.FormattingEnabled = true;
            this.comboClientes.Location = new System.Drawing.Point(25, 313);
            this.comboClientes.MaxDropDownItems = 10;
            this.comboClientes.Name = "comboClientes";
            this.comboClientes.Size = new System.Drawing.Size(262, 24);
            this.comboClientes.TabIndex = 29;
            this.comboClientes.SelectedIndexChanged += new System.EventHandler(this.comboClientes_SelectedIndexChanged);
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.btnLimpaCampos.BackgroundImage = global::ModernArt.Properties.Resources.limpar;
            this.btnLimpaCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpaCampos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.btnLimpaCampos.Location = new System.Drawing.Point(238, 259);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Size = new System.Drawing.Size(32, 32);
            this.btnLimpaCampos.TabIndex = 30;
            this.btnLimpaCampos.UseVisualStyleBackColor = false;
            this.btnLimpaCampos.Click += new System.EventHandler(this.btnLimpaCampos_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(28, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 2);
            this.panel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(28, 177);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 2);
            this.panel3.TabIndex = 32;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(28, 240);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 2);
            this.panel2.TabIndex = 32;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImprimir.Location = new System.Drawing.Point(187, 363);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 38);
            this.btnImprimir.TabIndex = 38;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpaCampos);
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
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "FormClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.FormClientes_Load);
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
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private System.Windows.Forms.Button btnLimpaCampos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnImprimir;
    }
}