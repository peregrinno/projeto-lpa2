﻿using System;
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
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            DirectoryInfo raiz = new DirectoryInfo(@"C:\CoralArt");
            raiz.CreateSubdirectory("Relatórios");
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
            Dados dados = new Dados();
            List<Cliente> listaClientes = dados.GetTodosClientes();
            if (listaClientes.Count == 1)
            {
                deletarCliente.Enabled = false;
            }
            else
            {
                deletarCliente.Enabled = true;
            }
            TabelaCliente.DataSource = listaClientes;
            TabelaCliente.Columns["Id"].HeaderText = "ID";
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
            if (TabelaCliente.SelectedRows.Count > 0)
            {
                var cliente = (Cliente)TabelaCliente.CurrentRow.DataBoundItem;
                Dados dados = new Dados();
                dados.AtualizarCliente(cliente.Id, nomeCliente.Text, emailCliente.Text, telefoneCliente.Text);
                AtualizaViewClientes();
                MessageBox.Show("Alterado com sucesso!"); 
            }
            else
            {
                MessageBox.Show("Selecione uma entrada antes.");
            }
        }

        private void deletarCliente_Click(object sender, EventArgs e)
        {
            if (TabelaCliente.SelectedRows.Count > 0)
            {
                var cliente = (Cliente)TabelaCliente.CurrentRow.DataBoundItem;
                Dados dados = new Dados();
                int resultadoOperacao = dados.DeletarCliente(cliente.Id);
                AtualizaViewClientes();
                MessageBox.Show(resultadoOperacao == 0 ? "Deletado com sucesso." : "Erro: este cliente está cadastrado em um projeto!"); 
            }
            else
            {
                MessageBox.Show("Selecione uma entrada antes.");
            }
        }

        //Metodo imprimir
        private void imprimir()
        {
            // Para gerar tabela de serviços..

            Dados dados = new Dados();
            List<Cliente> listaClientes = dados.GetTodosClientes();

            //Cria e formata documento
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(10, 10, 30, 80);
            doc.AddCreationDate();
            var data = DateTime.Now.ToString("yyyy-MM-dd");
            string caminho = $@"C:\CoralArt\Relatórios\Relatório de Clientes {data}.pdf";

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
            subtitulo.Add("Relatório de Clientes\n\n");
            doc.Add(subtitulo);


            //Tabela aqui!

            PdfPTable table = new PdfPTable(3);

            table.AddCell("_________Nome");
            table.AddCell("______Telefone");
            table.AddCell("________Email");

            foreach(Cliente cliente in listaClientes)
            {
                table.AddCell(cliente.Nome);
                table.AddCell(cliente.Telefone);
                table.AddCell(cliente.Email);
            }

            doc.Add(table);

            //Fecha documento, mostra uma mensagem amigavel e depois do "OK" o documento abre
            doc.Close();
            MessageBox.Show("Impressão realizada com sucesso! O relatório será exibido em seguida..");
            System.Diagnostics.Process.Start(caminho);

        }

        private void FormClientes_Load(object sender, EventArgs e)
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

        private void limpar()
        {
            TabelaCliente.ClearSelection();
            foreach (TextBox textBox in Controls.OfType<TextBox>())
                textBox.Text = "";
        }

        private void TabelaCliente_SelectionChanged(object sender, EventArgs e)
        {
            var cliente = (Cliente)TabelaCliente.CurrentRow.DataBoundItem;
            nomeCliente.Text = cliente.Nome;
            emailCliente.Text = cliente.Email; 
            telefoneCliente.Text = cliente.Telefone;
        }

        private void TabelaCliente_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void TabelaCliente_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            limpar();
        }
    }
}
