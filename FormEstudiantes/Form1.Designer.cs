namespace FormEstudiantes
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
            dgvPersonas = new DataGridView();
            btnListarPer = new Button();
            IdPersona = new DataGridViewTextBoxColumn();
            Nombres = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            FechaNacimiento = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { IdPersona, Nombres, Apellidos, FechaNacimiento });
            dgvPersonas.Location = new Point(11, 95);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(573, 150);
            dgvPersonas.TabIndex = 0;
            // 
            // btnListarPer
            // 
            btnListarPer.Location = new Point(509, 49);
            btnListarPer.Name = "btnListarPer";
            btnListarPer.Size = new Size(75, 23);
            btnListarPer.TabIndex = 1;
            btnListarPer.Text = "Listar";
            btnListarPer.UseVisualStyleBackColor = true;
            btnListarPer.Click += btnListarPer_Click;
            // 
            // IdPersona
            // 
            IdPersona.DataPropertyName = "PersonaId";
            IdPersona.HeaderText = "PersonaId";
            IdPersona.Name = "IdPersona";
            // 
            // Nombres
            // 
            Nombres.DataPropertyName = "Nombres";
            Nombres.HeaderText = "Nombres";
            Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "Apellidos";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.Name = "Apellidos";
            // 
            // FechaNacimiento
            // 
            FechaNacimiento.DataPropertyName = "FechaNacimiento";
            FechaNacimiento.HeaderText = "FechaNacimiento";
            FechaNacimiento.Name = "FechaNacimiento";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 254);
            Controls.Add(btnListarPer);
            Controls.Add(dgvPersonas);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPersonas;
        private Button btnListarPer;
        private DataGridViewTextBoxColumn IdPersona;
        private DataGridViewTextBoxColumn Nombres;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn FechaNacimiento;
    }
}
