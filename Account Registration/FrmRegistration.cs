using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
            InitializePixelFont();  
        }

        private void InitializePixelFont()
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            string fontFilePath = Path.Combine(Application.StartupPath, "CustomFonts", "static", "PixelifySans-Regular.ttf");
            pfc.AddFontFile(fontFilePath);
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
