
namespace ConversorPDF
{
    partial class ConversorPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConversorPDF));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CaminhoArquivo = new System.Windows.Forms.TextBox();
            this.cmb_SelectTipoConvert = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pictureLogoNTI = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Converter = new System.Windows.Forms.Button();
            this.btn_BucarArquivo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoNTI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("A Pompadour Sample", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conversor PDF";
            // 
            // txt_CaminhoArquivo
            // 
            this.txt_CaminhoArquivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_CaminhoArquivo.Location = new System.Drawing.Point(161, 86);
            this.txt_CaminhoArquivo.Name = "txt_CaminhoArquivo";
            this.txt_CaminhoArquivo.Size = new System.Drawing.Size(205, 20);
            this.txt_CaminhoArquivo.TabIndex = 1;
            // 
            // cmb_SelectTipoConvert
            // 
            this.cmb_SelectTipoConvert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_SelectTipoConvert.Font = new System.Drawing.Font("A Pompadour Sample", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_SelectTipoConvert.FormattingEnabled = true;
            this.cmb_SelectTipoConvert.Location = new System.Drawing.Point(161, 112);
            this.cmb_SelectTipoConvert.Name = "cmb_SelectTipoConvert";
            this.cmb_SelectTipoConvert.Size = new System.Drawing.Size(232, 22);
            this.cmb_SelectTipoConvert.TabIndex = 5;
            this.cmb_SelectTipoConvert.Text = "Selecione...";
            this.cmb_SelectTipoConvert.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectTipoConvert_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("A Pompadour Sample", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar Arquivos PDF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("A Pompadour Sample", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Formato de Conversão";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 300);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(378, 17);
            this.progressBar1.TabIndex = 7;
            // 
            // pictureLogoNTI
            // 
            this.pictureLogoNTI.Image = global::ConversorPDF.Properties.Resources.NTILogo;
            this.pictureLogoNTI.Location = new System.Drawing.Point(60, 12);
            this.pictureLogoNTI.Name = "pictureLogoNTI";
            this.pictureLogoNTI.Size = new System.Drawing.Size(44, 46);
            this.pictureLogoNTI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureLogoNTI.TabIndex = 9;
            this.pictureLogoNTI.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ConversorPDF.Properties.Resources.pdf_para_WORD;
            this.pictureBox1.Location = new System.Drawing.Point(79, 148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(239, 96);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Converter
            // 
            this.btn_Converter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Converter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Converter.Image = global::ConversorPDF.Properties.Resources.convert3;
            this.btn_Converter.Location = new System.Drawing.Point(126, 259);
            this.btn_Converter.Name = "btn_Converter";
            this.btn_Converter.Size = new System.Drawing.Size(149, 35);
            this.btn_Converter.TabIndex = 4;
            this.btn_Converter.UseVisualStyleBackColor = true;
            this.btn_Converter.Click += new System.EventHandler(this.btn_Converter_Click);
            // 
            // btn_BucarArquivo
            // 
            this.btn_BucarArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BucarArquivo.FlatAppearance.BorderSize = 0;
            this.btn_BucarArquivo.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BucarArquivo.Image = global::ConversorPDF.Properties.Resources.bucar2;
            this.btn_BucarArquivo.Location = new System.Drawing.Point(357, 84);
            this.btn_BucarArquivo.Name = "btn_BucarArquivo";
            this.btn_BucarArquivo.Size = new System.Drawing.Size(37, 24);
            this.btn_BucarArquivo.TabIndex = 2;
            this.btn_BucarArquivo.UseVisualStyleBackColor = true;
            this.btn_BucarArquivo.Click += new System.EventHandler(this.btn_BucarArquivo_Click);
            // 
            // ConversorPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 329);
            this.Controls.Add(this.pictureLogoNTI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_SelectTipoConvert);
            this.Controls.Add(this.btn_Converter);
            this.Controls.Add(this.btn_BucarArquivo);
            this.Controls.Add(this.txt_CaminhoArquivo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConversorPDF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConversorPDF";
            this.Load += new System.EventHandler(this.ConversorPDF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogoNTI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CaminhoArquivo;
        private System.Windows.Forms.Button btn_BucarArquivo;
        private System.Windows.Forms.Button btn_Converter;
        private System.Windows.Forms.ComboBox cmb_SelectTipoConvert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureLogoNTI;
    }
}

