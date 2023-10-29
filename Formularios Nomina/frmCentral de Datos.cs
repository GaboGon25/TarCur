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
        int i = 1;
        int posicion;

        public Central_de_Datos()
        {
            InitializeComponent();
        }
        Empleado empleado = new Empleado();

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten numeros en este campo",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }



        public void CaptarDatos()
        {
            empleado.NumeroEmpleado = int.Parse(txtNumEmpleado.Text);
            empleado.PrimerNombre = txtPrimerNombre.Text;
            empleado.SegundoNombre = txtSegundoNombre.Text;
            empleado.PrimerApellido = txtPrimerApellido.Text;
            empleado.SegundoApellido = txtSegundoApellido.Text;
            empleado.Telefono = int.Parse(txtTelefono.Text);
            empleado.Celular = int.Parse(txtCelular.Text);
            empleado.Cedula = txtCedula.Text;
            empleado.Direccion = txtDireccion.Text;
            empleado.FechaNacimiento = DateTime.Parse(dtpNacimiento.Text);
            empleado.Sexo = cboGenero.Text;
            empleado.EstadoCivil = cboEstadoC.Text;
            empleado.NumeroRUC = int.Parse(txtNumRUC.Text);
            empleado.NumeroINSS = int.Parse(txtNumINSS.Text);
            empleado.SalarioBase = int.Parse(txtSalarioOrdinario.Text);
            empleado.Contratacion = DateTime.Parse(dtpContratacion.Text);
            empleado.CierreContrato = DateTime.Parse(dtpCierreContrato.Text);
            empleado.EstadoLaboral = cboEstadoL.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            dgvRegistro.Rows.Add(txtNumEmpleado.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text,txtTelefono.Text,txtCelular.Text,txtCedula.Text,txtDireccion.Text,dtpNacimiento.Text,cboGenero.Text,cboEstadoC.Text,txtNumRUC.Text,txtNumINSS.Text,txtSalarioOrdinario.Text,dtpContratacion.Text,dtpCierreContrato.Text,cboEstadoL.Text);
        }
    }
}
