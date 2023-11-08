using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TarCur.Datos_y_Metodos;

namespace TarCur
{
    public partial class Central_de_Datos : Form
    {
        List<DatosEmpleado> listaEmpleados = new List<DatosEmpleado>();

        public Central_de_Datos()
        {
            InitializeComponent();
        }

        Validaciones validaciones = new Validaciones();

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarLetras(txtPrimerNombre, e);
        }


        public void BorrarDatos()
        {
            txtNumEmpleado.Clear();
            txtPrimerNombre.Clear();
            txtSegundoNombre.Clear();
            txtPrimerApellido.Clear();
            txtSegundoApellido.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            mtxtCedula.Clear();
            txtDireccion.Clear();
            txtNumRUC.Clear();
            txtNumINSS.Clear();
            txtSalarioOrdinario.Clear();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            listaEmpleados.Add(new DatosEmpleado
            {
                NumeroEmpleado = int.Parse(txtNumEmpleado.Text),
                PrimerNombre = txtPrimerNombre.Text,
                SegundoNombre = txtSegundoNombre.Text,
                PrimerApellido = txtPrimerApellido.Text,
                SegundoApellido = txtSegundoApellido.Text,
                Telefono = int.Parse(txtTelefono.Text),
                Celular = int.Parse(txtCelular.Text),
                Cedula = mtxtCedula.Text,
                Direccion = txtDireccion.Text,
                FechaNacimiento = DateTime.Parse(dtpNacimiento.Text),
                Sexo = cboGenero.Text,
                EstadoCivil = cboEstadoC.Text,
                NumeroRUC = int.Parse(txtNumRUC.Text),
                NumeroINSS = int.Parse(txtNumINSS.Text),
                SalarioBase = int.Parse(txtSalarioOrdinario.Text),
                Contratacion = DateTime.Parse(dtpContratacion.Text),
                CierreContrato = DateTime.Parse(dtpCierreContrato.Text),
                EstadoLaboral = cboEstadoL.Text,
            });
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = listaEmpleados;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            BorrarDatos();

        }

        private void btnNomina_Click(object sender, EventArgs e)
        {
            frmNominaMensual frmNominaMensual = new frmNominaMensual();
            frmNominaMensual.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmNominaSemanal frmNominaSemanal = new frmNominaSemanal();
            frmNominaSemanal.ShowDialog();
        }

        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarLetras(txtSegundoNombre, e);
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarLetras(txtPrimerApellido, e);
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarLetras(txtSegundoApellido, e);

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeros(txtTelefono, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeros(txtCelular, e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarLetras(txtDireccion, e);
        }

        private void txtSalarioOrdinario_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeros(txtSalarioOrdinario, e);
        }

        private void txtNumRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeros(txtNumRUC, e);

        }

        private void txtNumINSS_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeros(txtNumINSS, e);
        }

        private void txtNumEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarNumeros(txtNumEmpleado, e);
        }

        private void mtxtCedula_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Error al introducir el dato");
        }
    }
}
