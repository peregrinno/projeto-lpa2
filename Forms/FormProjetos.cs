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
    public partial class FormProjetos : Form
    {
        public FormProjetos()
        {
            InitializeComponent();
            AtualizaViewEstrangeiras();
            AtualizaViewProjetos();
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

        private void AtualizaViewEstrangeiras()
        {
            comboFkClientes.Items.Clear();
            comboFkDesigner.Items.Clear();
            comboFkServicos.Items.Clear();
            Dados dados = new Dados();
            foreach (Cliente cliente in dados.GetTodosClientes())
            {
                comboFkClientes.Items.Add($"{cliente.Id} - {cliente.Nome}");
            }
            foreach (Designer designer in dados.GetTodosDesigners())
            {
                comboFkDesigner.Items.Add($"{designer.Id} - {designer.Nome}");
            }
            foreach (Servico servico in dados.GetTodosServicos())
            {
                comboFkServicos.Items.Add($"{servico.Id} - {servico.Nome}");
            }
            comboFkClientes.SelectedIndex = 0;
            comboFkDesigner.SelectedIndex = 0;
            comboFkServicos.SelectedIndex = 0;
        }

        private void AtualizaViewProjetos()
        {
            comboProjetos.Items.Clear();
            Dados dados = new Dados();
            List<Projeto> listaProjetos = dados.GetTodosProjetos();
            TabelaProjetos.DataSource = listaProjetos;
            foreach (Projeto projeto in listaProjetos)
            {
                comboProjetos.Items.Add($"{projeto.Id} - {projeto.Nome}");
            }
            comboProjetos.SelectedIndex = 0;
        }

        private void adicionarProjeto_Click(object sender, EventArgs e)
        {
            int clienteId = Convert.ToInt32(comboFkClientes.SelectedItem.ToString().Split(' ')[0]);
            int designerId = Convert.ToInt32(comboFkDesigner.SelectedItem.ToString().Split(' ')[0]);
            int servicoId = Convert.ToInt32(comboFkServicos.SelectedItem.ToString().Split(' ')[0]);
            char statusProjeto;
            if (statusAndamento.Checked)
            {
                statusProjeto = 'A';
            }
            else if (statusOrcamento.Checked)
            {
                statusProjeto = 'O';
            }
            else
            {
                statusProjeto = 'F';
            }
            Dados dados = new Dados();
            dados.InserirProjeto(designerId, servicoId, clienteId, nomeProjeto.Text, Convert.ToDouble(valorProjeto.Text), statusProjeto);
            AtualizaViewProjetos();
            MessageBox.Show("Alterado com sucesso!");
        }

        private void atualizarProjeto_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboProjetos.SelectedItem.ToString().Split(' ')[0]);
            int clienteId = Convert.ToInt32(comboFkClientes.SelectedItem.ToString().Split(' ')[0]);
            int designerId = Convert.ToInt32(comboFkDesigner.SelectedItem.ToString().Split(' ')[0]);
            int servicoId = Convert.ToInt32(comboFkServicos.SelectedItem.ToString().Split(' ')[0]);
            char statusProjeto;
            if (statusAndamento.Checked)
            {
                statusProjeto = 'A';
            }
            else if (statusOrcamento.Checked)
            {
                statusProjeto = 'O';
            }
            else
            {
                statusProjeto = 'F';
            }
            Dados dados = new Dados();
            dados.AtualizarProjeto(id, designerId, servicoId, clienteId, nomeProjeto.Text, Convert.ToDouble(valorProjeto.Text), statusProjeto);
            AtualizaViewProjetos();
            MessageBox.Show("Alterado com sucesso!");
        }

        private void deletarProjeto_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboProjetos.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            dados.DeletarProjeto(id);
            MessageBox.Show("Deletado com sucesso!");
        }

        private void comboProjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboProjetos.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            Projeto projeto = dados.GetProjetoPorId(id);
            nomeProjeto.Text = projeto.Nome;
            valorProjeto.Text = Convert.ToString(projeto.ValorFinal);
            if (projeto.Status == 'O')
            {
                statusOrcamento.Checked = true;
            }
            else if (projeto.Status == 'A')
            {
                statusAndamento.Checked = true;
            }
            else
            {
                statusFinalizado.Checked = true;
            }
            foreach (var item in comboFkClientes.Items)
            {
                if (projeto.Cliente.Id == Convert.ToInt32(item.ToString().Split(' ')[0]))
                {
                    comboFkClientes.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in comboFkDesigner.Items)
            {
                if (projeto.Designer.Id == Convert.ToInt32(item.ToString().Split(' ')[0]))
                {
                    comboFkDesigner.SelectedItem = item;
                    break;
                }
            }
            foreach (var item in comboFkServicos.Items)
            {
                if (projeto.Servico.Id == Convert.ToInt32(item.ToString().Split(' ')[0]))
                {
                    comboFkServicos.SelectedItem = item;
                    break;
                }
            }

        }

        private void FormProjetos_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
