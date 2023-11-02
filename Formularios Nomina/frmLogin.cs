using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmLogin : Form
    {
        private int intentosRestantes = 5;
        public frmLogin()
        {
            InitializeComponent();
        }

        // IMPORTANTE : de momento el login estara desactivado para no dificultar probar lo que vamos añadiendo
        // se activara al presentar el trabajo, el login ya esta totalmente hecho y probado.
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Dell\\source\\repos\\GaboGon25\\TarCur\\credenciales.txt";
            if (File.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                string usuarioAlmacenado = lines[0].Substring("Usuario: ".Length).Trim();
                string contraseñaAlmacenada = lines[1].Substring("Contraseña: ".Length).Trim();

                string usuarioIngresado = txtNombreUsuario.Text;
                string contraseñaIngresada = txtContraseña.Text;

                if (usuarioIngresado == usuarioAlmacenado && contraseñaIngresada == contraseñaAlmacenada)
                {
                    Central_de_Datos centraldatos = new Central_de_Datos();
                    this.Hide();
                    centraldatos.ShowDialog();
                    this.Close();
                }
                else
                {
                    intentosRestantes--;
                    MessageBox.Show($"Los datos ingresados son incorrectos. Intentos restantes: {intentosRestantes}");
                    txtNombreUsuario.Clear();
                    txtContraseña.Clear();
                    txtNombreUsuario.Focus();

                    if (intentosRestantes == 0)
                    {
                        MessageBox.Show("Los intentos se agotaron. La aplicacion se cerrará.");
                        this.Close();

                    }
                }

            }


        }
    }
}
