
namespace ModernArt
{
    partial class PanelAgencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAgencia));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMiniminize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBotaorelatorio = new System.Windows.Forms.Button();
            this.btnSobre = new System.Windows.Forms.Button();
            this.btnProjetos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnDesigners = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnBotaorelatorio);
            this.panelMenu.Controls.Add(this.btnSobre);
            this.panelMenu.Controls.Add(this.btnProjetos);
            this.panelMenu.Controls.Add(this.btnServicos);
            this.panelMenu.Controls.Add(this.btnClientes);
            this.panelMenu.Controls.Add(this.btnDesigners);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 581);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Controls.Add(this.pictureBox2);
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(864, 501);
            this.panelDesktopPane.TabIndex = 2;
            this.panelDesktopPane.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktopPane_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::ModernArt.Properties.Resources.logo_agencia_home;
            this.pictureBox2.Location = new System.Drawing.Point(145, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(580, 370);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.BackgroundImage = global::ModernArt.Properties.Resources.doca1700;
            this.panelTitleBar.Controls.Add(this.btnMiniminize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(864, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown_1);
            // 
            // btnMiniminize
            // 
            this.btnMiniminize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMiniminize.BackColor = System.Drawing.Color.Transparent;
            this.btnMiniminize.FlatAppearance.BorderSize = 0;
            this.btnMiniminize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniminize.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniminize.ForeColor = System.Drawing.Color.White;
            this.btnMiniminize.Location = new System.Drawing.Point(765, 3);
            this.btnMiniminize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMiniminize.Name = "btnMiniminize";
            this.btnMiniminize.Size = new System.Drawing.Size(24, 24);
            this.btnMiniminize.TabIndex = 8;
            this.btnMiniminize.Text = "O";
            this.btnMiniminize.UseCompatibleTextRendering = true;
            this.btnMiniminize.UseVisualStyleBackColor = false;
            this.btnMiniminize.Click += new System.EventHandler(this.btnMiniminize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(800, 3);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(24, 24);
            this.btnMaximize.TabIndex = 7;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseCompatibleTextRendering = true;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(834, 3);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "O";
            this.btnClose.UseCompatibleTextRendering = true;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::ModernArt.Properties.Resources.close;
            this.btnCloseChildForm.Location = new System.Drawing.Point(7, 24);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(25, 30);
            this.btnCloseChildForm.TabIndex = 5;
            this.btnCloseChildForm.UseVisualStyleBackColor = false;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(399, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(85, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // btnBotaorelatorio
            // 
            this.btnBotaorelatorio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBotaorelatorio.FlatAppearance.BorderSize = 0;
            this.btnBotaorelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBotaorelatorio.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBotaorelatorio.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBotaorelatorio.Image = global::ModernArt.Properties.Resources.relatorio;
            this.btnBotaorelatorio.Location = new System.Drawing.Point(0, 320);
            this.btnBotaorelatorio.Name = "btnBotaorelatorio";
            this.btnBotaorelatorio.Size = new System.Drawing.Size(220, 60);
            this.btnBotaorelatorio.TabIndex = 5;
            this.btnBotaorelatorio.Text = "   Relatórios";
            this.btnBotaorelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBotaorelatorio.UseVisualStyleBackColor = true;
            // 
            // btnSobre
            // 
            this.btnSobre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSobre.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSobre.FlatAppearance.BorderSize = 0;
            this.btnSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSobre.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSobre.Image = global::ModernArt.Properties.Resources.info;
            this.btnSobre.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSobre.Location = new System.Drawing.Point(0, 531);
            this.btnSobre.Name = "btnSobre";
            this.btnSobre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSobre.Size = new System.Drawing.Size(220, 50);
            this.btnSobre.TabIndex = 4;
            this.btnSobre.Text = "          Sobre";
            this.btnSobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSobre.UseVisualStyleBackColor = true;
            this.btnSobre.Click += new System.EventHandler(this.btnSobre_Click);
            // 
            // btnProjetos
            // 
            this.btnProjetos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProjetos.FlatAppearance.BorderSize = 0;
            this.btnProjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjetos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjetos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProjetos.Image = global::ModernArt.Properties.Resources.projects_icon_branco;
            this.btnProjetos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjetos.Location = new System.Drawing.Point(0, 260);
            this.btnProjetos.Name = "btnProjetos";
            this.btnProjetos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnProjetos.Size = new System.Drawing.Size(220, 60);
            this.btnProjetos.TabIndex = 4;
            this.btnProjetos.Text = "        Projetos";
            this.btnProjetos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProjetos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProjetos.UseVisualStyleBackColor = true;
            this.btnProjetos.Click += new System.EventHandler(this.btnProjetos_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServicos.FlatAppearance.BorderSize = 0;
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnServicos.Image = global::ModernArt.Properties.Resources.services_icon_branco;
            this.btnServicos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicos.Location = new System.Drawing.Point(0, 200);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnServicos.Size = new System.Drawing.Size(220, 60);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "        Serviços";
            this.btnServicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServicos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClientes.Image = global::ModernArt.Properties.Resources.clientes_icon_branco;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Location = new System.Drawing.Point(0, 140);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnClientes.Size = new System.Drawing.Size(220, 60);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "        Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnDesigners
            // 
            this.btnDesigners.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesigners.FlatAppearance.BorderSize = 0;
            this.btnDesigners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesigners.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesigners.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDesigners.Image = global::ModernArt.Properties.Resources.design_icon_branco1;
            this.btnDesigners.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesigners.Location = new System.Drawing.Point(0, 80);
            this.btnDesigners.Name = "btnDesigners";
            this.btnDesigners.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnDesigners.Size = new System.Drawing.Size(220, 60);
            this.btnDesigners.TabIndex = 1;
            this.btnDesigners.Text = "        Designers";
            this.btnDesigners.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesigners.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDesigners.UseVisualStyleBackColor = true;
            this.btnDesigners.Click += new System.EventHandler(this.btnDesigners_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ModernArt.Properties.Resources.doca220;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ModernArt.Properties.Resources.logo_agencia;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 80);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelAgencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 581);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1100, 620);
            this.Name = "PanelAgencia";
            this.Text = "Coral - Agência digital";
            this.Load += new System.EventHandler(this.PanelAgencia_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnDesigners;
        private System.Windows.Forms.Button btnProjetos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnMiniminize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSobre;
        private System.Windows.Forms.Button btnBotaorelatorio;
    }
}

