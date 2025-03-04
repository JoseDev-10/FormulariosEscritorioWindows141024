﻿namespace FormularioEstudiantes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnListar = new Button();
            btnAgregar = new Button();
            chkBecado = new CheckBox();
            dtpFechaMatricula = new DateTimePicker();
            texApellidos = new TextBox();
            texNombres = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            dgvEstudiantes = new DataGridView();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            EsBecado = new DataGridViewCheckBoxColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnListar);
            groupBox1.Controls.Add(btnAgregar);
            groupBox1.Controls.Add(chkBecado);
            groupBox1.Controls.Add(dtpFechaMatricula);
            groupBox1.Controls.Add(texApellidos);
            groupBox1.Controls.Add(texNombres);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 25);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(553, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Estudiante";
            // 
            // btnListar
            // 
            btnListar.BackColor = SystemColors.Highlight;
            btnListar.Location = new Point(287, 158);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 28);
            btnListar.TabIndex = 8;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Highlight;
            btnAgregar.Location = new Point(170, 158);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 28);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // chkBecado
            // 
            chkBecado.AutoSize = true;
            chkBecado.Location = new Point(171, 125);
            chkBecado.Name = "chkBecado";
            chkBecado.Size = new Size(76, 19);
            chkBecado.TabIndex = 6;
            chkBecado.Text = "EsBecado";
            chkBecado.UseVisualStyleBackColor = true;
            chkBecado.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // dtpFechaMatricula
            // 
            dtpFechaMatricula.Location = new Point(170, 87);
            dtpFechaMatricula.Name = "dtpFechaMatricula";
            dtpFechaMatricula.Size = new Size(314, 23);
            dtpFechaMatricula.TabIndex = 5;
            // 
            // texApellidos
            // 
            texApellidos.Location = new Point(170, 54);
            texApellidos.Name = "texApellidos";
            texApellidos.Size = new Size(314, 23);
            texApellidos.TabIndex = 4;
            texApellidos.TextChanged += textBox2_TextChanged;
            // 
            // texNombres
            // 
            texNombres.Location = new Point(170, 19);
            texNombres.Name = "texNombres";
            texNombres.Size = new Size(314, 23);
            texNombres.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 95);
            label3.Name = "label3";
            label3.Size = new Size(91, 15);
            label3.TabIndex = 2;
            label3.Text = "Fecha Matrícula";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientActiveCaption;
            label2.Location = new Point(47, 62);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(47, 27);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvEstudiantes);
            groupBox2.Location = new Point(17, 246);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(548, 224);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de Estudiantes";
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { Nombres, Apellidos, FechaNacimiento, EsBecado });
            dgvEstudiantes.Location = new Point(6, 22);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.Size = new Size(535, 196);
            dgvEstudiantes.TabIndex = 0;
            dgvEstudiantes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Nombres
            // 
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            Nombres.Width = 150;
            // 
            // Apellidos
            // 
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 150;
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.HeaderText = "FechaNacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            FechaNacimiento.Width = 110;
            // 
            // EsBecado
            // 
            EsBecado.HeaderText = "EsBecado";
            EsBecado.Name = "EsBecado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 482);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label label3;
        private Label label2;
        private TextBox texApellidos;
        private TextBox texNombres;
        private CheckBox chkBecado;
        private DateTimePicker dtpFechaMatricula;
        private Button btnListar;
        private Button btnAgregar;
        private GroupBox groupBox2;
        private DataGridView dgvEstudiantes;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn FechaNacimiento;
        private DataGridViewCheckBoxColumn EsBecado;
    }
}
