using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCalculadora
{
    public partial class frmCalculadora : Form
    {
        //Mi objeto
        clsCalculadora calc = new clsCalculadora();
		ClsResta calcR = new ClsResta();
		public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            //Esto se ocupa atraves del constructor (opcion 1)
            //Mi objeto:
            //clsCalculadora calc = new clsCalculadora(float.Parse(txtN1.Text), float.Parse(txtN2.Text));
            //txtResultado.Text = calc.Sumar().ToString();

            //Esto es la segunda opc 2
            // Esto como ya esta englobado en la parte de arriba no es necesario que este aqui pero puede ser una opcion: clsCalculadora calc = new clsCalculadora();
            calc.Numero1 = float.Parse(txtN1.Text);
            calc.Numero2 = float.Parse(txtN2.Text);
            txtResultado.Text = calc.Sumar().ToString();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            // Lo mismo que lo anterior: clsCalculadora calc = new clsCalculadora();
            calcR.Numero1 = float.Parse(txtN1.Text);
            calcR.Numero2 = float.Parse(txtN2.Text);
            txtResultado.Text = calcR.Restar().ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            //Lo mismo que lo anterior: clsCalculadora calc = new clsCalculadora();
            calc.Numero1 = float.Parse(txtN1.Text);
            calc.Numero2 = float.Parse(txtN2.Text);
            txtResultado.Text = calc.Multiplicar().ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            //Lo mismo que lo anterior: clsCalculadora calc = new clsCalculadora();
            calc.Numero1 = float.Parse(txtN1.Text);
            calc.Numero2 = float.Parse(txtN2.Text);
            txtResultado.Text = calc.Dividir().ToString();
        }
    }
}
