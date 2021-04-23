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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
            AtualizaViewClientes();
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

        private void AtualizaViewClientes()
        {
            comboClientes.Items.Clear();
            Dados dados = new Dados();
            List<Cliente> listaClientes = dados.GetTodosClientes();
            TabelaCliente.DataSource = listaClientes;
            foreach (Cliente cliente in listaClientes)
            {
                comboClientes.Items.Add($"{cliente.Id} - {cliente.Nome}");
            }
            comboClientes.SelectedIndex = 0;
        }

        private void adicionarCliente_Click(object sender, EventArgs e)
        {
            Dados dados = new Dados();
            dados.InserirCliente(nomeCliente.Text, emailCliente.Text, telefoneCliente.Text);
            AtualizaViewClientes();
            MessageBox.Show("Cliente adicionado com sucesso!");
        }

        private void atualizarCliente_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboClientes.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            dados.AtualizarCliente(id, nomeCliente.Text, emailCliente.Text, telefoneCliente.Text);
            AtualizaViewClientes();
            MessageBox.Show("Alterado com sucesso!");
        }

        private void deletarCliente_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboClientes.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            dados.DeletarCliente(id);
            AtualizaViewClientes();
            MessageBox.Show("Deletado com sucesso.");
        }

        private void comboClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(comboClientes.SelectedItem.ToString().Split(' ')[0]);
            Dados dados = new Dados();
            Cliente cliente = dados.GetClientePorId(id);
            nomeCliente.Text = cliente.Nome;
            emailCliente.Text = cliente.Email; 
            telefoneCliente.Text = cliente.Telefone;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
    }
}
