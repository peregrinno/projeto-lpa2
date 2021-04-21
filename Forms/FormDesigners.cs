using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernArt.Forms
{
    public partial class FormDesigners : Form
    {
        public FormDesigners()
        {
            InitializeComponent();
            AtualizaViewDesigners();
        }

        public void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Gainsboro;
                    btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColor.SecondaryColor;
        }

        public void AtualizaViewDesigners()
        {
            comboDesigners.Items.Clear();
            Dados dados = new Dados();
            List<Designer> listaDesigners = dados.GetTodosDesigners();
            TabelaDesigner.DataSource = listaDesigners;
            foreach (Designer designer in listaDesigners)
            {
                comboDesigners.Items.Add($"{designer.Id} - {designer.Nome}");
            }
            comboDesigners.SelectedIndex = 0;
        }

        private void adicionarDesigner_Click(object sender, EventArgs e)
        {
            bool designerDisponivel;
            if (designerTrue.Checked)
            {
                designerDisponivel = true;
            }
            else
            {
                designerDisponivel = false;
            }
            Dados dados = new Dados();
            dados.InserirDesigner(nomeDesigner.Text, telefoneDesigner.Text, emailDesigner.Text, designerDisponivel);
            AtualizaViewDesigners();
            MessageBox.Show("Designer adicionado com sucesso!");
        }

        private void atualizarDesigner_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboDesigners.SelectedItem.ToString().Split(' ')[0]);
            bool designerDisponivel;
            if (designerTrue.Checked)
            {
                designerDisponivel = true;
            }
            else
            {
                designerDisponivel = false;
            }
            Dados dados = new Dados();
            dados.AtualizarDesigner(id, nomeDesigner.Text, telefoneDesigner.Text, emailDesigner.Text, designerDisponivel);
            AtualizaViewDesigners();
            MessageBox.Show("Alterado com sucesso!");
        }

        private void deletarDesigner_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboDesigners.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            dados.DeletarDesigner(id);
            AtualizaViewDesigners();
            MessageBox.Show("Deletado com sucesso.");
        }

        private void comboDesigners_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboDesigners.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            Designer designer = dados.GetDesignerPorId(id);
            nomeDesigner.Text = designer.Nome;
            telefoneDesigner.Text = designer.Telefone;
            emailDesigner.Text = designer.Email;
            if (designer.Disponivel)
            {
                designerTrue.Checked = true;
            }
            else
            {
                designerFalse.Checked = true;
            }
        }

        private void FormDesigners_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
