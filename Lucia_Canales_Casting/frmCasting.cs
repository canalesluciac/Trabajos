using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucia_Canales_Casting
{
    public partial class frmCasting : Form
    {
        public frmCasting()
        {
            InitializeComponent();
        }

        private void btnCastImplicito_Click(object sender, EventArgs e)
        {
            int entero = Convert.ToInt32(txtInt.Text); // Conversión de string a int

            // Casteo implícito:
            long largo = entero;
            float flotante = entero;
            double doble = entero;
            MessageBox.Show("Entero (original): " + entero + "\nLong: " + largo + "\nFloat: " + flotante + "\nDouble: " + doble);
        }

        private void btnCasteoExplicito_Click(object sender, EventArgs e)
        {
            int entero = Convert.ToInt32(txtInt.Text); // Conversión de string a int

            // Casteo explícito
            char caracter = (char)entero;
            short corto = (short)entero;
            byte nByte = (byte)entero;
            MessageBox.Show("Entero (original): " + entero + "\nShort: " + corto + "\nByte: " + nByte + "\nChar: " + caracter);
        }
    }
}
