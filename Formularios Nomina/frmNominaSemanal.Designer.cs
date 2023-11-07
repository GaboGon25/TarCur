namespace TarCur
{
    partial class frmNominaSemanal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            txtheTrabajadasNM = new TextBox();
            label2 = new Label();
            btnCalcular = new Button();
            btnExportar = new Button();
            dgvNominaSemanal = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            Column16 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNominaSemanal).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtheTrabajadasNM);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(34, 39);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(338, 69);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "OTROS DATOS";
            // 
            // txtheTrabajadasNM
            // 
            txtheTrabajadasNM.Location = new Point(173, 31);
            txtheTrabajadasNM.Margin = new Padding(2);
            txtheTrabajadasNM.Name = "txtheTrabajadasNM";
            txtheTrabajadasNM.Size = new Size(150, 27);
            txtheTrabajadasNM.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 20);
            label2.TabIndex = 0;
            label2.Text = "Horas extras trabajadas";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(643, 26);
            btnCalcular.Margin = new Padding(2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(169, 82);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(865, 26);
            btnExportar.Margin = new Padding(2);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(165, 82);
            btnExportar.TabIndex = 6;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // dgvNominaSemanal
            // 
            dgvNominaSemanal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNominaSemanal.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16 });
            dgvNominaSemanal.Location = new Point(1, 169);
            dgvNominaSemanal.Margin = new Padding(2);
            dgvNominaSemanal.Name = "dgvNominaSemanal";
            dgvNominaSemanal.RowHeadersWidth = 82;
            dgvNominaSemanal.RowTemplate.Height = 41;
            dgvNominaSemanal.Size = new Size(1068, 344);
            dgvNominaSemanal.TabIndex = 7;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nº Empleado";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Primer Nombre";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Segundo Nombre";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Primer Apellido";
            Column4.MinimumWidth = 10;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Segundo Apellido";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Salario Base";
            Column6.MinimumWidth = 10;
            Column6.Name = "Column6";
            Column6.Width = 200;
            // 
            // Column7
            // 
            Column7.HeaderText = "Riesgo Laboral";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // Column8
            // 
            Column8.HeaderText = "Nocturnidad";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.Width = 200;
            // 
            // Column9
            // 
            Column9.HeaderText = "Horas Extras";
            Column9.MinimumWidth = 10;
            Column9.Name = "Column9";
            Column9.Width = 200;
            // 
            // Column10
            // 
            Column10.HeaderText = "Antiguedad";
            Column10.MinimumWidth = 10;
            Column10.Name = "Column10";
            Column10.Width = 200;
            // 
            // Column11
            // 
            Column11.HeaderText = "Total Ingresos";
            Column11.MinimumWidth = 10;
            Column11.Name = "Column11";
            Column11.Width = 200;
            // 
            // Column12
            // 
            Column12.HeaderText = "Salario Bruto";
            Column12.MinimumWidth = 10;
            Column12.Name = "Column12";
            Column12.Width = 200;
            // 
            // Column13
            // 
            Column13.HeaderText = "INSS";
            Column13.MinimumWidth = 10;
            Column13.Name = "Column13";
            Column13.Width = 200;
            // 
            // Column14
            // 
            Column14.HeaderText = "IR";
            Column14.MinimumWidth = 10;
            Column14.Name = "Column14";
            Column14.Width = 200;
            // 
            // Column15
            // 
            Column15.HeaderText = "Total Deducciones";
            Column15.MinimumWidth = 10;
            Column15.Name = "Column15";
            Column15.Width = 200;
            // 
            // Column16
            // 
            Column16.HeaderText = "SALARIO NETO";
            Column16.MinimumWidth = 10;
            Column16.Name = "Column16";
            Column16.Width = 200;
            // 
            // frmNominaSemanal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 524);
            Controls.Add(dgvNominaSemanal);
            Controls.Add(btnExportar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox1);
            Name = "frmNominaSemanal";
            Text = "frmNominaSemanal";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNominaSemanal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtheTrabajadasNM;
        private Label label2;
        private Button btnCalcular;
        private Button btnExportar;
        private DataGridView dgvNominaSemanal;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private DataGridViewTextBoxColumn Column16;
    }
}