namespace Taller2
{
    partial class Dejarproy_inactivo
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
            this.label1 = new System.Windows.Forms.Label();
            this.lista_proyectos = new System.Windows.Forms.ComboBox();
            this.out_text1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.out_text2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar proyecto";
            // 
            // lista_proyectos
            // 
            this.lista_proyectos.FormattingEnabled = true;
            this.lista_proyectos.Location = new System.Drawing.Point(105, 115);
            this.lista_proyectos.Name = "lista_proyectos";
            this.lista_proyectos.Size = new System.Drawing.Size(121, 23);
            this.lista_proyectos.TabIndex = 1;
            this.lista_proyectos.SelectedIndexChanged += new System.EventHandler(this.lista_proyectos_SelectedIndexChanged);
            // 
            // out_text1
            // 
            this.out_text1.Enabled = false;
            this.out_text1.Location = new System.Drawing.Point(259, 115);
            this.out_text1.Name = "out_text1";
            this.out_text1.ReadOnly = true;
            this.out_text1.Size = new System.Drawing.Size(100, 23);
            this.out_text1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "id depto";
            // 
            // out_text2
            // 
            this.out_text2.Enabled = false;
            this.out_text2.Location = new System.Drawing.Point(396, 115);
            this.out_text2.Name = "out_text2";
            this.out_text2.ReadOnly = true;
            this.out_text2.Size = new System.Drawing.Size(100, 23);
            this.out_text2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "rut Profesor";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "dejar proyecto inactivo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dejarproy_inactivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.out_text2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.out_text1);
            this.Controls.Add(this.lista_proyectos);
            this.Controls.Add(this.label1);
            this.Name = "Dejarproy_inactivo";
            this.Text = "Dejarproy_inactivo";
            this.Load += new System.EventHandler(this.Dejarproy_inactivo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox lista_proyectos;
        private TextBox out_text1;
        private Label label2;
        private TextBox out_text2;
        private Label label3;
        private Button button1;
    }
}