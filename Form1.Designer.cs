namespace ProyectoCalificaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCalificaciones = new System.Windows.Forms.RichTextBox();
            this.btnGraficar = new System.Windows.Forms.Button();
            this.Contenedor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "REPORTE DE CALIFICACIONES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calificaciones";
            // 
            // txtCalificaciones
            // 
            this.txtCalificaciones.Location = new System.Drawing.Point(13, 61);
            this.txtCalificaciones.Name = "txtCalificaciones";
            this.txtCalificaciones.Size = new System.Drawing.Size(220, 387);
            this.txtCalificaciones.TabIndex = 2;
            this.txtCalificaciones.Text = "";
            // 
            // btnGraficar
            // 
            this.btnGraficar.Location = new System.Drawing.Point(13, 454);
            this.btnGraficar.Name = "btnGraficar";
            this.btnGraficar.Size = new System.Drawing.Size(166, 23);
            this.btnGraficar.TabIndex = 3;
            this.btnGraficar.Text = "button1";
            this.btnGraficar.UseVisualStyleBackColor = true;
            this.btnGraficar.Click += new System.EventHandler(this.btnGraficar_Click);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.SystemColors.Window;
            this.Contenedor.Location = new System.Drawing.Point(239, 61);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(785, 416);
            this.Contenedor.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 489);
            this.Controls.Add(this.Contenedor);
            this.Controls.Add(this.btnGraficar);
            this.Controls.Add(this.txtCalificaciones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtCalificaciones;
        private System.Windows.Forms.Button btnGraficar;
        private System.Windows.Forms.Panel Contenedor;
    }
}

