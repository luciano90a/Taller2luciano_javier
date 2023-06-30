namespace Taller2
{
    partial class datos_dir_depto
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
            this.button1 = new System.Windows.Forms.Button();
            this.lista_deptos = new System.Windows.Forms.ComboBox();
            this.l = new System.Windows.Forms.Label();
            this.out_text1 = new System.Windows.Forms.TextBox();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 97);
            this.button1.TabIndex = 0;
            this.button1.Text = "Desplegar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista_deptos
            // 
            this.lista_deptos.FormattingEnabled = true;
            this.lista_deptos.Location = new System.Drawing.Point(38, 172);
            this.lista_deptos.Name = "lista_deptos";
            this.lista_deptos.Size = new System.Drawing.Size(145, 23);
            this.lista_deptos.TabIndex = 1;
            this.lista_deptos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(38, 143);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(145, 15);
            this.l.TabIndex = 2;
            this.l.Text = "Seleccionar departamento";
            // 
            // out_text1
            // 
            this.out_text1.Enabled = false;
            this.out_text1.Location = new System.Drawing.Point(208, 172);
            this.out_text1.Name = "out_text1";
            this.out_text1.ReadOnly = true;
            this.out_text1.Size = new System.Drawing.Size(100, 23);
            this.out_text1.TabIndex = 3;
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(429, 61);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 25;
            this.data.Size = new System.Drawing.Size(344, 162);
            this.data.TabIndex = 4;
            // 
            // datos_dir_depto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.out_text1);
            this.Controls.Add(this.l);
            this.Controls.Add(this.lista_deptos);
            this.Controls.Add(this.button1);
            this.Name = "datos_dir_depto";
            this.Text = "datos_dir_depto";
            this.Load += new System.EventHandler(this.datos_dir_depto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox lista_deptos;
        private Label l;
        private TextBox out_text1;
        private DataGridView data;
    }
}