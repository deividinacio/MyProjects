using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// biblioteca usada,  download feito pelo Nuget 
// sautinsoft.pdffocus (VERSÃO TRIAL, portando sai uma mensagem da equipe de desenvolvimento da api



namespace ConversorPDF
{
    public partial class ConversorPDF : Form
    {
        string[] listaArquivos;
        int totalArquivosSelecionados;

        public ConversorPDF()
        {
            InitializeComponent();
            cmb_SelectTipoConvert.Items.Add("PDF para DOCX");
            cmb_SelectTipoConvert.Items.Add("PDF para RTF");
            cmb_SelectTipoConvert.Items.Add("PDF para XLS");
            //cmb_SelectTipoConvert.Items.Add("PDF para JPEG");
        }

        private void ConversorPDF_Load(object sender, EventArgs e)
        {
            this.progressBar1.Maximum = 100;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.Image = null;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.btn_BucarArquivo, "Clique para buscar os arquivos PDF");
            toolTip.SetToolTip(this.btn_Converter, "Clique para realizar a conversão");
        }


        private void btn_BucarArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "SELECIONE UM OU MAIS ARQUIVO(S) .PDF PARA CONVERTER";
            openFileDialog.Multiselect = true; // permite selecionar mais de um arquivo pdf
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.ShowReadOnly = true;



            openFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //List<string> arquivo = new List<string> { openFileDialog.FileName };
                int count = 0;

                totalArquivosSelecionados = Convert.ToInt32(openFileDialog.FileNames.LongLength);
                listaArquivos = new string[totalArquivosSelecionados];

