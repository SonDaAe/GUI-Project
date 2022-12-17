using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SoundPlayer player = new SoundPlayer(@"C:\Users\USER\source\방법.wav");
        private void Form3_Load(object sender, EventArgs e)
        {
            player.Play();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Stop();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Application.OpenForms["Form3"].Close();
        }
    }
}