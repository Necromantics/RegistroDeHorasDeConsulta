
namespace CapaPresentacion
{
    partial class FormAgregarEditarRegistro
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.txtCarnet = new System.Windows.Forms.TextBox();
            this.txtTemaConsulta = new System.Windows.Forms.TextBox();
            this.txtCantidadEstudiantes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.checkAprobacion = new System.Windows.Forms.CheckBox();
            this.txtSemana = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.55614F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.44386F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(376, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnCancelar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInsertar, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 280);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(370, 27);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCancelar.Location = new System.Drawing.Point(240, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 21);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInsertar.Location = new System.Drawing.Point(55, 3);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(75, 21);
            this.btnInsertar.TabIndex = 0;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estudiante";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.txtObservacion, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtCarnet, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtTemaConsulta, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtCantidadEstudiantes, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.txtSemana, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbTipoConsulta, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.dtpFecha, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.checkAprobacion, 1, 7);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(364, 252);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtObservacion
            // 
            this.txtObservacion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObservacion.Location = new System.Drawing.Point(133, 160);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(228, 59);
            this.txtObservacion.TabIndex = 14;
            // 
            // txtCarnet
            // 
            this.txtCarnet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCarnet.Location = new System.Drawing.Point(133, 134);
            this.txtCarnet.Name = "txtCarnet";
            this.txtCarnet.Size = new System.Drawing.Size(85, 20);
            this.txtCarnet.TabIndex = 13;
            // 
            // txtTemaConsulta
            // 
            this.txtTemaConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTemaConsulta.Location = new System.Drawing.Point(133, 82);
            this.txtTemaConsulta.Name = "txtTemaConsulta";
            this.txtTemaConsulta.Size = new System.Drawing.Size(228, 20);
            this.txtTemaConsulta.TabIndex = 11;
            // 
            // txtCantidadEstudiantes
            // 
            this.txtCantidadEstudiantes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCantidadEstudiantes.Location = new System.Drawing.Point(133, 29);
            this.txtCantidadEstudiantes.Name = "txtCantidadEstudiantes";
            this.txtCantidadEstudiantes.Size = new System.Drawing.Size(46, 20);
            this.txtCantidadEstudiantes.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. de semana:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de estudiantes:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de consulta:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tema de consulta:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Carnet del estudiante:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Observación:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Aprobación:";
            // 
            // cbTipoConsulta
            // 
            this.cbTipoConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbTipoConsulta.FormattingEnabled = true;
            this.cbTipoConsulta.Items.AddRange(new object[] {
            "Presencial",
            "En línea"});
            this.cbTipoConsulta.Location = new System.Drawing.Point(133, 55);
            this.cbTipoConsulta.Name = "cbTipoConsulta";
            this.cbTipoConsulta.Size = new System.Drawing.Size(228, 21);
            this.cbTipoConsulta.TabIndex = 10;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(133, 108);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(228, 20);
            this.dtpFecha.TabIndex = 12;
            // 
            // checkAprobacion
            // 
            this.checkAprobacion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkAprobacion.AutoSize = true;
            this.checkAprobacion.Location = new System.Drawing.Point(133, 230);
            this.checkAprobacion.Name = "checkAprobacion";
            this.checkAprobacion.Size = new System.Drawing.Size(15, 14);
            this.checkAprobacion.TabIndex = 15;
            this.checkAprobacion.UseVisualStyleBackColor = true;
            // 
            // txtSemana
            // 
            this.txtSemana.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSemana.Location = new System.Drawing.Point(133, 3);
            this.txtSemana.Name = "txtSemana";
            this.txtSemana.Size = new System.Drawing.Size(46, 20);
            this.txtSemana.TabIndex = 8;
            // 
            // FormAgregarEditarRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 310);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAgregarEditarRegistro";
            this.ShowInTaskbar = false;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.FormAgregarEditarRegistro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.CheckBox checkAprobacion;
        private System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.TextBox txtSemana;
        public System.Windows.Forms.TextBox txtCantidadEstudiantes;
        public System.Windows.Forms.ComboBox cbTipoConsulta;
        public System.Windows.Forms.TextBox txtObservacion;
        public System.Windows.Forms.TextBox txtCarnet;
        public System.Windows.Forms.TextBox txtTemaConsulta;
        public System.Windows.Forms.DateTimePicker dtpFecha;
    }
}