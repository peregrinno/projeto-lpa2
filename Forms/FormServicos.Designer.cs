
namespace ModernArt.Forms
{
    partial class FormServicos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.valorBaseServico = new System.Windows.Forms.TextBox();
            this.servicoNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddServico = new System.Windows.Forms.Button();
            this.alterarServico = new System.Windows.Forms.Button();
            this.deletarServicos = new System.Windows.Forms.Button();
            this.comboServicos = new System.Windows.Forms.ComboBox();
            this.TabelaServico = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpaCampos = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaServico)).BeginInit();
            this.SuspendLayout();
            // 
            // valorBaseServico
            // 
            this.valorBaseServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.valorBaseServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valorBaseServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.valorBaseServico.ForeColor = System.Drawing.SystemColors.Window;
            this.valorBaseServico.Location = new System.Drawing.Point(25, 126);
            this.valorBaseServico.Name = "valorBaseServico";
            this.valorBaseServico.Size = new System.Drawing.Size(224, 16);
            this.valorBaseServico.TabIndex = 25;
            // 
            // servicoNome
            // 
            this.servicoNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.servicoNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.servicoNome.ForeColor = System.Drawing.SystemColors.Window;
            this.servicoNome.Location = new System.Drawing.Point(25, 72);
            this.servicoNome.Name = "servicoNome";
            this.servicoNome.Size = new System.Drawing.Size(224, 16);
            this.servicoNome.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(338, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "Serviços";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // AddServico
            // 
            this.AddServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AddServico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddServico.Location = new System.Drawing.Point(338, 363);
            this.AddServico.Name = "AddServico";
            this.AddServico.Size = new System.Drawing.Size(127, 38);
            this.AddServico.TabIndex = 18;
            this.AddServico.Text = "Adicionar";
            this.AddServico.UseVisualStyleBackColor = true;
            this.AddServico.Click += new System.EventHandler(this.AddServico_Click);
            // 
            // alterarServico
            // 
            this.alterarServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.alterarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.alterarServico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.alterarServico.Location = new System.Drawing.Point(486, 363);
            this.alterarServico.Name = "alterarServico";
            this.alterarServico.Size = new System.Drawing.Size(127, 38);
            this.alterarServico.TabIndex = 17;
            this.alterarServico.Text = "Atualizar";
            this.alterarServico.UseVisualStyleBackColor = true;
            this.alterarServico.Click += new System.EventHandler(this.alterarServico_Click);
            // 
            // deletarServicos
            // 
            this.deletarServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletarServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.deletarServicos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletarServicos.Location = new System.Drawing.Point(632, 363);
            this.deletarServicos.Name = "deletarServicos";
            this.deletarServicos.Size = new System.Drawing.Size(127, 38);
            this.deletarServicos.TabIndex = 16;
            this.deletarServicos.Text = "Deletar";
            this.deletarServicos.UseVisualStyleBackColor = true;
            this.deletarServicos.Click += new System.EventHandler(this.deletarServicos_Click);
            // 
            // comboServicos
            // 
            this.comboServicos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.comboServicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboServicos.FormattingEnabled = true;
            this.comboServicos.Location = new System.Drawing.Point(25, 215);
            this.comboServicos.Name = "comboServicos";
            this.comboServicos.Size = new System.Drawing.Size(244, 24);
            this.comboServicos.TabIndex = 32;
            this.comboServicos.SelectedIndexChanged += new System.EventHandler(this.comboServicos_SelectedIndexChanged);
            // 
            // TabelaServico
            // 
            this.TabelaServico.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabelaServico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.TabelaServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.TabelaServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabelaServico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TabelaServico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.TabelaServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaServico.DefaultCellStyle = dataGridViewCellStyle13;
            this.TabelaServico.GridColor = System.Drawing.Color.White;
            this.TabelaServico.Location = new System.Drawing.Point(338, 50);
            this.TabelaServico.Name = "TabelaServico";
            this.TabelaServico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaServico.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.TabelaServico.RowHeadersVisible = false;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            this.TabelaServico.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.TabelaServico.Size = new System.Drawing.Size(421, 307);
            this.TabelaServico.TabIndex = 33;
            this.TabelaServico.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaServico_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(25, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 2);
            this.panel3.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(25, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 2);
            this.panel1.TabIndex = 34;
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.btnLimpaCampos.BackgroundImage = global::ModernArt.Properties.Resources.limpar;
            this.btnLimpaCampos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpaCampos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.btnLimpaCampos.Location = new System.Drawing.Point(237, 164);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Size = new System.Drawing.Size(32, 32);
            this.btnLimpaCampos.TabIndex = 36;
            this.btnLimpaCampos.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImprimir.Location = new System.Drawing.Point(190, 363);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 38);
            this.btnImprimir.TabIndex = 37;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpaCampos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabelaServico);
            this.Controls.Add(this.comboServicos);
            this.Controls.Add(this.valorBaseServico);
            this.Controls.Add(this.servicoNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddServico);
            this.Controls.Add(this.alterarServico);
            this.Controls.Add(this.deletarServicos);
            this.Name = "FormServicos";
            this.Text = "Serviços";
            this.Load += new System.EventHandler(this.FormServicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox valorBaseServico;
        private System.Windows.Forms.TextBox servicoNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddServico;
        private System.Windows.Forms.Button alterarServico;
        private System.Windows.Forms.Button deletarServicos;
        private System.Windows.Forms.ComboBox comboServicos;
        private System.Windows.Forms.DataGridView TabelaServico;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpaCampos;
        private System.Windows.Forms.Button btnImprimir;
    }
}