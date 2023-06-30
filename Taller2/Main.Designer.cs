namespace Taller2
{
    partial class Main
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
            this.titulo = new System.Windows.Forms.Label();
            this.Seccion_modificaciones = new System.Windows.Forms.Button();
            this.Seccion_consultas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titulo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.titulo.Font = new System.Drawing.Font("Showcard Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(218, 35);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(300, 76);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "Taller  2 bases de datos";
            this.titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titulo.Click += new System.EventHandler(this.titulo_Click);
            // 
            // Seccion_modificaciones
            // 
            this.Seccion_modificaciones.Location = new System.Drawing.Point(251, 165);
            this.Seccion_modificaciones.Name = "Seccion_modificaciones";
            this.Seccion_modificaciones.Size = new System.Drawing.Size(221, 66);
            this.Seccion_modificaciones.TabIndex = 1;
            this.Seccion_modificaciones.Text = "Seccion modificaciones";
            this.Seccion_modificaciones.UseVisualStyleBackColor = true;
            this.Seccion_modificaciones.Click += new System.EventHandler(this.Seccion_modificaciones_Click);
            // 
            // Seccion_consultas
            // 
            this.Seccion_consultas.Location = new System.Drawing.Point(251, 248);
            this.Seccion_consultas.Name = "Seccion_consultas";
            this.Seccion_consultas.Size = new System.Drawing.Size(221, 66);
            this.Seccion_consultas.TabIndex = 2;
            this.Seccion_consultas.Text = "Consultas";
            this.Seccion_consultas.UseVisualStyleBackColor = true;
            this.Seccion_consultas.Click += new System.EventHandler(this.Seccion_consultas_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Seccion_consultas);
            this.Controls.Add(this.Seccion_modificaciones);
            this.Controls.Add(this.titulo);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Label titulo;
        private Button Seccion_modificaciones;
        private Button Seccion_consultas;
    }
}