                foreach (string arquivo in openFileDialog.FileNames)
                {
                    
                    listaArquivos[count] = arquivo;

                    txt_CaminhoArquivo.Text += arquivo + " "; // mostra o caminho dos arquivos

                    count++;

                }
                this.progressBar1.Value = 10; // progresso da barra
            }
        }
        private void btn_Converter_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_CaminhoArquivo.Text))
            {
                MessageBox.Show("PRIMEIRO BUSQUE UM ARQUIVO PDF PARA CONVERSÃO!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmb_SelectTipoConvert.SelectedItem == null)
            {
                MessageBox.Show("SELECIONE O FORMATO DE CONVERSÃO!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            switch (cmb_SelectTipoConvert.SelectedIndex) // pega o index do item selecionado, começando da posição 0
            {
                case 0: // PDF para DOCX
                    convertParaDOCX();
                    break;

                case 1: // PDF para RTF
                    convertParaRTF();
                    break;

                case 2: // PDF para Excel
                    convertParaXLS();
                    break;

                default:
                    MessageBox.Show("NENHUM FORMATO DE CONVERSÃO FOI SELECIONADO!", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

            }


        }

        private void  convertParaDOCX() // Word
        {
            this.progressBar1.Value = 66; // progresso da barra
            for (int count = 0; count <= totalArquivosSelecionados; count++)
            {
                if (count == totalArquivosSelecionados)
                {
                    this.progressBar1.Value = 100; // progresso da barra
                    MessageBox.Show("Arquivos Convertidos com Sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("NÃO ESQUEÇA DE REMOVER A ULTIMA LINHA DO DOCUMENTO CONVERTIDO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // sai do laço para não estourar a posição do vetor em FileStream(listaArquivos[count]
                }

                MemoryStream memoryStream = new MemoryStream();

                SautinSoft.PdfFocus pdfFocus = new SautinSoft.PdfFocus();

                using (FileStream pdfStream = new FileStream(listaArquivos[count], FileMode.Open, FileAccess.Read))
                {
                    pdfFocus.OpenPdf(pdfStream);
                    if (pdfFocus.PageCount > 0)
                    {
                        int convert = pdfFocus.ToWord(memoryStream);

                        if (convert == 0)
                        {
                            string docxFile = Path.ChangeExtension(listaArquivos[count], ".docx");
                            File.WriteAllBytes(docxFile, memoryStream.ToArray());
                            // System.Diagnostics.Process.Start(docxFile); // executa o arquivo automaticamente depois de convertido
                        }
                    }
                }

            }

        }


        private void convertParaRTF() // Word
        {
            this.progressBar1.Value = 66; // progresso da barra
            for (int count = 0; count <= totalArquivosSelecionados; count++)
            {
                if (count == totalArquivosSelecionados)
                {
                    this.progressBar1.Value = 100; // progresso da barra
                    MessageBox.Show("Arquivos Convertidos com Sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("NÃO ESQUEÇA DE REMOVER A ULTIMA LINHA DO DOCUMENTO CONVERTIDO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // sai do laço para não estourar a posição do vetor em FileStream(listaArquivos[count]
                }

                MemoryStream memoryStream = new MemoryStream();

                SautinSoft.PdfFocus pdfFocus = new SautinSoft.PdfFocus();

                using (FileStream pdfStream = new FileStream(listaArquivos[count], FileMode.Open, FileAccess.Read))
                {
                    pdfFocus.OpenPdf(pdfStream);
                    if (pdfFocus.PageCount > 0)
                    {
                        int convert = pdfFocus.ToWord(memoryStream);

                        if (convert == 0)
                        {
                            string docxFile = Path.ChangeExtension(listaArquivos[count], ".rtf");
                            File.WriteAllBytes(docxFile, memoryStream.ToArray());
                            // System.Diagnostics.Process.Start(docxFile); // executa o arquivo automaticamente depois de convertido
                        }
                    }
                }

            }

        }



        private void convertParaXLS() // Excel
        {
            this.progressBar1.Value = 66; // progresso da barra
            for (int count = 0; count <= totalArquivosSelecionados; count++)
            {
                if (count == totalArquivosSelecionados)
                {
                    this.progressBar1.Value = 100; // progresso da barra
                    MessageBox.Show("Arquivos Convertidos para Excel com Sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("NÃO ESQUEÇA DE REMOVER A ABA ADICIONADA DO DOCUMENTO CONVERTIDO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // sai do laço para não estourar a posição do vetor em FileStream(listaArquivos[count]
                }

                SautinSoft.PdfFocus pdfFocus = new SautinSoft.PdfFocus();

                using (FileStream pdfStream = new FileStream(listaArquivos[count], FileMode.Open, FileAccess.Read))
                {

                    string docxFile = Path.ChangeExtension(listaArquivos[count], ".xls");

                    pdfFocus.OpenPdf(pdfStream);
                    if (pdfFocus.PageCount > 0)
                    {
                        pdfFocus.ToExcel(docxFile);

                    } else
                    {
                        MessageBox.Show("ERRO AO CONVERTER ARQUIVO PDF PARA EXCEL, O DOCUMENTO DEVE TER NO MÍNIMO 1 PÁGINA", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }

        }

/*
        private void convertParaJPEG() // JPEG
        {
            this.progressBar1.Value = 66; // progresso da barra
            for (int count = 0; count <= totalArquivosSelecionados; count++)
            {
                if (count == totalArquivosSelecionados)
                {
                    this.progressBar1.Value = 100; // progresso da barra
                    MessageBox.Show("Arquivos Convertidos com Sucesso!", "INFORMAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   // MessageBox.Show("NÃO ESQUEÇA DE REMOVER A ULTIMA LINHA DO DOCUMENTO CONVERTIDO", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // sai do laço para não estourar a posição do vetor em FileStream(listaArquivos[count]
                }

                MemoryStream memoryStream = new MemoryStream();

                SautinSoft.PdfFocus pdfFocus = new SautinSoft.PdfFocus();

                using (FileStream pdfStream = new FileStream(listaArquivos[count], FileMode.Open, FileAccess.Read))
                {
                    pdfFocus.OpenPdf(pdfStream);

                    if (pdfFocus.PageCount > 0)
                    {

                        string docxFile = Path.ChangeExtension(listaArquivos[count], ".jpeg");

                        //pdfFocus.ToImage(memoryStream);
                        pdfFocus.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg;
                        pdfFocus.ImageOptions.Dpi = 200;


                        // File.WriteAllBytes(docxFile, memoryStream.ToArray());
                        pdfFocus.ToImage(docxFile, 1);
                       


                    }
                }

            }

        }
        */

    

        private void cmb_SelectTipoConvert_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmb_SelectTipoConvert.SelectedIndex) // pega o index do item selecionado, começando da posição 0
            {
                case 0: // PDF para DOCX
                    this.pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources.pdf_para_WORD;
                    this.progressBar1.Value = 20;
                    break;

                case 1: // PDF para RTF
                    this.pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources.pdf_para_WORD;
                    this.progressBar1.Value = 20;
                    break;

                case 2: // PDF para Excel
                    this.pictureBox1.Image = null;
                    pictureBox1.Image = Properties.Resources.pdf_para_excel;
                    this.progressBar1.Value = 20;
                    break;
                   

            }
        }
    }
}
