namespace Taller2
{
    partial class Eliminar_participacion_estudiante_proyecto
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
            this.lista_proy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.out_text2 = new System.Windows.Forms.TextBox();
            this.out_text1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.alumnos_proy = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_proy
            // 
            this.lista_proy.FormattingEnabled = true;
            this.lista_proy.Location = new System.Drawing.Point(219, 27);
            this.lista_proy.Name = "lista_proy";
            this.lista_proy.Size = new System.Drawing.Size(121, 23);
            this.lista_proy.TabIndex = 0;
            this.lista_proy.SelectedIndexChanged += new System.EventHandler(this.lista_proy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar proyecto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "id proyecto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "nombre estudiante";
            // 
            // out_text2
            // 
            this.out_text2.Enabled = false;
            this.out_text2.Location = new System.Drawing.Point(384, 279);
            this.out_text2.Name = "out_text2";
            this.out_text2.ReadOnly = true;
            this.out_text2.Size = new System.Drawing.Size(100, 23);
            this.out_text2.TabIndex = 4;
            // 
            // out_text1
            // 
            this.out_text1.Enabled = false;
            this.out_text1.Location = new System.Drawing.Point(384, 27);
            this.out_text1.Name = "out_text1";
            this.out_text1.ReadOnly = true;
            this.out_text1.Size = new System.Drawing.Size(100, 23);
            this.out_text1.TabIndex = 5;
            this.out_text1.TextChanged += new System.EventHandler(this.out_text2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 74);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(242, 129);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 25;
            this.data.Size = new System.Drawing.Size(242, 103);
            this.data.TabIndex = 7;
            // 
            // alumnos_proy
            // 
            this.alumnos_proy.FormattingEnabled = true;
            this.alumnos_proy.Location = new System.Drawing.Point(219, 279);
            this.alumnos_proy.Name = "alumnos_proy";
            this.alumnos_proy.Size = new System.Drawing.Size(121, 23);
            this.alumnos_proy.TabIndex = 8;
            this.alumnos_proy.SelectedIndexChanged += new System.EventHandler(this.alumnos_proy_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccionar alumno";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(384, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 38);
            this.button2.TabIndex = 10;
            this.button2.Text = "Seleccionar proyecto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "1)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(184, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "2)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "alumnos del proyecto seleccionado";
            // 
            // Eliminar_participacion_estudiante_proyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alumnos_proy);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.out_text1);
            this.Controls.Add(this.out_text2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lista_proy);
            this.Name = "Eliminar_participacion_estudiante_proyecto";
            this.Text = "Eliminar_participacion_estudiante_proyecto";
            this.Load += new System.EventHandler(this.Eliminar_participacion_estudiante_proyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox lista_proy;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox out_text2;
        private TextBox out_text1;
        private Button button1;
        private DataGridView data;
        private ComboBox alumnos_proy;
        private Label label4;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}