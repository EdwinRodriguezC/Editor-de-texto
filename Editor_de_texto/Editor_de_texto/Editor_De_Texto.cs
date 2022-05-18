using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_texto
{
    public partial class Form1 : Form
    {
        public object ComboBox1 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text = r.ToString();

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin Titulo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))

                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void archivo_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void atras_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void adelante_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy(); 
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void eliminarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void color_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog(); 
            if(cl==DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void formatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog(); 
            if (frmt == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font; 
            }
        }

        private void btn_copiar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void seleccionar_tamaño(object sender, EventArgs e)
        {
         
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
