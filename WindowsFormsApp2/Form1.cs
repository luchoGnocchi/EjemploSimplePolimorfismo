using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Uva> miListaUva = new List<Uva>();
            miListaUva.Add(new Chinche {origen="chileno", diasSol = 299, polilla_vid = false, saltaMontes = true });
            miListaUva.Add(new Tannat { origen = "Uruguayo (iti)", diasSol = 251, polilla_vid = false });
            miListaUva.Add(new NuevoTipo { origen = "laboratorio INAE", diasSol = 75 });
            foreach (var item in miListaUva)
            {
                listBox1.Items.Add("Es de origen: " + item.origen + " y su calidad es: " + item.calidad());
            }

        }
    }
}
