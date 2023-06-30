namespace Taller2
{
    partial class datoscarrera_alumno
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
            this.ver_datos_bt = new System.Windows.Forms.Button();
            this.rut_in = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // ver_datos_bt
            // 
            this.ver_datos_bt.Location = new System.Drawing.Point(286, 164);
            this.ver_datos_bt.Name = "ver_datos_bt";
            this.ver_datos_bt.Size = new System.Drawing.Size(75, 23);
            this.ver_datos_bt.TabIndex = 0;
            this.ver_datos_bt.Text = "ver datos";
            this.ver_datos_bt.UseVisualStyleBackColor = true;
            this.ver_datos_bt.Click += new System.EventHandler(this.ver_datos_bt_Click);
            // 
            // rut_in
            // 
            this.rut_in.Location = new System.Drawing.Point(128, 135);
            this.rut_in.Name = "rut_in";
            this.rut_in.Size = new System.Drawing.Size(397, 23);
            this.rut_in.TabIndex = 1;
            this.rut_in.TextChanged += new System.EventHandler(this.rut_in_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "ingresar rut estudiante,El rut es sin guion, si el digito verificador es K se deb" +
    "e reemplazar por un 0";
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(27, 193);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 25;
            this.data.Size = new System.Drawing.Size(619, 150);
            this.data.TabIndex = 3;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // datoscarrera_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rut_in);
            this.Controls.Add(this.ver_datos_bt);
            this.Name = "datoscarrera_alumno";
            this.Text = "datoscarrera_alumno";
            this.Load += new System.EventHandler(this.datoscarrera_alumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ver_datos_bt;
        private TextBox rut_in;
        private Label label1;
        private DataGridView data;
    }
}