namespace Taller2
{
    partial class est_det_curso
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
            this.lista_cursos = new System.Windows.Forms.ComboBox();
            this.out_text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // lista_cursos
            // 
            this.lista_cursos.FormattingEnabled = true;
            this.lista_cursos.Location = new System.Drawing.Point(73, 177);
            this.lista_cursos.Name = "lista_cursos";
            this.lista_cursos.Size = new System.Drawing.Size(121, 23);
            this.lista_cursos.TabIndex = 0;
            this.lista_cursos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // out_text1
            // 
            this.out_text1.Enabled = false;
            this.out_text1.Location = new System.Drawing.Point(235, 177);
            this.out_text1.Name = "out_text1";
            this.out_text1.ReadOnly = true;
            this.out_text1.Size = new System.Drawing.Size(100, 23);
            this.out_text1.TabIndex = 1;
            this.out_text1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "seleccionar curso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "desplegar Los estudiantes que tiene un determinado curso; indicando los datos del" +
    " profesor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(73, 275);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 25;
            this.data.Size = new System.Drawing.Size(280, 150);
            this.data.TabIndex = 4;
            // 
            // est_det_curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.out_text1);
            this.Controls.Add(this.lista_cursos);
            this.Name = "est_det_curso";
            this.Text = "est_det_curso";
            this.Load += new System.EventHandler(this.est_det_curso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox lista_cursos;
        private TextBox out_text1;
        private Label label1;
        private Button button1;
        private DataGridView data;
    }
}