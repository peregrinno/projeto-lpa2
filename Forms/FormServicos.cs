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
    public partial class FormServicos : Form
    {
        public FormServicos()
        {
            InitializeComponent();
            AtualizarViewServicos();
            
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
        }

        public void AtualizarViewServicos() {
            comboServicos.Items.Clear();
            Dados dados = new Dados();
            List<Servico> listaServicos = dados.GetTodosServicos();
            TabelaServico.DataSource = listaServicos;
            foreach (Servico servico in listaServicos) {
                comboServicos.Items.Add($"{servico.Id} - {servico.Nome}");
            }
            comboServicos.SelectedIndex = 0;
        }
        

        /// <summary>
        /// button para Adicionar Serviços;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
   
        private void AddServico_Click(object sender, EventArgs e)
        {
            Dados dados = new Dados();
            dados.InserirServico(servicoNome.Text,
                                 Convert.ToDouble(valorBaseServico.Text));
            AtualizarViewServicos();
            MessageBox.Show("Adicionado com sucesso.");
        }
     
        private void deletarServicos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboServicos.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            dados.DeletarServico(id);
            AtualizarViewServicos();
            MessageBox.Show("Deletado com sucesso.");
        }

        private void alterarServico_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboServicos.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            dados.AtualizarServico(id, servicoNome.Text,
                                 Convert.ToDouble(valorBaseServico.Text));
            AtualizarViewServicos();
            MessageBox.Show("Alterado com sucesso!");
            
        }

        private void comboServicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboServicos.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            Servico servico = dados.GetServicoPorId(id);
            servicoNome.Text = servico.Nome;
            valorBaseServico.Text = Convert.ToString(servico.ValorBase);

        }

        private void FormServicos_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void TabelaServico_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
