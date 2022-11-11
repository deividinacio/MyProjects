
namespace Protect
{
    partial class Form1
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
            this.btnBuscarServer = new System.Windows.Forms.Button();
            this.btnBuscarIcon = new System.Windows.Forms.Button();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompilar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKeyGen = new System.Windows.Forms.TextBox();
            this.btnKeyGen = new System.Windows.Forms.Button();
            this.txtIVGen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGenIv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBuscarServer
            // 
            this.btnBuscarServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarServer.ForeColor = System.Drawing.Color.White;
            this.btnBuscarServer.Location = new System.Drawing.Point(567, 113);
            this.btnBuscarServer.Name = "btnBuscarServer";
            this.btnBuscarServer.Size = new System.Drawing.Size(135, 36);
            this.btnBuscarServer.TabIndex = 0;
            this.btnBuscarServer.Text = "Buscar";
            this.btnBuscarServer.UseVisualStyleBackColor = true;
            this.btnBuscarServer.Click += new System.EventHandler(this.btnBuscarServer_Click);
            // 
            // btnBuscarIcon
            // 
            this.btnBuscarIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarIcon.ForeColor = System.Drawing.Color.White;
            this.btnBuscarIcon.Location = new System.Drawing.Point(567, 205);
            this.btnBuscarIcon.Name = "btnBuscarIcon";
            this.btnBuscarIcon.Size = new System.Drawing.Size(135, 36);
            this.btnBuscarIcon.TabIndex = 0;
            this.btnBuscarIcon.Text = "Buscar";
            this.btnBuscarIcon.UseVisualStyleBackColor = true;
            this.btnBuscarIcon.Click += new System.EventHandler(this.btnBuscarIcon_Click);
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(118, 113);
            this.txtServer.Multiline = true;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(426, 36);
            this.txtServer.TabIndex = 1;
            this.txtServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(118, 205);
            this.txtIcon.Multiline = true;
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(426, 36);
            this.txtIcon.TabIndex = 2;
            this.txtIcon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 52);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Binario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(36, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Icon:";
            // 
            // btnCompilar
            // 
            this.btnCompilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompilar.ForeColor = System.Drawing.Color.White;
            this.btnCompilar.Location = new System.Drawing.Point(118, 452);
            this.btnCompilar.Name = "btnCompilar";
            this.btnCompilar.Size = new System.Drawing.Size(584, 42);
            this.btnCompilar.TabIndex = 5;
            this.btnCompilar.Text = "Compilar";
            this.btnCompilar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(36, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "KeyGen:";
            // 
            // txtKeyGen
            // 
            this.txtKeyGen.Location = new System.Drawing.Point(118, 300);
            this.txtKeyGen.Multiline = true;
            this.txtKeyGen.Name = "txtKeyGen";
            this.txtKeyGen.Size = new System.Drawing.Size(426, 36);
            this.txtKeyGen.TabIndex = 7;
            this.txtKeyGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnKeyGen
            // 
            this.btnKeyGen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeyGen.ForeColor = System.Drawing.Color.White;
            this.btnKeyGen.Location = new System.Drawing.Point(567, 300);
            this.btnKeyGen.Name = "btnKeyGen";
            this.btnKeyGen.Size = new System.Drawing.Size(135, 36);
            this.btnKeyGen.TabIndex = 6;
            this.btnKeyGen.Text = "Gerar Chave";
            this.btnKeyGen.UseVisualStyleBackColor = true;
            this.btnKeyGen.Click += new System.EventHandler(this.btnKeyGen_Click);
            // 
            // txtIVGen
            // 
            this.txtIVGen.Location = new System.Drawing.Point(118, 386);
            this.txtIVGen.Multiline = true;
            this.txtIVGen.Name = "txtIVGen";
            this.txtIVGen.Size = new System.Drawing.Size(426, 36);
            this.txtIVGen.TabIndex = 7;
            this.txtIVGen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(36, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Iv:";
            // 
            // btnGenIv
            // 
            this.btnGenIv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenIv.ForeColor = System.Drawing.Color.White;
            this.btnGenIv.Location = new System.Drawing.Point(567, 386);
            this.btnGenIv.Name = "btnGenIv";
            this.btnGenIv.Size = new System.Drawing.Size(135, 36);
            this.btnGenIv.TabIndex = 9;
            this.btnGenIv.Text = "Gerar Chave";
            this.btnGenIv.UseVisualStyleBackColor = true;
            this.btnGenIv.Click += new System.EventHandler(this.btnGenIv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(901, 520);
            this.Controls.Add(this.btnGenIv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIVGen);
            this.Controls.Add(this.txtKeyGen);
            this.Controls.Add(this.btnKeyGen);
            this.Controls.Add(this.btnCompilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.btnBuscarIcon);
            this.Controls.Add(this.btnBuscarServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarServer;
        private System.Windows.Forms.Button btnBuscarIcon;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompilar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKeyGen;
        private System.Windows.Forms.Button btnKeyGen;
        private System.Windows.Forms.TextBox txtIVGen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGenIv;
    }
}

