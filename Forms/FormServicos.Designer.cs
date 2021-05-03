
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.valorBaseServico = new System.Windows.Forms.TextBox();
            this.servicoNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddServico = new System.Windows.Forms.Button();
            this.alterarServico = new System.Windows.Forms.Button();
            this.deletarServicos = new System.Windows.Forms.Button();
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
            this.valorBaseServico.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorBaseServico.ForeColor = System.Drawing.SystemColors.Window;
            this.valorBaseServico.Location = new System.Drawing.Point(27, 132);
            this.valorBaseServico.Name = "valorBaseServico";
            this.valorBaseServico.Size = new System.Drawing.Size(248, 25);
            this.valorBaseServico.TabIndex = 25;
            this.valorBaseServico.TextChanged += new System.EventHandler(this.valorBaseServico_TextChanged);
            // 
            // servicoNome
            // 
            this.servicoNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.servicoNome.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.servicoNome.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicoNome.ForeColor = System.Drawing.SystemColors.Window;
            this.servicoNome.Location = new System.Drawing.Point(27, 68);
            this.servicoNome.Name = "servicoNome";
            this.servicoNome.Size = new System.Drawing.Size(244, 25);
            this.servicoNome.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(343, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "Serviços";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(22, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // AddServico
            // 
            this.AddServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServico.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddServico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddServico.Location = new System.Drawing.Point(565, 401);
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
            this.alterarServico.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarServico.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.alterarServico.Location = new System.Drawing.Point(712, 401);
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
            this.deletarServicos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletarServicos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletarServicos.Location = new System.Drawing.Point(859, 401);
            this.deletarServicos.Name = "deletarServicos";
            this.deletarServicos.Size = new System.Drawing.Size(127, 38);
            this.deletarServicos.TabIndex = 16;
            this.deletarServicos.Text = "Deletar";
            this.deletarServicos.UseVisualStyleBackColor = true;
            this.deletarServicos.Click += new System.EventHandler(this.deletarServicos_Click);
            // 
            // TabelaServico
            // 
            this.TabelaServico.AllowUserToAddRows = false;
            this.TabelaServico.AllowUserToDeleteRows = false;
            this.TabelaServico.AllowUserToResizeColumns = false;
            this.TabelaServico.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabelaServico.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaServico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaServico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.TabelaServico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabelaServico.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TabelaServico.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaServico.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaServico.DefaultCellStyle = dataGridViewCellStyle3;
            this.TabelaServico.GridColor = System.Drawing.Color.White;
            this.TabelaServico.Location = new System.Drawing.Point(338, 50);
            this.TabelaServico.MultiSelect = false;
            this.TabelaServico.Name = "TabelaServico";
            this.TabelaServico.ReadOnly = true;
            this.TabelaServico.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaServico.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TabelaServico.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.TabelaServico.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TabelaServico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaServico.Size = new System.Drawing.Size(649, 345);
            this.TabelaServico.TabIndex = 33;
            this.TabelaServico.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.TabelaServico_ColumnAdded);
            this.TabelaServico.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TabelaServico_DataBindingComplete);
            this.TabelaServico.SelectionChanged += new System.EventHandler(this.TabelaServico_SelectionChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(27, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(248, 2);
            this.panel3.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(27, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 2);
            this.panel1.TabIndex = 34;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.btnLimpaCampos.BackgroundImage = global::ModernArt.Properties.Resources.limpar;
            this.btnLimpaCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpaCampos.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnLimpaCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaCampos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.btnLimpaCampos.Location = new System.Drawing.Point(228, 192);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Size = new System.Drawing.Size(47, 47);
            this.btnLimpaCampos.TabIndex = 36;
            this.btnLimpaCampos.UseVisualStyleBackColor = false;
            this.btnLimpaCampos.Click += new System.EventHandler(this.btnLimpaCampos_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImprimir.Location = new System.Drawing.Point(418, 401);
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
            this.ClientSize = new System.Drawing.Size(1028, 482);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpaCampos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabelaServico);
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
        private System.Windows.Forms.DataGridView TabelaServico;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpaCampos;
        private System.Windows.Forms.Button btnImprimir;
    }
}