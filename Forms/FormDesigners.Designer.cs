
namespace ModernArt.Forms
{
    partial class FormDesigners
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
            this.deletarDesigner = new System.Windows.Forms.Button();
            this.atualizarDesigner = new System.Windows.Forms.Button();
            this.adicionarDesigner = new System.Windows.Forms.Button();
            this.TabelaDesigner = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomeDesigner = new System.Windows.Forms.TextBox();
            this.telefoneDesigner = new System.Windows.Forms.TextBox();
            this.emailDesigner = new System.Windows.Forms.TextBox();
            this.designerTrue = new System.Windows.Forms.RadioButton();
            this.designerFalse = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDesigners = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDesigner)).BeginInit();
            this.SuspendLayout();
            // 
            // deletarDesigner
            // 
            this.deletarDesigner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletarDesigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletarDesigner.Location = new System.Drawing.Point(632, 363);
            this.deletarDesigner.Name = "deletarDesigner";
            this.deletarDesigner.Size = new System.Drawing.Size(127, 38);
            this.deletarDesigner.TabIndex = 0;
            this.deletarDesigner.Text = "Deletar";
            this.deletarDesigner.UseVisualStyleBackColor = true;
            this.deletarDesigner.Click += new System.EventHandler(this.deletarDesigner_Click);
            // 
            // atualizarDesigner
            // 
            this.atualizarDesigner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.atualizarDesigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarDesigner.Location = new System.Drawing.Point(486, 363);
            this.atualizarDesigner.Name = "atualizarDesigner";
            this.atualizarDesigner.Size = new System.Drawing.Size(127, 38);
            this.atualizarDesigner.TabIndex = 1;
            this.atualizarDesigner.Text = "Atualizar";
            this.atualizarDesigner.UseVisualStyleBackColor = true;
            this.atualizarDesigner.Click += new System.EventHandler(this.atualizarDesigner_Click);
            // 
            // adicionarDesigner
            // 
            this.adicionarDesigner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adicionarDesigner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adicionarDesigner.Location = new System.Drawing.Point(338, 363);
            this.adicionarDesigner.Name = "adicionarDesigner";
            this.adicionarDesigner.Size = new System.Drawing.Size(127, 38);
            this.adicionarDesigner.TabIndex = 2;
            this.adicionarDesigner.Text = "Adicionar";
            this.adicionarDesigner.UseVisualStyleBackColor = true;
            this.adicionarDesigner.Click += new System.EventHandler(this.adicionarDesigner_Click);
            // 
            // TabelaDesigner
            // 
            this.TabelaDesigner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabelaDesigner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaDesigner.Location = new System.Drawing.Point(338, 82);
            this.TabelaDesigner.Name = "TabelaDesigner";
            this.TabelaDesigner.Size = new System.Drawing.Size(421, 275);
            this.TabelaDesigner.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Designers";
            // 
            // nomeDesigner
            // 
            this.nomeDesigner.Location = new System.Drawing.Point(77, 82);
            this.nomeDesigner.Name = "nomeDesigner";
            this.nomeDesigner.Size = new System.Drawing.Size(210, 20);
            this.nomeDesigner.TabIndex = 8;
            // 
            // telefoneDesigner
            // 
            this.telefoneDesigner.Location = new System.Drawing.Point(77, 108);
            this.telefoneDesigner.Name = "telefoneDesigner";
            this.telefoneDesigner.Size = new System.Drawing.Size(210, 20);
            this.telefoneDesigner.TabIndex = 9;
            // 
            // emailDesigner
            // 
            this.emailDesigner.Location = new System.Drawing.Point(77, 134);
            this.emailDesigner.Name = "emailDesigner";
            this.emailDesigner.Size = new System.Drawing.Size(210, 20);
            this.emailDesigner.TabIndex = 10;
            // 
            // designerTrue
            // 
            this.designerTrue.AutoSize = true;
            this.designerTrue.Checked = true;
            this.designerTrue.Location = new System.Drawing.Point(86, 160);
            this.designerTrue.Name = "designerTrue";
            this.designerTrue.Size = new System.Drawing.Size(42, 17);
            this.designerTrue.TabIndex = 14;
            this.designerTrue.TabStop = true;
            this.designerTrue.Text = "Sim";
            this.designerTrue.UseVisualStyleBackColor = true;
            // 
            // designerFalse
            // 
            this.designerFalse.AutoSize = true;
            this.designerFalse.Location = new System.Drawing.Point(134, 160);
            this.designerFalse.Name = "designerFalse";
            this.designerFalse.Size = new System.Drawing.Size(45, 17);
            this.designerFalse.TabIndex = 15;
            this.designerFalse.Text = "Não";
            this.designerFalse.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Disponível";
            // 
            // comboDesigners
            // 
            this.comboDesigners.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDesigners.FormattingEnabled = true;
            this.comboDesigners.Location = new System.Drawing.Point(25, 309);
            this.comboDesigners.Name = "comboDesigners";
            this.comboDesigners.Size = new System.Drawing.Size(262, 21);
            this.comboDesigners.TabIndex = 17;
            this.comboDesigners.SelectedIndexChanged += new System.EventHandler(this.comboDesigners_SelectedIndexChanged);
            // 
            // FormDesigners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboDesigners);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.designerFalse);
            this.Controls.Add(this.designerTrue);
            this.Controls.Add(this.emailDesigner);
            this.Controls.Add(this.telefoneDesigner);
            this.Controls.Add(this.nomeDesigner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TabelaDesigner);
            this.Controls.Add(this.adicionarDesigner);
            this.Controls.Add(this.atualizarDesigner);
            this.Controls.Add(this.deletarDesigner);
            this.Name = "FormDesigners";
            this.Text = "Designers";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaDesigner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deletarDesigner;
        private System.Windows.Forms.Button atualizarDesigner;
        private System.Windows.Forms.Button adicionarDesigner;
        private System.Windows.Forms.DataGridView TabelaDesigner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nomeDesigner;
        private System.Windows.Forms.TextBox telefoneDesigner;
        private System.Windows.Forms.TextBox emailDesigner;
        private System.Windows.Forms.RadioButton designerTrue;
        private System.Windows.Forms.RadioButton designerFalse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDesigners;
    }
}