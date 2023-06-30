namespace Taller2
{
    partial class Modificacionescs
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
            this.insertar = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.eliminar_dir = new System.Windows.Forms.Button();
            this.eliminar_est_p = new System.Windows.Forms.Button();
            this.inactivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(61, 59);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(168, 82);
            this.insertar.TabIndex = 0;
            this.insertar.Text = "Insertar estudiante a carrera";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(275, 59);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(183, 82);
            this.actualizar.TabIndex = 3;
            this.actualizar.Text = "Actualizar bono director de Departamento";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // eliminar_dir
            // 
            this.eliminar_dir.Location = new System.Drawing.Point(61, 147);
            this.eliminar_dir.Name = "eliminar_dir";
            this.eliminar_dir.Size = new System.Drawing.Size(168, 68);
            this.eliminar_dir.TabIndex = 4;
            this.eliminar_dir.Text = "Eliminar direccion de proyecto ";
            this.eliminar_dir.UseVisualStyleBackColor = true;
            this.eliminar_dir.Click += new System.EventHandler(this.eliminar_dir_Click);
            // 
            // eliminar_est_p
            // 
            this.eliminar_est_p.Location = new System.Drawing.Point(61, 221);
            this.eliminar_est_p.Name = "eliminar_est_p";
            this.eliminar_est_p.Size = new System.Drawing.Size(168, 68);
            this.eliminar_est_p.TabIndex = 5;
            this.eliminar_est_p.Text = "Eliminar participacion de estudiante en proyecto";
            this.eliminar_est_p.UseVisualStyleBackColor = true;
            this.eliminar_est_p.Click += new System.EventHandler(this.eliminar_est_p_Click);
            // 
            // inactivo
            // 
            this.inactivo.Location = new System.Drawing.Point(275, 147);
            this.inactivo.Name = "inactivo";
            this.inactivo.Size = new System.Drawing.Size(183, 64);
            this.inactivo.TabIndex = 6;
            this.inactivo.Text = "Dejar proyecto inactivo";
            this.inactivo.UseVisualStyleBackColor = true;
            this.inactivo.Click += new System.EventHandler(this.inactivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "Seleccione alguna opcion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Modificacionescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inactivo);
            this.Controls.Add(this.eliminar_est_p);
            this.Controls.Add(this.eliminar_dir);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.insertar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Modificacionescs";
            this.Text = "Modificacionescs";
            this.Load += new System.EventHandler(this.Modificacionescs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button insertar;
        private Button actualizar;
        private Button eliminar_dir;
        private Button eliminar_est_p;
        private Button inactivo;
        private Label label1;
    }
}