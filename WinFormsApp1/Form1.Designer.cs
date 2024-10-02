namespace WinFormsApp1
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
            puertos = new ComboBox();
            label1 = new Label();
            btnPuertos = new Button();
            estadoPuerto = new Label();
            activarSemaforo = new Button();
            btnCerrar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // puertos
            // 
            puertos.DropDownStyle = ComboBoxStyle.DropDownList;
            puertos.FlatStyle = FlatStyle.Flat;
            puertos.FormattingEnabled = true;
            puertos.Location = new Point(267, 49);
            puertos.Name = "puertos";
            puertos.Size = new Size(251, 28);
            puertos.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 57);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 1;
            label1.Text = "Seleccionar puerto";
            // 
            // btnPuertos
            // 
            btnPuertos.BackColor = Color.Lime;
            btnPuertos.Location = new Point(693, 48);
            btnPuertos.Name = "btnPuertos";
            btnPuertos.Size = new Size(147, 29);
            btnPuertos.TabIndex = 2;
            btnPuertos.Text = "Abrir puerto";
            btnPuertos.UseVisualStyleBackColor = false;
            btnPuertos.Click += btnPuertos_Click;
            // 
            // estadoPuerto
            // 
            estadoPuerto.Location = new Point(273, 110);
            estadoPuerto.Name = "estadoPuerto";
            estadoPuerto.Size = new Size(245, 36);
            estadoPuerto.TabIndex = 3;
            // 
            // activarSemaforo
            // 
            activarSemaforo.BackColor = Color.FromArgb(0, 192, 0);
            activarSemaforo.ForeColor = SystemColors.ButtonHighlight;
            activarSemaforo.Location = new Point(693, 272);
            activarSemaforo.Name = "activarSemaforo";
            activarSemaforo.Size = new Size(147, 29);
            activarSemaforo.TabIndex = 4;
            activarSemaforo.Text = "Activar Semáforo";
            activarSemaforo.UseVisualStyleBackColor = false;
            activarSemaforo.Click += activarSemaforo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.Location = new Point(693, 146);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(147, 29);
            btnCerrar.TabIndex = 5;
            btnCerrar.Text = "Cerrar puerto";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(693, 371);
            button1.Name = "button1";
            button1.Size = new Size(147, 29);
            button1.TabIndex = 7;
            button1.Text = "Desactivar Semáforo";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 459);
            Controls.Add(button1);
            Controls.Add(btnCerrar);
            Controls.Add(activarSemaforo);
            Controls.Add(estadoPuerto);
            Controls.Add(btnPuertos);
            Controls.Add(label1);
            Controls.Add(puertos);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox puertos;
        private Label label1;
        private Button btnPuertos;
        private Label estadoPuerto;
        private Button activarSemaforo;
        private Button btnCerrar;
        private Button button1;
    }
}
