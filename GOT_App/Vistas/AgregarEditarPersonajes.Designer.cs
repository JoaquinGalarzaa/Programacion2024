namespace GOT_App.Vistas
{
    partial class AgregarEditarPersonajes
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
            pictureBoxFoto = new PictureBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            numericEdad = new NumericUpDown();
            txtAlias = new TextBox();
            txtFotoUrl = new TextBox();
            txtNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            pictureBoxEmblema = new PictureBox();
            txtEmblema = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmblema).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(406, 468);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(313, 204);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFoto.TabIndex = 25;
            pictureBoxFoto.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.BackColor = SystemColors.Window;
            btnCancelar.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 9F);
            btnCancelar.ForeColor = SystemColors.ActiveCaptionText;
            btnCancelar.Location = new Point(779, 711);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnGuardar.BackColor = SystemColors.Window;
            btnGuardar.FlatAppearance.BorderColor = Color.White;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F);
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(331, 711);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(86, 23);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.TopCenter;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // numericEdad
            // 
            numericEdad.Location = new Point(528, 157);
            numericEdad.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericEdad.Name = "numericEdad";
            numericEdad.Size = new Size(120, 23);
            numericEdad.TabIndex = 22;
            // 
            // txtAlias
            // 
            txtAlias.Location = new Point(528, 218);
            txtAlias.Name = "txtAlias";
            txtAlias.Size = new Size(409, 23);
            txtAlias.TabIndex = 20;
            // 
            // txtFotoUrl
            // 
            txtFotoUrl.Location = new Point(528, 284);
            txtFotoUrl.Name = "txtFotoUrl";
            txtFotoUrl.Size = new Size(409, 23);
            txtFotoUrl.TabIndex = 19;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(530, 90);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(409, 23);
            txtNombre.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(344, 276);
            label4.Name = "label4";
            label4.Size = new Size(83, 31);
            label4.TabIndex = 16;
            label4.Text = "Foto URL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(344, 210);
            label3.Name = "label3";
            label3.Size = new Size(56, 31);
            label3.TabIndex = 15;
            label3.Text = "Alias:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(344, 149);
            label2.Name = "label2";
            label2.Size = new Size(54, 31);
            label2.TabIndex = 14;
            label2.Text = "Edad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, -48);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 13;
            label1.Text = "NOMBRE COMPLETO:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(344, 85);
            label6.Name = "label6";
            label6.Size = new Size(74, 31);
            label6.TabIndex = 26;
            label6.Text = "Nombre";
            // 
            // pictureBoxEmblema
            // 
            pictureBoxEmblema.Location = new Point(751, 468);
            pictureBoxEmblema.Name = "pictureBoxEmblema";
            pictureBoxEmblema.Size = new Size(313, 204);
            pictureBoxEmblema.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxEmblema.TabIndex = 27;
            pictureBoxEmblema.TabStop = false;
            // 
            // txtEmblema
            // 
            txtEmblema.Location = new Point(528, 368);
            txtEmblema.Name = "txtEmblema";
            txtEmblema.Size = new Size(409, 23);
            txtEmblema.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Agency FB", 18F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(344, 360);
            label5.Name = "label5";
            label5.Size = new Size(86, 31);
            label5.TabIndex = 28;
            label5.Text = "Emblema:";
            // 
            // AgregarEditarPersonajes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1120, 746);
            Controls.Add(txtEmblema);
            Controls.Add(label5);
            Controls.Add(pictureBoxEmblema);
            Controls.Add(label6);
            Controls.Add(pictureBoxFoto);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(numericEdad);
            Controls.Add(txtAlias);
            Controls.Add(txtFotoUrl);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarEditarPersonajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AgregarEditarPersonajes";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxEmblema).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxFoto;
        private Button btnCancelar;
        private Button btnGuardar;
        private NumericUpDown numericEdad;
        private TextBox txtAlias;
        private TextBox txtFotoUrl;
        private TextBox txtNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private PictureBox pictureBoxEmblema;
        private TextBox txtEmblema;
        private Label label5;
    }
}