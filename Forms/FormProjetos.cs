using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ModernArt.Forms
{
    public partial class FormProjetos : Form
    {
        public FormProjetos()
        {
            DirectoryInfo raiz = new DirectoryInfo(@"C:\CoralArt");
            raiz.CreateSubdirectory("Relatórios");
            InitializeComponent();
            AtualizaViewEstrangeiras();
            AtualizaViewProjetos();
        }
        public int Hour { get; }

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

        private void AtualizaViewEstrangeiras()
        {
            comboFkClientes.Items.Clear();
            comboFkDesigner.Items.Clear();
            comboFkServicos.Items.Clear();
            Dados dados = new Dados();
            foreach (Cliente cliente in dados.GetTodosClientes())
            {
                comboFkClientes.Items.Add($"{cliente.Id} - {cliente.Nome}");
                Console.WriteLine();
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
            foreach (var projeto in listaProjetos)
            {

            }
            TabelaProjetos.DataSource = listaProjetos;
            TabelaProjetos.Columns["Servico"].HeaderText = "Serviço";
            TabelaProjetos.Columns["ValorFinal"].HeaderText = "Valor Final";
            TabelaProjetos.Columns["ValorFinal"].DefaultCellStyle.Format = "C2";
            TabelaProjetos.Columns["Id"].HeaderText = "ID";
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
            AtualizaViewProjetos();
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

        //Metodo imprimir
        private void imprimir()
        {
            // Para gerar tabela de serviços..

            Dados dados1 = new Dados();
            List<Cliente> listaClientes = dados1.GetTodosClientes();

            Dados dados2 = new Dados();
            List<Projeto> listaProjetos = dados2.GetTodosProjetos();

            Dados dados3 = new Dados();
            List<Designer> listDesigners = dados3.GetTodosDesigners();

            Dados dados4 = new Dados();
            List<Servico> listaServicos = dados4.GetTodosServicos();

            //Cria e formata documento
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(5, 5, 30, 80);
            doc.AddCreationDate();
            var data = DateTime.Now.ToString("yyyy-MM-dd");
            string caminho = $@"C:\CoralArt\Relatórios\Relatorio de Projetos {data}.pdf";

            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            doc.Open();

            //Coloca logo do Sistema
            string simg = "https://i.ibb.co/3yZrdzV/icone1.png";
            iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(simg);
            img.ScaleAbsolute(64, 64);
            img.Alignment = Element.ALIGN_CENTER;

            doc.Add(img);

            //Paragrafos
            Paragraph espaco = new Paragraph();
            espaco.Add("\n\n\n\n");
            doc.Add(espaco);

            Paragraph titulo = new Paragraph();
            titulo.Font = new iTextSharp.text.Font(
                iTextSharp.text.Font.FontFamily.COURIER, 30);
            titulo.Alignment = Element.ALIGN_CENTER;
            titulo.Add("Coral - Agência digital\n\n");
            doc.Add(titulo);

            Paragraph subtitulo = new Paragraph();
            subtitulo.Font = new iTextSharp.text.Font(
                iTextSharp.text.Font.FontFamily.COURIER, 15);
            subtitulo.Alignment = Element.ALIGN_CENTER;
            subtitulo.Add("Relatório de projetos\n\n");
            doc.Add(subtitulo);


            //Tabela aqui!

            PdfPTable table = new PdfPTable(6);

            table.AddCell("Cliente");
            table.AddCell("Projeto");
            table.AddCell("Designer");
            table.AddCell("Serviço");
            table.AddCell("Valor");
            table.AddCell("Status");

            foreach (Projeto projeto in listaProjetos)
            {
                table.AddCell(Convert.ToString(projeto.Cliente.Nome));
                table.AddCell(projeto.Nome);
                table.AddCell(Convert.ToString(projeto.Designer.Nome));
                table.AddCell(Convert.ToString(projeto.Servico.Nome));
                table.AddCell(Convert.ToString(projeto.ValorFinal));
                if (projeto.Status == 'O')
                {
                    table.AddCell("Orçamento");
                }
                else if (projeto.Status == 'A')
                {
                    table.AddCell("Em andamento");
                }
                else
                {
                    table.AddCell("Finalizado");
                }
            }

            doc.Add(table);

            //Fecha documento, mostra uma mensagem amigavel e depois do "OK" o documento abre
            doc.Close();
            MessageBox.Show("Impressão realizada com sucesso! O relatório será exibido em seguida..");
            System.Diagnostics.Process.Start(caminho);

        }

        private void FormProjetos_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void TabelaProjetos_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void TabelaProjetos_SelectionChanged(object sender, EventArgs e)
        {
            var projeto = (Projeto)TabelaProjetos.CurrentRow.DataBoundItem;
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

        private void limpar()
        {
            TabelaProjetos.ClearSelection();
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
            statusOrcamento.Checked = true;
            comboFkClientes.SelectedIndex = 0;
            comboFkDesigner.SelectedIndex = 0;
            comboFkServicos.SelectedIndex = 0;
        }

        private void TabelaProjetos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            limpar();
        }
    }
}
