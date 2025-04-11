namespace FormularioEstudiantes
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            btnContar = new Button();
            btnEliminarBinding = new Button();
            btnInsertarBinding = new Button();
            btnBinding = new Button();
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
            Id = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            FechaMatricula = new DataGridViewTextBoxColumn();
            EsBecado = new DataGridViewCheckBoxColumn();
            timer1 = new System.Windows.Forms.Timer(components);
            btnIniciar = new Button();
            btnDetener = new Button();
            lblHora = new Label();
            timerHora = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientActiveCaption;
            groupBox1.Controls.Add(btnContar);
            groupBox1.Controls.Add(btnEliminarBinding);
            groupBox1.Controls.Add(btnInsertarBinding);
            groupBox1.Controls.Add(btnBinding);
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
            groupBox1.Size = new Size(583, 200);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Estudiante";
            // 
            // btnContar
            // 
            btnContar.BackColor = SystemColors.GradientActiveCaption;
            btnContar.Location = new Point(481, 125);
            btnContar.Name = "btnContar";
            btnContar.Size = new Size(84, 28);
            btnContar.TabIndex = 12;
            btnContar.Text = "Contar";
            btnContar.UseVisualStyleBackColor = false;
            btnContar.Click += btnContar_Click;
            // 
            // btnEliminarBinding
            // 
            btnEliminarBinding.Location = new Point(477, 158);
            btnEliminarBinding.Name = "btnEliminarBinding";
            btnEliminarBinding.Size = new Size(88, 28);
            btnEliminarBinding.TabIndex = 11;
            btnEliminarBinding.Text = "Eliminar";
            btnEliminarBinding.UseVisualStyleBackColor = true;
            btnEliminarBinding.Click += btnEliminarBinding_Click_1;
            // 
            // btnInsertarBinding
            // 
            btnInsertarBinding.Location = new Point(382, 158);
            btnInsertarBinding.Name = "btnInsertarBinding";
            btnInsertarBinding.Size = new Size(89, 28);
            btnInsertarBinding.TabIndex = 10;
            btnInsertarBinding.Text = "Agregar";
            btnInsertarBinding.UseVisualStyleBackColor = true;
            btnInsertarBinding.Click += btnInsertarBinding_Click;
            // 
            // btnBinding
            // 
            btnBinding.BackColor = SystemColors.GradientActiveCaption;
            btnBinding.Location = new Point(292, 158);
            btnBinding.Name = "btnBinding";
            btnBinding.Size = new Size(84, 28);
            btnBinding.TabIndex = 9;
            btnBinding.Text = "Binding";
            btnBinding.UseVisualStyleBackColor = false;
            btnBinding.Click += btnBinding_Click;
            // 
            // btnListar
            // 
            btnListar.BackColor = SystemColors.Highlight;
            btnListar.Location = new Point(170, 158);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 28);
            btnListar.TabIndex = 8;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = false;
            btnListar.Click += btnListar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = SystemColors.Highlight;
            btnAgregar.Location = new Point(47, 158);
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
            groupBox2.Size = new Size(578, 224);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado de Estudiantes";
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Columns.AddRange(new DataGridViewColumn[] { Id, Nombres, Apellidos, FechaMatricula, EsBecado });
            dgvEstudiantes.Location = new Point(6, 22);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.Size = new Size(566, 196);
            dgvEstudiantes.TabIndex = 0;
            dgvEstudiantes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdEstudiante";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Nombres
            // 
            Nombres.DataPropertyName = "nombres";
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            Nombres.Width = 150;
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "apellidos";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            Apellidos.Width = 150;
            // 
            // FechaMatricula
            // 
            FechaMatricula.DataPropertyName = "fechamat";
            FechaMatricula.HeaderText = "FechaMatricula";
            FechaMatricula.Name = "FechaMatricula";
            FechaMatricula.Width = 110;
            // 
            // EsBecado
            // 
            EsBecado.DataPropertyName = "becado";
            EsBecado.HeaderText = "EsBecado";
            EsBecado.Name = "EsBecado";
            // 
            // timer1
            // 
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.Red;
            btnIniciar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnIniciar.Location = new Point(196, 476);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(75, 32);
            btnIniciar.TabIndex = 2;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnDetener
            // 
            btnDetener.BackColor = Color.Red;
            btnDetener.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDetener.Location = new Point(287, 476);
            btnDetener.Name = "btnDetener";
            btnDetener.Size = new Size(75, 32);
            btnDetener.TabIndex = 3;
            btnDetener.Text = "Detener";
            btnDetener.UseVisualStyleBackColor = false;
            btnDetener.Click += btnDetener_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblHora.Location = new Point(14, 5);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(40, 15);
            lblHora.TabIndex = 4;
            lblHora.Text = "label4";
            // 
            // timerHora
            // 
            timerHora.Interval = 1000;
            timerHora.Tick += timerHora_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 512);
            Controls.Add(lblHora);
            Controls.Add(btnDetener);
            Controls.Add(btnIniciar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn FechaMatricula;
        private DataGridViewCheckBoxColumn EsBecado;
        private Button btnBinding;
        private Button btnEliminarBinding;
        private Button btnInsertarBinding;
        private Button btnContar;
        private System.Windows.Forms.Timer timer1;
        private Button btnIniciar;
        private Button btnDetener;
        private Label lblHora;
        private System.Windows.Forms.Timer timerHora;
    }
}
