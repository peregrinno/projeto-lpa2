
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.nomeProjeto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.TabelaProjetos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpaCampos = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaProjetos)).BeginInit();
            this.SuspendLayout();
            // 
            // nomeProjeto
            // 
            this.nomeProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.nomeProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomeProjeto.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProjeto.ForeColor = System.Drawing.SystemColors.Window;
            this.nomeProjeto.Location = new System.Drawing.Point(15, 36);
            this.nomeProjeto.Name = "nomeProjeto";
            this.nomeProjeto.Size = new System.Drawing.Size(276, 25);
            this.nomeProjeto.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(922, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 37);
            this.label4.TabIndex = 23;
            this.label4.Text = "Projetos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(811, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Serviço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(332, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Nome";
            // 
            // adicionarProjeto
            // 
            this.adicionarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarProjeto.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionarProjeto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.adicionarProjeto.Location = new System.Drawing.Point(145, 144);
            this.adicionarProjeto.Name = "adicionarProjeto";
            this.adicionarProjeto.Size = new System.Drawing.Size(127, 38);
            this.adicionarProjeto.TabIndex = 18;
            this.adicionarProjeto.Text = "Adicionar";
            this.adicionarProjeto.UseVisualStyleBackColor = true;
            this.adicionarProjeto.Click += new System.EventHandler(this.adicionarProjeto_Click);
            // 
            // atualizarProjeto
            // 
            this.atualizarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarProjeto.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizarProjeto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.atualizarProjeto.Location = new System.Drawing.Point(411, 144);
            this.atualizarProjeto.Name = "atualizarProjeto";
            this.atualizarProjeto.Size = new System.Drawing.Size(127, 38);
            this.atualizarProjeto.TabIndex = 17;
            this.atualizarProjeto.Text = "Atualizar";
            this.atualizarProjeto.UseVisualStyleBackColor = true;
            this.atualizarProjeto.Click += new System.EventHandler(this.atualizarProjeto_Click);
            // 
            // deletarProjeto
            // 
            this.deletarProjeto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletarProjeto.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletarProjeto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.deletarProjeto.Location = new System.Drawing.Point(278, 144);
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
            this.label7.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(571, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 29);
            this.label7.TabIndex = 32;
            this.label7.Text = "Valor Final";
            // 
            // valorProjeto
            // 
            this.valorProjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.valorProjeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.valorProjeto.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorProjeto.ForeColor = System.Drawing.SystemColors.Window;
            this.valorProjeto.Location = new System.Drawing.Point(653, 92);
            this.valorProjeto.Name = "valorProjeto";
            this.valorProjeto.Size = new System.Drawing.Size(199, 25);
            this.valorProjeto.TabIndex = 33;
            // 
            // comboFkClientes
            // 
            this.comboFkClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFkClientes.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFkClientes.FormattingEnabled = true;
            this.comboFkClientes.Location = new System.Drawing.Point(337, 33);
            this.comboFkClientes.Name = "comboFkClientes";
            this.comboFkClientes.Size = new System.Drawing.Size(199, 31);
            this.comboFkClientes.TabIndex = 34;
            // 
            // comboFkServicos
            // 
            this.comboFkServicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFkServicos.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFkServicos.FormattingEnabled = true;
            this.comboFkServicos.Location = new System.Drawing.Point(815, 33);
            this.comboFkServicos.Name = "comboFkServicos";
            this.comboFkServicos.Size = new System.Drawing.Size(199, 31);
            this.comboFkServicos.TabIndex = 35;
            // 
            // statusOrcamento
            // 
            this.statusOrcamento.AutoSize = true;
            this.statusOrcamento.Checked = true;
            this.statusOrcamento.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusOrcamento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statusOrcamento.Location = new System.Drawing.Point(399, 70);
            this.statusOrcamento.Name = "statusOrcamento";
            this.statusOrcamento.Size = new System.Drawing.Size(93, 27);
            this.statusOrcamento.TabIndex = 30;
            this.statusOrcamento.TabStop = true;
            this.statusOrcamento.Text = "Orçamento";
            this.statusOrcamento.UseVisualStyleBackColor = true;
            // 
            // statusAndamento
            // 
            this.statusAndamento.AutoSize = true;
            this.statusAndamento.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusAndamento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statusAndamento.Location = new System.Drawing.Point(399, 92);
            this.statusAndamento.Name = "statusAndamento";
            this.statusAndamento.Size = new System.Drawing.Size(116, 27);
            this.statusAndamento.TabIndex = 31;
            this.statusAndamento.Text = "Em andamento";
            this.statusAndamento.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(337, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(570, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 29);
            this.label8.TabIndex = 37;
            this.label8.Text = "Designer";
            // 
            // comboFkDesigner
            // 
            this.comboFkDesigner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFkDesigner.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFkDesigner.FormattingEnabled = true;
            this.comboFkDesigner.Location = new System.Drawing.Point(576, 33);
            this.comboFkDesigner.Name = "comboFkDesigner";
            this.comboFkDesigner.Size = new System.Drawing.Size(199, 31);
            this.comboFkDesigner.TabIndex = 38;
            // 
            // statusFinalizado
            // 
            this.statusFinalizado.AutoSize = true;
            this.statusFinalizado.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusFinalizado.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statusFinalizado.Location = new System.Drawing.Point(399, 111);
            this.statusFinalizado.Name = "statusFinalizado";
            this.statusFinalizado.Size = new System.Drawing.Size(86, 27);
            this.statusFinalizado.TabIndex = 39;
            this.statusFinalizado.Text = "Finalizado";
            this.statusFinalizado.UseVisualStyleBackColor = true;
            // 
            // comboProjetos
            // 
            this.comboProjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProjetos.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProjetos.FormattingEnabled = true;
            this.comboProjetos.Location = new System.Drawing.Point(12, 74);
            this.comboProjetos.Name = "comboProjetos";
            this.comboProjetos.Size = new System.Drawing.Size(314, 31);
            this.comboProjetos.TabIndex = 40;
            this.comboProjetos.SelectedIndexChanged += new System.EventHandler(this.comboProjetos_SelectedIndexChanged);
            // 
            // TabelaProjetos
            // 
            this.TabelaProjetos.AllowUserToAddRows = false;
            this.TabelaProjetos.AllowUserToDeleteRows = false;
            this.TabelaProjetos.AllowUserToResizeColumns = false;
            this.TabelaProjetos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.TabelaProjetos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaProjetos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaProjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TabelaProjetos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.TabelaProjetos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TabelaProjetos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.TabelaProjetos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaProjetos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaProjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaProjetos.DefaultCellStyle = dataGridViewCellStyle3;
            this.TabelaProjetos.GridColor = System.Drawing.Color.White;
            this.TabelaProjetos.Location = new System.Drawing.Point(12, 188);
            this.TabelaProjetos.MultiSelect = false;
            this.TabelaProjetos.Name = "TabelaProjetos";
            this.TabelaProjetos.ReadOnly = true;
            this.TabelaProjetos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaProjetos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.TabelaProjetos.RowHeadersVisible = false;
            this.TabelaProjetos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.TabelaProjetos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.TabelaProjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TabelaProjetos.Size = new System.Drawing.Size(1004, 282);
            this.TabelaProjetos.TabIndex = 41;
            this.TabelaProjetos.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.TabelaProjetos_ColumnAdded);
            this.TabelaProjetos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.TabelaProjetos_DataBindingComplete);
            this.TabelaProjetos.SelectionChanged += new System.EventHandler(this.TabelaProjetos_SelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 2);
            this.panel1.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(653, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 32;
            // 
            // btnLimpaCampos
            // 
            this.btnLimpaCampos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.btnLimpaCampos.BackgroundImage = global::ModernArt.Properties.Resources.limpar;
            this.btnLimpaCampos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpaCampos.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnLimpaCampos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaCampos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(78)))));
            this.btnLimpaCampos.Location = new System.Drawing.Point(909, 81);
            this.btnLimpaCampos.Name = "btnLimpaCampos";
            this.btnLimpaCampos.Size = new System.Drawing.Size(67, 59);
            this.btnLimpaCampos.TabIndex = 43;
            this.btnLimpaCampos.UseVisualStyleBackColor = false;
            this.btnLimpaCampos.Click += new System.EventHandler(this.btnLimpaCampos_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnImprimir.Location = new System.Drawing.Point(12, 144);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(127, 38);
            this.btnImprimir.TabIndex = 44;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FormProjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(1028, 482);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpaCampos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TabelaProjetos);
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
        private System.Windows.Forms.DataGridView TabelaProjetos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpaCampos;
        private System.Windows.Forms.Button btnImprimir;
    }
}