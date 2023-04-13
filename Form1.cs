using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramaEventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            numericUpDown1.ValueChanged += CalculateCostCenas;
            checkBox1.CheckedChanged += CalculateCostCenas;
            checkBox2.CheckedChanged += CalculateCostCenas;
            numericUpDown2.ValueChanged += CalculateCostCumpleanos;
            checkBox3.CheckedChanged += CalculateCostCumpleanos;
            textBox2.TextChanged += CalculateCostCumpleanos;
            CalculateCostCenas(null, null);
            CalculateCostCumpleanos(null, null);
            void CalculateCostCenas(object sender, EventArgs e)
            {
                int numPersonas = (int)numericUpDown1.Value;
                bool decoracionLujo = checkBox1.Checked;
                bool opcionSaludable = checkBox2.Checked;

                CenasEmpresa cena = new CenasEmpresa(numPersonas, decoracionLujo, opcionSaludable);
                decimal costeTotal = cena.CalcularCoste();

                textBox1.Text = $"{costeTotal:0.00} €";
            }

            void CalculateCostCumpleanos(object sender, EventArgs e)
            {
                int numPersonas = (int)numericUpDown2.Value;
                bool decoracionLujo = checkBox3.Checked;
                string textoTarta = textBox2.Text;

                Cumpleanos cumple = new Cumpleanos(numPersonas, decoracionLujo, textoTarta);
                decimal costeTotal = cumple.CalcularCoste();

                textBox3.Text = $"{costeTotal:0.00} €";
            }
        }

    }
}
