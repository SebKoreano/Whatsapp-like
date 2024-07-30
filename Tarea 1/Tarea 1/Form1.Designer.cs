namespace Tarea_1
{
    partial class CHAT
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
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            puertoDestino = new NumericUpDown();
            mensajeEnvio = new TextBox();
            mensajesRecibidos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)puertoDestino).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(234, 31);
            label1.TabIndex = 0;
            label1.Text = "Redactar Mensaje";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(12, 393);
            button1.Name = "button1";
            button1.Size = new Size(234, 30);
            button1.TabIndex = 1;
            button1.Text = "ENVIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20F);
            label2.Location = new Point(307, 9);
            label2.Name = "label2";
            label2.Size = new Size(254, 31);
            label2.TabIndex = 2;
            label2.Text = "Mensajes Entrantes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15F);
            label3.Location = new Point(12, 58);
            label3.Name = "label3";
            label3.Size = new Size(146, 25);
            label3.TabIndex = 3;
            label3.Text = "Puerto Destino:";
            // 
            // puertoDestino
            // 
            puertoDestino.Location = new Point(162, 60);
            puertoDestino.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            puertoDestino.Name = "puertoDestino";
            puertoDestino.Size = new Size(84, 23);
            puertoDestino.TabIndex = 4;
            puertoDestino.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // mensajeEnvio
            // 
            mensajeEnvio.Location = new Point(12, 107);
            mensajeEnvio.MaxLength = 700;
            mensajeEnvio.Multiline = true;
            mensajeEnvio.Name = "mensajeEnvio";
            mensajeEnvio.Size = new Size(234, 267);
            mensajeEnvio.TabIndex = 5;
            // 
            // mensajesRecibidos
            // 
            mensajesRecibidos.BackColor = SystemColors.Control;
            mensajesRecibidos.Location = new Point(307, 58);
            mensajesRecibidos.Multiline = true;
            mensajesRecibidos.Name = "mensajesRecibidos";
            mensajesRecibidos.ReadOnly = true;
            mensajesRecibidos.Size = new Size(254, 365);
            mensajesRecibidos.TabIndex = 6;
            mensajesRecibidos.TextChanged += mensajesRecibidos_TextChanged;
            // 
            // CHAT
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(573, 435);
            Controls.Add(mensajesRecibidos);
            Controls.Add(mensajeEnvio);
            Controls.Add(puertoDestino);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            MaximumSize = new Size(589, 474);
            MinimumSize = new Size(589, 474);
            Name = "CHAT";
            Text = "Chat";
            Load += CHAT_Load;
            ((System.ComponentModel.ISupportInitialize)puertoDestino).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private NumericUpDown puertoDestino;
        private TextBox mensajeEnvio;
        private TextBox mensajesRecibidos;
    }
}
