﻿using System;
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
        int i = 1;
        int posicion;

        public Central_de_Datos()
        {
            InitializeComponent();
        }
        Empleado empleado = new Empleado();
        Validaciones validaciones = new Validaciones();

        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.ValidarLetras(txtPrimerNombre, e);
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

        public void GuardarDatos()
        {
            dgvRegistro.Rows.Add(txtNumEmpleado.Text, txtPrimerNombre.Text, txtSegundoNombre.Text, txtPrimerApellido.Text, txtSegundoApellido.Text, txtTelefono.Text, txtCelular.Text, txtCedula.Text, txtDireccion.Text, dtpNacimiento.Text, cboGenero.Text, cboEstadoC.Text, txtNumRUC.Text, txtNumINSS.Text, txtSalarioOrdinario.Text, dtpContratacion.Text, dtpCierreContrato.Text, cboEstadoL.Text);

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
            txtCedula.Clear();
            txtDireccion.Clear();
            txtNumRUC.Clear();
            txtNumINSS.Clear();
            txtSalarioOrdinario.Clear();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
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
    }
}
