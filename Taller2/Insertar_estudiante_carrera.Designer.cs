namespace Taller2
{
    partial class Insertar_estudiante_carrera
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
            this.label2 = new System.Windows.Forms.Label();
            this.rut_in = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.input_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.year_in = new System.Windows.Forms.TextBox();
            this.lista_carreras = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.out_text1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(80, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insertar estudiante a carrera";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(80, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingresar rut estudiante,El rut es sin guion, si el digito verificador es K se deb" +
    "e reemplazar por un 0";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rut_in
            // 
            this.rut_in.Location = new System.Drawing.Point(80, 120);
            this.rut_in.Name = "rut_in";
            this.rut_in.Size = new System.Drawing.Size(276, 21);
            this.rut_in.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(80, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ingresar nombre de estudiante";
            // 
            // input_nombre
            // 
            this.input_nombre.Location = new System.Drawing.Point(80, 179);
            this.input_nombre.Name = "input_nombre";
            this.input_nombre.Size = new System.Drawing.Size(276, 21);
            this.input_nombre.TabIndex = 4;
            this.input_nombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(80, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese año de ingreso";
            // 
            // year_in
            // 
            this.year_in.Location = new System.Drawing.Point(80, 247);
            this.year_in.Name = "year_in";
            this.year_in.Size = new System.Drawing.Size(276, 21);
            this.year_in.TabIndex = 6;
            // 
            // lista_carreras
            // 
            this.lista_carreras.FormattingEnabled = true;
            this.lista_carreras.Location = new System.Drawing.Point(424, 119);
            this.lista_carreras.Name = "lista_carreras";
            this.lista_carreras.Size = new System.Drawing.Size(121, 22);
            this.lista_carreras.TabIndex = 7;
            this.lista_carreras.SelectedIndexChanged += new System.EventHandler(this.lista_carreras_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(424, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese carrera";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 89);
            this.button1.TabIndex = 9;
            this.button1.Text = "ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // out_text1
            // 
            this.out_text1.Enabled = false;
            this.out_text1.Location = new System.Drawing.Point(551, 119);
            this.out_text1.Name = "out_text1";
            this.out_text1.ReadOnly = true;
            this.out_text1.Size = new System.Drawing.Size(100, 21);
            this.out_text1.TabIndex = 10;
            // 
            // Insertar_estudiante_carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 420);
            this.Controls.Add(this.out_text1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lista_carreras);
            this.Controls.Add(this.year_in);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.input_nombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rut_in);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Broadway", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Name = "Insertar_estudiante_carrera";
            this.Text = "Insertar_estudiante_carrera";
            this.Load += new System.EventHandler(this.Insertar_estudiante_carrera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox rut_in;
        private Label label3;
        private TextBox input_nombre;
        private Label label4;
        private TextBox year_in;
        private ComboBox lista_carreras;
        private Label label5;
        private Button button1;
        private TextBox out_text1;
    }
}