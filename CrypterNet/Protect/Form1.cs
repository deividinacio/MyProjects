using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Protect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarServer_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Executavel (*.exe)|*.exe";
                openDialog.Title = "Selecione seu server .NET ...";

                if(openDialog.ShowDialog() == DialogResult.OK)
                {
                    txtServer.Text = openDialog.FileName;
                }
            }
        }

        private void btnBuscarIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "Icon (*.ico)|*.ico"; // verificar se da para colocar png
                openDialog.Title = "Selecione seu server .NET ...";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    txtIcon.Text = openDialog.FileName;
                }
            }
        }

        private void btnKeyGen_Click(object sender, EventArgs e)
        {
            byte[] key = Resources.Tools.CryptConfig.GetKey(16);
            string KeyBase64 = Convert.ToBase64String(key);
            txtKeyGen.Text = KeyBase64;
        }

        private void btnGenIv_Click(object sender, EventArgs e)
        {
            byte[] iv = Resources.Tools.CryptConfig.GetKey(16);
            string IvBase64 = Convert.ToBase64String(iv);
            txtIVGen.Text = IvBase64;
        }
    }
}
