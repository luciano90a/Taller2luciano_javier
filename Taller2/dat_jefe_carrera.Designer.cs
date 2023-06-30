namespace Taller2
{
    partial class dat_jefe_carrera
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
            this.lista_deptos = new System.Windows.Forms.ComboBox();
            this.out_text1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar Carreras";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lista_deptos
            // 
            this.lista_deptos.FormattingEnabled = true;
            this.lista_deptos.Location = new System.Drawing.Point(33, 171);
            this.lista_deptos.Name = "lista_deptos";
            this.lista_deptos.Size = new System.Drawing.Size(121, 23);
            this.lista_deptos.TabIndex = 1;
            this.lista_deptos.SelectedIndexChanged += new System.EventHandler(this.lista_deptos_SelectedIndexChanged);
            // 
            // out_text1
            // 
            this.out_text1.Enabled = false;
            this.out_text1.Location = new System.Drawing.Point(186, 171);
            this.out_text1.Name = "out_text1";
            this.out_text1.ReadOnly = true;
            this.out_text1.Size = new System.Drawing.Size(100, 23);
            this.out_text1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "Desplegar datos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(469, 114);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 25;
            this.data.Size = new System.Drawing.Size(283, 230);
            this.data.TabIndex = 4;
            // 
            // dat_jefe_carrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.out_text1);
            this.Controls.Add(this.lista_deptos);
            this.Controls.Add(this.label1);
            this.Name = "dat_jefe_carrera";
            this.Text = "dat_jefe_carrera";
            this.Load += new System.EventHandler(this.dat_jefe_carrera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox lista_deptos;
        private TextBox out_text1;
        private Button button1;
        private DataGridView data;
    }
}