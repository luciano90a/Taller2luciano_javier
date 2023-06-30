namespace Taller2
{
    partial class Eliminar_dir_proyecto
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
            this.lista_proy = new System.Windows.Forms.ComboBox();
            this.out_text1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.out_text2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar proyecto";
            // 
            // lista_proy
            // 
            this.lista_proy.FormattingEnabled = true;
            this.lista_proy.Location = new System.Drawing.Point(18, 169);
            this.lista_proy.Name = "lista_proy";
            this.lista_proy.Size = new System.Drawing.Size(121, 23);
            this.lista_proy.TabIndex = 1;
            this.lista_proy.SelectedIndexChanged += new System.EventHandler(this.lista_proy_SelectedIndexChanged);
            // 
            // out_text1
            // 
            this.out_text1.Location = new System.Drawing.Point(155, 169);
            this.out_text1.Name = "out_text1";
            this.out_text1.Size = new System.Drawing.Size(100, 23);
            this.out_text1.TabIndex = 2;
            this.out_text1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "Actualizar proyecto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "id proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "estado proyecto";
            // 
            // out_text2
            // 
            this.out_text2.Location = new System.Drawing.Point(155, 226);
            this.out_text2.Name = "out_text2";
            this.out_text2.Size = new System.Drawing.Size(100, 23);
            this.out_text2.TabIndex = 6;
            // 
            // Eliminar_dir_proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.out_text2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.out_text1);
            this.Controls.Add(this.lista_proy);
            this.Controls.Add(this.label1);
            this.Name = "Eliminar_dir_proyecto";
            this.Text = "Eliminar_dir_proyecto";
            this.Load += new System.EventHandler(this.Eliminar_dir_proyecto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox lista_proy;
        private TextBox out_text1;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox out_text2;
    }
}