using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarCur.Datos_y_Metodos
{
    public class Validaciones
    {
        public void ValidarLetras(TextBox textBox, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten numeros en este campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
        public void ValidarNumeros(TextBox textBox, KeyPressEventArgs e) 
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras en este campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

    }
}
