namespace RegistroContactosApp
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
            inputNombre = new TextBox();
            inputTelefono = new TextBox();
            ButtonEnviar = new Button();
            Nombre = new Label();
            Telefono = new Label();
            inputMensaje = new TextBox();
            Mensaje = new Label();
            labelResultado1 = new Label();
            labelResutado2 = new Label();
            labelResultado3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(134, 129);
            inputNombre.MaxLength = 20;
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(200, 23);
            inputNombre.TabIndex = 0;
            inputNombre.TextChanged += InputNombre_TextChanged;
            // 
            // inputTelefono
            // 
            inputTelefono.Location = new Point(134, 184);
            inputTelefono.MaxLength = 8;
            inputTelefono.Name = "inputTelefono";
            inputTelefono.ShortcutsEnabled = false;
            inputTelefono.Size = new Size(200, 23);
            inputTelefono.TabIndex = 1;
            inputTelefono.TextChanged += inputTelefono_TextChanged;
            // 
            // ButtonEnviar
            // 
            ButtonEnviar.Location = new Point(134, 319);
            ButtonEnviar.Name = "ButtonEnviar";
            ButtonEnviar.Size = new Size(200, 35);
            ButtonEnviar.TabIndex = 3;
            ButtonEnviar.Text = "Enviar";
            ButtonEnviar.UseVisualStyleBackColor = true;
            ButtonEnviar.Click += button1_Click;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(134, 111);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.Location = new Point(134, 166);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(53, 15);
            Telefono.TabIndex = 4;
            Telefono.Text = "Teléfono";
            // 
            // inputMensaje
            // 
            inputMensaje.Location = new Point(134, 238);
            inputMensaje.MaxLength = 150;
            inputMensaje.Multiline = true;
            inputMensaje.Name = "inputMensaje";
            inputMensaje.ScrollBars = ScrollBars.Both;
            inputMensaje.Size = new Size(200, 63);
            inputMensaje.TabIndex = 2;
            inputMensaje.TextChanged += inputMensaje_TextChanged;
            // 
            // Mensaje
            // 
            Mensaje.AutoSize = true;
            Mensaje.Location = new Point(134, 221);
            Mensaje.Name = "Mensaje";
            Mensaje.Size = new Size(51, 15);
            Mensaje.TabIndex = 4;
            Mensaje.Text = "Mensaje";
            Mensaje.Click += label3_Click;
            // 
            // labelResultado1
            // 
            labelResultado1.AutoSize = true;
            labelResultado1.Location = new Point(438, 139);
            labelResultado1.Name = "labelResultado1";
            labelResultado1.Size = new Size(0, 15);
            labelResultado1.TabIndex = 5;
            labelResultado1.Click += label1_Click;
            // 
            // labelResutado2
            // 
            labelResutado2.AutoSize = true;
            labelResutado2.Location = new Point(438, 166);
            labelResutado2.Name = "labelResutado2";
            labelResutado2.Size = new Size(0, 15);
            labelResutado2.TabIndex = 6;
            labelResutado2.Click += label1_Click_1;
            // 
            // labelResultado3
            // 
            labelResultado3.Location = new Point(438, 192);
            labelResultado3.MaximumSize = new Size(200, 200);
            labelResultado3.MinimumSize = new Size(200, 0);
            labelResultado3.Name = "labelResultado3";
            labelResultado3.Size = new Size(200, 109);
            labelResultado3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 111);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 5;
            label1.Text = "Resultado:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado3);
            Controls.Add(labelResutado2);
            Controls.Add(label1);
            Controls.Add(labelResultado1);
            Controls.Add(Mensaje);
            Controls.Add(Telefono);
            Controls.Add(Nombre);
            Controls.Add(ButtonEnviar);
            Controls.Add(inputMensaje);
            Controls.Add(inputTelefono);
            Controls.Add(inputNombre);
            Name = "Form1";
            Text = "RegistroContactoApp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNombre;
        private TextBox inputTelefono;
        private Button ButtonEnviar;
        private Label Nombre;
        private Label Telefono;
        private TextBox inputMensaje;
        private Label Mensaje;
        private Label labelResultado1;
        private Label labelResutado2;
        private Label labelResultado3;
        private Label label1;
    }
}
