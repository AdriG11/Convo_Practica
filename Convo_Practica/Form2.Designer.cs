namespace Convo_Practica
{
    partial class Form2
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnLimpiarDoc = new Button();
            btnMostrarDoc = new Button();
            btnGuardarDoc = new Button();
            dgvDocente = new DataGridView();
            txtCodDoc = new TextBox();
            txtFecDoc = new TextBox();
            txtTelfDoc = new TextBox();
            txtApeDoc = new TextBox();
            txtDirDoc = new TextBox();
            txtNomDoc = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnLimpEst = new Button();
            btnMosEst = new Button();
            btnGuarEst = new Button();
            dgvEstudiante = new DataGridView();
            txtCodEst = new TextBox();
            txtFecEst = new TextBox();
            txtTelEst = new TextBox();
            txtApeEst = new TextBox();
            txtDirEst = new TextBox();
            txtNomEst = new TextBox();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            tabPage3 = new TabPage();
            btnLimpiar = new Button();
            txtResult2 = new TextBox();
            txtResult1 = new TextBox();
            label22 = new Label();
            label21 = new Label();
            btnLinq = new Button();
            btnMostraMatricula = new Button();
            btnMatricular = new Button();
            dgvMatricula = new DataGridView();
            txtNota = new TextBox();
            txtAsignatura = new TextBox();
            txtCodigo2 = new TextBox();
            txtCodigo1 = new TextBox();
            txtNomb1 = new TextBox();
            txtNomb = new TextBox();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatricula).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(926, 556);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnLimpiarDoc);
            tabPage1.Controls.Add(btnMostrarDoc);
            tabPage1.Controls.Add(btnGuardarDoc);
            tabPage1.Controls.Add(dgvDocente);
            tabPage1.Controls.Add(txtCodDoc);
            tabPage1.Controls.Add(txtFecDoc);
            tabPage1.Controls.Add(txtTelfDoc);
            tabPage1.Controls.Add(txtApeDoc);
            tabPage1.Controls.Add(txtDirDoc);
            tabPage1.Controls.Add(txtNomDoc);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(918, 523);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Ingreso Docente";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarDoc
            // 
            btnLimpiarDoc.Location = new Point(669, 402);
            btnLimpiarDoc.Name = "btnLimpiarDoc";
            btnLimpiarDoc.Size = new Size(115, 48);
            btnLimpiarDoc.TabIndex = 16;
            btnLimpiarDoc.Text = "Limpiar";
            btnLimpiarDoc.UseVisualStyleBackColor = true;
            btnLimpiarDoc.Click += btnLimpiarDoc_Click;
            // 
            // btnMostrarDoc
            // 
            btnMostrarDoc.Location = new Point(669, 290);
            btnMostrarDoc.Name = "btnMostrarDoc";
            btnMostrarDoc.Size = new Size(115, 48);
            btnMostrarDoc.TabIndex = 15;
            btnMostrarDoc.Text = "Mostrar";
            btnMostrarDoc.UseVisualStyleBackColor = true;
            btnMostrarDoc.Click += btnMostrarDoc_Click;
            // 
            // btnGuardarDoc
            // 
            btnGuardarDoc.Location = new Point(669, 178);
            btnGuardarDoc.Name = "btnGuardarDoc";
            btnGuardarDoc.Size = new Size(115, 48);
            btnGuardarDoc.TabIndex = 14;
            btnGuardarDoc.Text = "Guardar";
            btnGuardarDoc.UseVisualStyleBackColor = true;
            btnGuardarDoc.Click += btnGuardarDoc_Click;
            // 
            // dgvDocente
            // 
            dgvDocente.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDocente.Location = new Point(32, 168);
            dgvDocente.Name = "dgvDocente";
            dgvDocente.RowHeadersWidth = 51;
            dgvDocente.RowTemplate.Height = 29;
            dgvDocente.Size = new Size(538, 319);
            dgvDocente.TabIndex = 13;
            // 
            // txtCodDoc
            // 
            txtCodDoc.Location = new Point(738, 87);
            txtCodDoc.Name = "txtCodDoc";
            txtCodDoc.Size = new Size(148, 27);
            txtCodDoc.TabIndex = 12;
            // 
            // txtFecDoc
            // 
            txtFecDoc.Location = new Point(738, 24);
            txtFecDoc.Name = "txtFecDoc";
            txtFecDoc.Size = new Size(148, 27);
            txtFecDoc.TabIndex = 11;
            // 
            // txtTelfDoc
            // 
            txtTelfDoc.Location = new Point(415, 91);
            txtTelfDoc.Name = "txtTelfDoc";
            txtTelfDoc.Size = new Size(148, 27);
            txtTelfDoc.TabIndex = 10;
            // 
            // txtApeDoc
            // 
            txtApeDoc.Location = new Point(415, 24);
            txtApeDoc.Name = "txtApeDoc";
            txtApeDoc.Size = new Size(148, 27);
            txtApeDoc.TabIndex = 9;
            // 
            // txtDirDoc
            // 
            txtDirDoc.Location = new Point(136, 91);
            txtDirDoc.Name = "txtDirDoc";
            txtDirDoc.Size = new Size(148, 27);
            txtDirDoc.TabIndex = 8;
            // 
            // txtNomDoc
            // 
            txtNomDoc.Location = new Point(136, 21);
            txtNomDoc.Name = "txtNomDoc";
            txtNomDoc.Size = new Size(148, 27);
            txtNomDoc.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(570, 94);
            label7.Name = "label7";
            label7.Size = new Size(139, 20);
            label7.TabIndex = 6;
            label7.Text = "Codigo de Docente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(570, 24);
            label6.Name = "label6";
            label6.Size = new Size(149, 20);
            label6.TabIndex = 5;
            label6.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 275);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(304, 98);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefono";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 24);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 2;
            label3.Text = "Apellido Docente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 98);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 1;
            label2.Text = "Direccion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 21);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Docente";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnLimpEst);
            tabPage2.Controls.Add(btnMosEst);
            tabPage2.Controls.Add(btnGuarEst);
            tabPage2.Controls.Add(dgvEstudiante);
            tabPage2.Controls.Add(txtCodEst);
            tabPage2.Controls.Add(txtFecEst);
            tabPage2.Controls.Add(txtTelEst);
            tabPage2.Controls.Add(txtApeEst);
            tabPage2.Controls.Add(txtDirEst);
            tabPage2.Controls.Add(txtNomEst);
            tabPage2.Controls.Add(label14);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(918, 523);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ingreso Estudiante";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnLimpEst
            // 
            btnLimpEst.Location = new Point(623, 415);
            btnLimpEst.Name = "btnLimpEst";
            btnLimpEst.Size = new Size(119, 55);
            btnLimpEst.TabIndex = 16;
            btnLimpEst.Text = "Limpiar";
            btnLimpEst.UseVisualStyleBackColor = true;
            btnLimpEst.Click += btnLimpEst_Click;
            // 
            // btnMosEst
            // 
            btnMosEst.Location = new Point(623, 293);
            btnMosEst.Name = "btnMosEst";
            btnMosEst.Size = new Size(119, 55);
            btnMosEst.TabIndex = 15;
            btnMosEst.Text = "Mostrar";
            btnMosEst.UseVisualStyleBackColor = true;
            btnMosEst.Click += btnMosEst_Click;
            // 
            // btnGuarEst
            // 
            btnGuarEst.Location = new Point(623, 186);
            btnGuarEst.Name = "btnGuarEst";
            btnGuarEst.Size = new Size(119, 55);
            btnGuarEst.TabIndex = 14;
            btnGuarEst.Text = "Guardar";
            btnGuarEst.UseVisualStyleBackColor = true;
            btnGuarEst.Click += btnGuarEst_Click;
            // 
            // dgvEstudiante
            // 
            dgvEstudiante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiante.Location = new Point(22, 169);
            dgvEstudiante.Name = "dgvEstudiante";
            dgvEstudiante.RowHeadersWidth = 51;
            dgvEstudiante.RowTemplate.Height = 29;
            dgvEstudiante.Size = new Size(526, 301);
            dgvEstudiante.TabIndex = 13;
            // 
            // txtCodEst
            // 
            txtCodEst.Location = new Point(742, 66);
            txtCodEst.Name = "txtCodEst";
            txtCodEst.Size = new Size(147, 27);
            txtCodEst.TabIndex = 12;
            // 
            // txtFecEst
            // 
            txtFecEst.Location = new Point(742, 23);
            txtFecEst.Name = "txtFecEst";
            txtFecEst.Size = new Size(147, 27);
            txtFecEst.TabIndex = 11;
            // 
            // txtTelEst
            // 
            txtTelEst.Location = new Point(430, 67);
            txtTelEst.Name = "txtTelEst";
            txtTelEst.Size = new Size(147, 27);
            txtTelEst.TabIndex = 10;
            // 
            // txtApeEst
            // 
            txtApeEst.Location = new Point(430, 19);
            txtApeEst.Name = "txtApeEst";
            txtApeEst.Size = new Size(147, 27);
            txtApeEst.TabIndex = 9;
            // 
            // txtDirEst
            // 
            txtDirEst.Location = new Point(138, 70);
            txtDirEst.Name = "txtDirEst";
            txtDirEst.Size = new Size(147, 27);
            txtDirEst.TabIndex = 8;
            // 
            // txtNomEst
            // 
            txtNomEst.Location = new Point(138, 23);
            txtNomEst.Name = "txtNomEst";
            txtNomEst.Size = new Size(147, 27);
            txtNomEst.TabIndex = 7;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(291, 26);
            label14.Name = "label14";
            label14.Size = new Size(139, 20);
            label14.TabIndex = 6;
            label14.Text = "Apellido Estudiante";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(322, 70);
            label13.Name = "label13";
            label13.Size = new Size(67, 20);
            label13.TabIndex = 5;
            label13.Text = "Telefono";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(583, 26);
            label12.Name = "label12";
            label12.Size = new Size(149, 20);
            label12.TabIndex = 4;
            label12.Text = "Fecha de Nacimiento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(583, 73);
            label11.Name = "label11";
            label11.Size = new Size(152, 20);
            label11.TabIndex = 3;
            label11.Text = "Codigo de Estudiante";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(430, 251);
            label10.Name = "label10";
            label10.Size = new Size(0, 20);
            label10.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 77);
            label9.Name = "label9";
            label9.Size = new Size(72, 20);
            label9.TabIndex = 1;
            label9.Text = "Direccion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(0, 26);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 0;
            label8.Text = "Nombre Estudiante";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnLimpiar);
            tabPage3.Controls.Add(txtResult2);
            tabPage3.Controls.Add(txtResult1);
            tabPage3.Controls.Add(label22);
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(btnLinq);
            tabPage3.Controls.Add(btnMostraMatricula);
            tabPage3.Controls.Add(btnMatricular);
            tabPage3.Controls.Add(dgvMatricula);
            tabPage3.Controls.Add(txtNota);
            tabPage3.Controls.Add(txtAsignatura);
            tabPage3.Controls.Add(txtCodigo2);
            tabPage3.Controls.Add(txtCodigo1);
            tabPage3.Controls.Add(txtNomb1);
            tabPage3.Controls.Add(txtNomb);
            tabPage3.Controls.Add(label20);
            tabPage3.Controls.Add(label19);
            tabPage3.Controls.Add(label18);
            tabPage3.Controls.Add(label17);
            tabPage3.Controls.Add(label16);
            tabPage3.Controls.Add(label15);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(918, 523);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ingreso de Matricula";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(755, 301);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(129, 53);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtResult2
            // 
            txtResult2.Location = new Point(808, 431);
            txtResult2.Name = "txtResult2";
            txtResult2.Size = new Size(79, 27);
            txtResult2.TabIndex = 19;
            // 
            // txtResult1
            // 
            txtResult1.Location = new Point(808, 370);
            txtResult1.Name = "txtResult1";
            txtResult1.Size = new Size(79, 27);
            txtResult1.TabIndex = 18;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(707, 438);
            label22.Name = "label22";
            label22.Size = new Size(95, 20);
            label22.TabIndex = 17;
            label22.Text = "Reprobrados";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(707, 373);
            label21.Name = "label21";
            label21.Size = new Size(83, 20);
            label21.TabIndex = 16;
            label21.Text = "Aprobados";
            // 
            // btnLinq
            // 
            btnLinq.Location = new Point(755, 238);
            btnLinq.Name = "btnLinq";
            btnLinq.Size = new Size(129, 57);
            btnLinq.TabIndex = 15;
            btnLinq.Text = "LINQ";
            btnLinq.UseVisualStyleBackColor = true;
            btnLinq.Click += btnLinq_Click;
            // 
            // btnMostraMatricula
            // 
            btnMostraMatricula.Location = new Point(757, 175);
            btnMostraMatricula.Name = "btnMostraMatricula";
            btnMostraMatricula.Size = new Size(129, 57);
            btnMostraMatricula.TabIndex = 14;
            btnMostraMatricula.Text = "Mostar Matricula";
            btnMostraMatricula.UseVisualStyleBackColor = true;
            btnMostraMatricula.Click += btnMostraMatricula_Click;
            // 
            // btnMatricular
            // 
            btnMatricular.Location = new Point(757, 112);
            btnMatricular.Name = "btnMatricular";
            btnMatricular.Size = new Size(129, 57);
            btnMatricular.TabIndex = 13;
            btnMatricular.Text = "Matricular";
            btnMatricular.UseVisualStyleBackColor = true;
            btnMatricular.Click += btnMatricular_Click;
            // 
            // dgvMatricula
            // 
            dgvMatricula.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMatricula.Location = new Point(17, 137);
            dgvMatricula.Name = "dgvMatricula";
            dgvMatricula.RowHeadersWidth = 51;
            dgvMatricula.RowTemplate.Height = 29;
            dgvMatricula.Size = new Size(684, 367);
            dgvMatricula.TabIndex = 12;
            // 
            // txtNota
            // 
            txtNota.Location = new Point(755, 69);
            txtNota.Name = "txtNota";
            txtNota.Size = new Size(160, 27);
            txtNota.TabIndex = 11;
            // 
            // txtAsignatura
            // 
            txtAsignatura.Location = new Point(755, 15);
            txtAsignatura.Name = "txtAsignatura";
            txtAsignatura.Size = new Size(160, 27);
            txtAsignatura.TabIndex = 10;
            // 
            // txtCodigo2
            // 
            txtCodigo2.Location = new Point(495, 72);
            txtCodigo2.Name = "txtCodigo2";
            txtCodigo2.Size = new Size(160, 27);
            txtCodigo2.TabIndex = 9;
            // 
            // txtCodigo1
            // 
            txtCodigo1.Location = new Point(495, 18);
            txtCodigo1.Name = "txtCodigo1";
            txtCodigo1.Size = new Size(160, 27);
            txtCodigo1.TabIndex = 8;
            // 
            // txtNomb1
            // 
            txtNomb1.Location = new Point(171, 72);
            txtNomb1.Name = "txtNomb1";
            txtNomb1.Size = new Size(160, 27);
            txtNomb1.TabIndex = 7;
            // 
            // txtNomb
            // 
            txtNomb.Location = new Point(171, 15);
            txtNomb.Name = "txtNomb";
            txtNomb.Size = new Size(160, 27);
            txtNomb.TabIndex = 6;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(673, 18);
            label20.Name = "label20";
            label20.Size = new Size(80, 20);
            label20.TabIndex = 5;
            label20.Text = "Asignatura";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(337, 84);
            label19.Name = "label19";
            label19.Size = new Size(139, 20);
            label19.TabIndex = 4;
            label19.Text = "Codigo de Docente";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(673, 79);
            label18.Name = "label18";
            label18.Size = new Size(42, 20);
            label18.TabIndex = 3;
            label18.Text = "Nota";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(337, 18);
            label17.Name = "label17";
            label17.Size = new Size(152, 20);
            label17.TabIndex = 2;
            label17.Text = "Codigo de Estudiante";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 72);
            label16.Name = "label16";
            label16.Size = new Size(149, 20);
            label16.TabIndex = 1;
            label16.Text = "Nombre del Docente";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 18);
            label15.Name = "label15";
            label15.Size = new Size(162, 20);
            label15.TabIndex = 0;
            label15.Text = "Nombre del Estudiante";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 580);
            Controls.Add(tabControl1);
            Name = "Form2";
            Text = "Form2";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDocente).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiante).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMatricula).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnLimpiarDoc;
        private Button btnMostrarDoc;
        private Button btnGuardarDoc;
        private DataGridView dgvDocente;
        private TextBox txtCodDoc;
        private TextBox txtFecDoc;
        private TextBox txtTelfDoc;
        private TextBox txtApeDoc;
        private TextBox txtDirDoc;
        private TextBox txtNomDoc;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button btnLimpEst;
        private Button btnMosEst;
        private Button btnGuarEst;
        private DataGridView dgvEstudiante;
        private TextBox txtCodEst;
        private TextBox txtFecEst;
        private TextBox txtTelEst;
        private TextBox txtApeEst;
        private TextBox txtDirEst;
        private TextBox txtNomEst;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Button btnLinq;
        private Button btnMostraMatricula;
        private Button btnMatricular;
        private DataGridView dgvMatricula;
        private TextBox txtNota;
        private TextBox txtAsignatura;
        private TextBox txtCodigo2;
        private TextBox txtCodigo1;
        private TextBox txtNomb1;
        private TextBox txtNomb;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private TextBox txtResult2;
        private TextBox txtResult1;
        private Label label22;
        private Label label21;
        private Button btnLimpiar;
    }
}