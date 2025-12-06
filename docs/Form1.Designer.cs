namespace Conversor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlTop = new Panel();
            lblArchivoSeleccionado = new Label();
            btnSeleccionar = new Button();
            pnlActions = new Panel();
            btnGuardar = new Button();
            btnDesencriptar = new Button();
            btnEncriptar = new Button();
            btnConvertir = new Button();
            lblTitulo1 = new Label();
            txtTextoExtraido = new TextBox();
            lblTitulo2 = new Label();
            txtTextoEncriptado = new TextBox();
            txtInfoArchivo = new TextBox();
            label1 = new Label();
            pnlTop.SuspendLayout();
            pnlActions.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(45, 45, 45);
            pnlTop.Controls.Add(lblArchivoSeleccionado);
            pnlTop.Controls.Add(btnSeleccionar);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(847, 86);
            pnlTop.TabIndex = 0;
            // 
            // lblArchivoSeleccionado
            // 
            lblArchivoSeleccionado.AutoSize = true;
            lblArchivoSeleccionado.ForeColor = Color.LightGray;
            lblArchivoSeleccionado.Location = new Point(298, 30);
            lblArchivoSeleccionado.Name = "lblArchivoSeleccionado";
            lblArchivoSeleccionado.Size = new Size(161, 15);
            lblArchivoSeleccionado.TabIndex = 1;
            lblArchivoSeleccionado.Text = "Ningun archivo seleccionado";
            lblArchivoSeleccionado.Click += label1_Click;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.BackColor = Color.FromArgb(0, 122, 204);
            btnSeleccionar.FlatStyle = FlatStyle.Flat;
            btnSeleccionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionar.ForeColor = Color.White;
            btnSeleccionar.Image = Properties.Resources.icons8_audio_wave_50__1_;
            btnSeleccionar.ImageAlign = ContentAlignment.MiddleLeft;
            btnSeleccionar.Location = new Point(12, 18);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(258, 39);
            btnSeleccionar.TabIndex = 0;
            btnSeleccionar.Text = "Seleccionar audio...";
            btnSeleccionar.UseVisualStyleBackColor = false;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // pnlActions
            // 
            pnlActions.BackColor = Color.FromArgb(37, 37, 38);
            pnlActions.Controls.Add(btnGuardar);
            pnlActions.Controls.Add(btnDesencriptar);
            pnlActions.Controls.Add(btnEncriptar);
            pnlActions.Controls.Add(btnConvertir);
            pnlActions.Dock = DockStyle.Top;
            pnlActions.Location = new Point(0, 86);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(847, 100);
            pnlActions.TabIndex = 1;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(75, 85, 99);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(604, 19);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(196, 54);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar conversion";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnDesencriptar
            // 
            btnDesencriptar.BackColor = Color.FromArgb(75, 85, 99);
            btnDesencriptar.FlatStyle = FlatStyle.Flat;
            btnDesencriptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDesencriptar.ForeColor = Color.White;
            btnDesencriptar.Image = Properties.Resources.icons8_unlock_32;
            btnDesencriptar.ImageAlign = ContentAlignment.MiddleLeft;
            btnDesencriptar.Location = new Point(390, 19);
            btnDesencriptar.Name = "btnDesencriptar";
            btnDesencriptar.Size = new Size(192, 54);
            btnDesencriptar.TabIndex = 2;
            btnDesencriptar.Text = "Desencriptar";
            btnDesencriptar.UseVisualStyleBackColor = false;
            btnDesencriptar.Click += btnDesencriptar_Click;
            // 
            // btnEncriptar
            // 
            btnEncriptar.BackColor = Color.FromArgb(0, 122, 204);
            btnEncriptar.FlatStyle = FlatStyle.Flat;
            btnEncriptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncriptar.ForeColor = Color.White;
            btnEncriptar.Image = Properties.Resources.icons8_lock_32;
            btnEncriptar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEncriptar.Location = new Point(197, 19);
            btnEncriptar.Name = "btnEncriptar";
            btnEncriptar.Size = new Size(174, 54);
            btnEncriptar.TabIndex = 1;
            btnEncriptar.Text = "Encriptar texto";
            btnEncriptar.UseVisualStyleBackColor = false;
            btnEncriptar.Click += button3_Click;
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.FromArgb(0, 122, 204);
            btnConvertir.FlatStyle = FlatStyle.Flat;
            btnConvertir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConvertir.ForeColor = SystemColors.Control;
            btnConvertir.Image = (Image)resources.GetObject("btnConvertir.Image");
            btnConvertir.ImageAlign = ContentAlignment.MiddleLeft;
            btnConvertir.Location = new Point(12, 19);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(167, 54);
            btnConvertir.TabIndex = 0;
            btnConvertir.Text = "Convertir a texto";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblTitulo1
            // 
            lblTitulo1.AutoSize = true;
            lblTitulo1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo1.ForeColor = Color.Gray;
            lblTitulo1.Location = new Point(12, 200);
            lblTitulo1.Name = "lblTitulo1";
            lblTitulo1.Size = new Size(92, 15);
            lblTitulo1.TabIndex = 2;
            lblTitulo1.Text = "Texto extraído:";
            lblTitulo1.Click += label1_Click_1;
            // 
            // txtTextoExtraido
            // 
            txtTextoExtraido.BackColor = Color.DimGray;
            txtTextoExtraido.ForeColor = Color.White;
            txtTextoExtraido.Location = new Point(30, 218);
            txtTextoExtraido.Multiline = true;
            txtTextoExtraido.Name = "txtTextoExtraido";
            txtTextoExtraido.ReadOnly = true;
            txtTextoExtraido.ScrollBars = ScrollBars.Both;
            txtTextoExtraido.Size = new Size(730, 130);
            txtTextoExtraido.TabIndex = 3;
            txtTextoExtraido.TextChanged += txtTextoExtraido_TextChanged;
            // 
            // lblTitulo2
            // 
            lblTitulo2.AutoSize = true;
            lblTitulo2.BackColor = Color.FromArgb(30, 41, 59);
            lblTitulo2.ForeColor = Color.SeaGreen;
            lblTitulo2.Location = new Point(21, 378);
            lblTitulo2.Name = "lblTitulo2";
            lblTitulo2.Size = new Size(251, 15);
            lblTitulo2.TabIndex = 4;
            lblTitulo2.Text = "Texto encriptado (Base64 / Simulación Fernet):";
            // 
            // txtTextoEncriptado
            // 
            txtTextoEncriptado.BackColor = Color.DarkSlateGray;
            txtTextoEncriptado.ForeColor = Color.MediumSeaGreen;
            txtTextoEncriptado.Location = new Point(30, 412);
            txtTextoEncriptado.Multiline = true;
            txtTextoEncriptado.Name = "txtTextoEncriptado";
            txtTextoEncriptado.ReadOnly = true;
            txtTextoEncriptado.ScrollBars = ScrollBars.Both;
            txtTextoEncriptado.Size = new Size(748, 103);
            txtTextoEncriptado.TabIndex = 5;
            txtTextoEncriptado.Text = "El texto encriptado aparecera aqui...";
            // 
            // txtInfoArchivo
            // 
            txtInfoArchivo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtInfoArchivo.BackColor = Color.Black;
            txtInfoArchivo.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtInfoArchivo.ForeColor = Color.Gray;
            txtInfoArchivo.Location = new Point(12, 569);
            txtInfoArchivo.Multiline = true;
            txtInfoArchivo.Name = "txtInfoArchivo";
            txtInfoArchivo.ReadOnly = true;
            txtInfoArchivo.ScrollBars = ScrollBars.Both;
            txtInfoArchivo.Size = new Size(809, 162);
            txtInfoArchivo.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(42, 542);
            label1.Name = "label1";
            label1.Size = new Size(226, 15);
            label1.TabIndex = 7;
            label1.Text = "info del archivo -bytes (código máquina):";
            label1.Click += label1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(847, 749);
            Controls.Add(label1);
            Controls.Add(txtInfoArchivo);
            Controls.Add(txtTextoEncriptado);
            Controls.Add(lblTitulo2);
            Controls.Add(txtTextoExtraido);
            Controls.Add(lblTitulo1);
            Controls.Add(pnlActions);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            pnlActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlTop;
        private Label lblArchivoSeleccionado;
        private Button btnSeleccionar;
        private Panel pnlActions;
        private Button btnGuardar;
        private Button btnDesencriptar;
        private Button btnEncriptar;
        private Button btnConvertir;
        private Label lblTitulo1;
        private TextBox txtTextoExtraido;
        private Label lblTitulo2;
        private TextBox txtTextoEncriptado;
        private TextBox txtInfoArchivo;
        private Label label1;
    }
}
