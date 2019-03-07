namespace practicagit
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
            this.button1 = new System.Windows.Forms.Button();
            this.lalumno = new System.Windows.Forms.Label();
            this.lnota = new System.Windows.Forms.Label();
            this.talumno = new System.Windows.Forms.TextBox();
            this.tnota = new System.Windows.Forms.TextBox();
            this.lista = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(565, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar alumno";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lalumno
            // 
            this.lalumno.AutoSize = true;
            this.lalumno.Location = new System.Drawing.Point(41, 29);
            this.lalumno.Name = "lalumno";
            this.lalumno.Size = new System.Drawing.Size(101, 13);
            this.lalumno.TabIndex = 1;
            this.lalumno.Text = "Nombre del alumno:";
            // 
            // lnota
            // 
            this.lnota.AutoSize = true;
            this.lnota.Location = new System.Drawing.Point(378, 29);
            this.lnota.Name = "lnota";
            this.lnota.Size = new System.Drawing.Size(33, 13);
            this.lnota.TabIndex = 2;
            this.lnota.Text = "Nota:";
            // 
            // talumno
            // 
            this.talumno.Location = new System.Drawing.Point(44, 52);
            this.talumno.Name = "talumno";
            this.talumno.Size = new System.Drawing.Size(270, 20);
            this.talumno.TabIndex = 3;
            // 
            // tnota
            // 
            this.tnota.Location = new System.Drawing.Point(381, 52);
            this.tnota.Name = "tnota";
            this.tnota.Size = new System.Drawing.Size(30, 20);
            this.tnota.TabIndex = 4;
            // 
            // lista
            // 
            this.lista.AutoSize = true;
            this.lista.Location = new System.Drawing.Point(41, 133);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(69, 13);
            this.lista.TabIndex = 5;
            this.lista.Text = "Lista alumno:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(41, 183);
            this.label.Name = "label";
            this.label.Padding = new System.Windows.Forms.Padding(100, 0, 100, 0);
            this.label.Size = new System.Drawing.Size(200, 13);
            this.label.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.tnota);
            this.Controls.Add(this.talumno);
            this.Controls.Add(this.lnota);
            this.Controls.Add(this.lalumno);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lalumno;
        private System.Windows.Forms.Label lnota;
        private System.Windows.Forms.TextBox talumno;
        private System.Windows.Forms.TextBox tnota;
        private System.Windows.Forms.Label lista;
        private System.Windows.Forms.Label label;
    }
}

