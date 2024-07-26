namespace Tarea_ExtraClase__1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Mensaje = new System.Windows.Forms.TextBox();
            this.ENVIAR = new System.Windows.Forms.Button();
            this.Puerto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox3.Location = new System.Drawing.Point(314, 12);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(263, 31);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Puerto Destino:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Redactar Mensaje";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label3.Location = new System.Drawing.Point(307, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mensajes Entrantes";
            // 
            // Mensaje
            // 
            this.Mensaje.Location = new System.Drawing.Point(17, 111);
            this.Mensaje.Multiline = true;
            this.Mensaje.Name = "Mensaje";
            this.Mensaje.Size = new System.Drawing.Size(228, 249);
            this.Mensaje.TabIndex = 7;
            this.Mensaje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ENVIAR
            // 
            this.ENVIAR.Location = new System.Drawing.Point(17, 375);
            this.ENVIAR.Name = "ENVIAR";
            this.ENVIAR.Size = new System.Drawing.Size(228, 40);
            this.ENVIAR.TabIndex = 8;
            this.ENVIAR.Text = "ENVIAR";
            this.ENVIAR.UseVisualStyleBackColor = true;
            this.ENVIAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // Puerto
            // 
            this.Puerto.Location = new System.Drawing.Point(157, 78);
            this.Puerto.Name = "Puerto";
            this.Puerto.Size = new System.Drawing.Size(87, 20);
            this.Puerto.TabIndex = 9;
            this.Puerto.TextChanged += new System.EventHandler(this.Puerto_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 435);
            this.Controls.Add(this.Puerto);
            this.Controls.Add(this.ENVIAR);
            this.Controls.Add(this.Mensaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Name = "Form1";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Mensaje;
        private System.Windows.Forms.Button ENVIAR;
        private System.Windows.Forms.TextBox Puerto;
    }
}

