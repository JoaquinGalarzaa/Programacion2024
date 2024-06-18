namespace GOT_App.Vistas
{
    partial class GestionPersonajes
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
            btnEliminar = new Button();
            btnEditar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            dataGridPersonajes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridPersonajes).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEliminar.Location = new Point(453, 415);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditar.Location = new Point(220, 415);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 8;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSalir.Location = new Point(673, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAgregar.Location = new Point(47, 415);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridPersonajes
            // 
            dataGridPersonajes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPersonajes.BackgroundColor = SystemColors.Control;
            dataGridPersonajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPersonajes.Location = new Point(47, 57);
            dataGridPersonajes.Name = "dataGridPersonajes";
            dataGridPersonajes.ReadOnly = true;
            dataGridPersonajes.RowHeadersVisible = false;
            dataGridPersonajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridPersonajes.Size = new Size(701, 240);
            dataGridPersonajes.TabIndex = 5;
            // 
            // GestionPersonajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnSalir);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridPersonajes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionPersonajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GestionPersonajes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridPersonajes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnEditar;
        private Button btnSalir;
        private Button btnAgregar;
        private DataGridView dataGridPersonajes;
    }
}