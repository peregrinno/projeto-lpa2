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
    public partial class FormServicos : Form
    {
        public FormServicos()
        {
            DirectoryInfo raiz = new DirectoryInfo(@"C:\CoralArt");
            raiz.CreateSubdirectory("Relatórios");
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
            Dados dados = new Dados();
            List<Servico> listaServicos = dados.GetTodosServicos();
            if (listaServicos.Count == 1)
            {
                deletarServicos.Enabled = false;
            }
            else
            {
                deletarServicos.Enabled = true;
            }
            TabelaServico.DataSource = listaServicos;
            TabelaServico.Columns["Id"].HeaderText = "ID";
            TabelaServico.Columns["ValorBase"].HeaderText = "Valor Base";
            TabelaServico.Columns["ValorBase"].DefaultCellStyle.Format = "C2";
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
                                 Convert.ToDouble(valorBaseServico.Text.Replace(".", ",")));
            AtualizarViewServicos();
            MessageBox.Show("Adicionado com sucesso.");
        }
     
        private void deletarServicos_Click(object sender, EventArgs e)
        {
            if (TabelaServico.SelectedRows.Count > 0)
            {
                var servico = (Servico)TabelaServico.CurrentRow.DataBoundItem;
                Dados dados = new Dados();
                int resultadoOperacao = dados.DeletarServico(servico.Id);
                AtualizarViewServicos();
                MessageBox.Show(resultadoOperacao == 0 ? "Deletado com sucesso." : "Erro: este serviço está cadastrado em um projeto!"); 
            }
            else
            {
                MessageBox.Show("Selecione uma entrada antes.");
            }
        }

        private void alterarServico_Click(object sender, EventArgs e)
        {
            if (TabelaServico.SelectedRows.Count > 0)
            {
                var servico = (Servico)TabelaServico.CurrentRow.DataBoundItem;
                Dados dados = new Dados();
                dados.AtualizarServico(servico.Id, servicoNome.Text,
                                     Convert.ToDouble(valorBaseServico.Text.Replace(".", ",")));
                AtualizarViewServicos();
                MessageBox.Show("Alterado com sucesso."); 
            }
            else
            {
                MessageBox.Show("Selecione uma entrada antes.");
            }
        }

        private void FormServicos_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
       //Metodo imprimir
       private void imprimir()
        {
            // Para gerar tabela de serviços..

            Dados dados = new Dados();
            List<Servico> listaServicos = dados.GetTodosServicos();

            //Cria e formata documento
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();
            var data = DateTime.Now.ToString("yyyy-MM-dd");
            string caminho = $@"C:\CoralArt\Relatórios\Relatório de Serviços {data}.pdf";

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
            subtitulo.Add("Relatório de serviços\n\n");
            doc.Add(subtitulo);


            //Tabela aqui!

            PdfPTable table = new PdfPTable(2);

            table.AddCell("________Nome do Serviço");
            table.AddCell("___________Valor base");

            foreach (Servico servico in listaServicos)
            {
                string valor = Convert.ToString(servico.ValorBase);
                table.AddCell(servico.Nome);
                table.AddCell(valor);
            }

            doc.Add(table);
            
            //Fecha documento, mostra uma mensagem amigavel e depois do "OK" o documento abre
            doc.Close();
            MessageBox.Show("Impressão realizada com sucesso! O relatório será exibido em seguida..");
            System.Diagnostics.Process.Start(caminho);

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }

        private void btnLimpaCampos_Click(object sender, EventArgs e)
        {
            limpar();
        }

        private void TabelaServico_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void TabelaServico_SelectionChanged(object sender, EventArgs e)
        {
            var servico = (Servico)TabelaServico.CurrentRow.DataBoundItem;
            servicoNome.Text = servico.Nome;
            valorBaseServico.Text = Convert.ToString(servico.ValorBase);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void limpar()
        {
            TabelaServico.ClearSelection();
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }
        private void TabelaServico_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            limpar();
        }

        private void valorBaseServico_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!double.TryParse(valorBaseServico.Text, out a))
            {
                // If not int clear textbox text or Undo() last operation
                valorBaseServico.Clear();
            }
        }
    }
}
