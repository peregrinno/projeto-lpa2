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

        //Metodo imprimir
        private void imprimir()
        {
            // Para gerar tabela de serviços..

            Dados dados = new Dados();
            List<Designer> listaDesigners = dados.GetTodosDesigners();

            //Cria e formata documento
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(10, 10, 30, 80);
            doc.AddCreationDate();
            string caminho = @"C:\pdf\" + "Relatório de Designers.pdf";

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
            subtitulo.Add("Relatório de Designers\n\n");
            doc.Add(subtitulo);


            //Tabela aqui!

            PdfPTable table = new PdfPTable(4);

            table.AddCell("______Nome");
            table.AddCell("____Telefone"); 
            table.AddCell("______Email");
            table.AddCell("__Disponibilidade");


            foreach (Designer designer in listaDesigners)
            {
                table.AddCell(designer.Nome);
                table.AddCell(designer.Telefone);
                table.AddCell(designer.Email);
                if (designer.Disponivel == true)
                {
                    table.AddCell("Disponivel");
                }
                else
                {
                    table.AddCell("Indisponível");
                }
            }

            doc.Add(table);

            //Fecha documento, mostra uma mensagem amigavel e depois do "OK" o documento abre
            doc.Close();
            MessageBox.Show("Impressão realizada com sucesso! O relatório será exibido em seguida..");
            System.Diagnostics.Process.Start(caminho);

        }

        private void FormDesigners_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            imprimir();
        }
    }
}
