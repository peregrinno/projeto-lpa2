
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
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.valorBaseServico = new System.Windows.Forms.TextBox();
            this.servicoNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TabelaServico = new System.Windows.Forms.DataGridView();
            this.AddServico = new System.Windows.Forms.Button();
            this.alterarServico = new System.Windows.Forms.Button();
            this.deletarServicos = new System.Windows.Forms.Button();
            this.comboServicos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaServico)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(25, 266);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 31;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(25, 243);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 26);
            this.label6.TabIndex = 29;
            this.label6.Text = "label6";
            // 
            // valorBaseServico
            // 
            this.valorBaseServico.Location = new System.Drawing.Point(63, 108);
            this.valorBaseServico.Name = "valorBaseServico";
            this.valorBaseServico.Size = new System.Drawing.Size(224, 20);
            this.valorBaseServico.TabIndex = 25;
            // 
            // servicoNome
            // 
            this.servicoNome.Location = new System.Drawing.Point(63, 82);
            this.servicoNome.Name = "servicoNome";
            this.servicoNome.Size = new System.Drawing.Size(224, 20);
            this.servicoNome.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(338, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 26);
            this.label4.TabIndex = 23;
            this.label4.Text = "SERVIÇOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "VALOR ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "NOME";
            // 
            // TabelaServico
            // 
            this.TabelaServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaServico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaServico.Location = new System.Drawing.Point(338, 82);
            this.TabelaServico.Name = "TabelaServico";
            this.TabelaServico.Size = new System.Drawing.Size(421, 275);
            this.TabelaServico.TabIndex = 19;
            // 
            // AddServico
            // 
            this.AddServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddServico.Location = new System.Drawing.Point(338, 363);
            this.AddServico.Name = "AddServico";
            this.AddServico.Size = new System.Drawing.Size(127, 38);
            this.AddServico.TabIndex = 18;
            this.AddServico.Text = "CADASTRAR";
            this.AddServico.UseVisualStyleBackColor = true;
            this.AddServico.Click += new System.EventHandler(this.AddServico_Click);
            // 
            // alterarServico
            // 
            this.alterarServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.alterarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alterarServico.Location = new System.Drawing.Point(486, 363);
            this.alterarServico.Name = "alterarServico";
            this.alterarServico.Size = new System.Drawing.Size(127, 38);
            this.alterarServico.TabIndex = 17;
            this.alterarServico.Text = "ATUALIZAR";
            this.alterarServico.UseVisualStyleBackColor = true;
            this.alterarServico.Click += new System.EventHandler(this.alterarServico_Click);
            // 
            // deletarServicos
            // 
            this.deletarServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletarServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletarServicos.Location = new System.Drawing.Point(632, 363);
            this.deletarServicos.Name = "deletarServicos";
            this.deletarServicos.Size = new System.Drawing.Size(127, 38);
            this.deletarServicos.TabIndex = 16;
            this.deletarServicos.Text = "DELETAR";
            this.deletarServicos.UseVisualStyleBackColor = true;
            this.deletarServicos.Click += new System.EventHandler(this.deletarServicos_Click);
            // 
            // comboServicos
            // 
            this.comboServicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboServicos.FormattingEnabled = true;
            this.comboServicos.Location = new System.Drawing.Point(63, 134);
            this.comboServicos.Name = "comboServicos";
            this.comboServicos.Size = new System.Drawing.Size(192, 21);
            this.comboServicos.TabIndex = 32;
            this.comboServicos.SelectedIndexChanged += new System.EventHandler(this.comboServicos_SelectedIndexChanged);
            // 
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboServicos);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valorBaseServico);
            this.Controls.Add(this.servicoNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabelaServico);
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

        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox valorBaseServico;
        private System.Windows.Forms.TextBox servicoNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TabelaServico;
        private System.Windows.Forms.Button AddServico;
        private System.Windows.Forms.Button alterarServico;
        private System.Windows.Forms.Button deletarServicos;
        private System.Windows.Forms.ComboBox comboServicos;
    }
}