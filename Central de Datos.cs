using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarCur
{
    public partial class Central_de_Datos : Form
    {
        public Central_de_Datos()
        {
            InitializeComponent();
        }



        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten numeros en este campo",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


    }
}
