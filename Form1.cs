using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotapadCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //evennto nuevo/crear
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        //Evento salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //evento abrir
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Filles (.tex)|*.text";
            ofd.Title = "Open a file...";
            if (ofd.ShowDialog() == DialogResult.OK) ;
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        //evento guardar
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = "Text Filles (.tex)|*.text";
            svf.Title = "Save a file...";
            if (svf.ShowDialog() == DialogResult.OK) ;
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter(svf.FileName);
                sw.WriteLine(richTextBox1);
                sw.Close();
            }
        }

        //evento deshacer
        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        //evento rehacer
        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        //enevto cortar
        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        //evento copiar
        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        //evento pegar
        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        //evento seleccionar
        private void seleccionartodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        //variables auxiliares
        Color ColorUtil;
        //metodos auxiliares
        public Color SeleccionDeColor()
        {
            return ColorUtil;
        }
        //objetos auxiliares
        ColorDialog ObjDialog1 = new ColorDialog();

        //eventos
        private void button1_Click(object sender, EventArgs e)
        {
            if (ObjDialog1.ShowDialog() == DialogResult.OK)
            {
                ColorUtil = ObjDialog1.Color;
                SeleccionDeColor();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {/*
            for (int f = 0; f <= 255; f++)
            {
                comboBox1.Items.Add(f.ToString());
                comboBox2.Items.Add(f.ToString());
                comboBox3.Items.Add(f.ToString());
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackColor = ColorUtil;
        }
    }
}
