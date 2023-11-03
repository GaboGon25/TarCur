namespace TarCur
{
    partial class frmNominaMensual
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
            dataGridView1 = new DataGridView();
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
            btnCalcular = new Button();
            btnExportar = new Button();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtheTrabajadasNM = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12, Column13, Column14, Column15, Column16 });
            dataGridView1.Location = new Point(62, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1735, 446);
            dataGridView1.TabIndex = 0;
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
            // btnCalcular
            // 
            btnCalcular.Location = new Point(1249, 57);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(274, 132);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "CALCULAR";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(1529, 57);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(268, 132);
            btnExportar.TabIndex = 2;
            btnExportar.Text = "EXPORTAR";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtheTrabajadasNM);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(670, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(549, 110);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "OTROS DATOS";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 52);
            label1.Name = "label1";
            label1.Size = new Size(259, 32);
            label1.TabIndex = 0;
            label1.Text = "Horas extras trabajadas";
            // 
            // txtheTrabajadasNM
            // 
            txtheTrabajadasNM.Location = new Point(281, 49);
            txtheTrabajadasNM.Name = "txtheTrabajadasNM";
            txtheTrabajadasNM.Size = new Size(242, 39);
            txtheTrabajadasNM.TabIndex = 1;
            // 
            // frmNominaMensual
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1836, 747);
            Controls.Add(groupBox1);
            Controls.Add(btnExportar);
            Controls.Add(btnCalcular);
            Controls.Add(dataGridView1);
            Name = "frmNominaMensual";
            Text = "frmNominaMensual";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
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
        private Button btnCalcular;
        private Button btnExportar;
        private GroupBox groupBox1;
        private TextBox txtheTrabajadasNM;
        private Label label1;
    }
}