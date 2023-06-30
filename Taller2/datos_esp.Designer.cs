namespace Taller2
{
    partial class datos_esp
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
            this.lista_profesor = new System.Windows.Forms.ComboBox();
            this.out_text1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "Desplegar datos de esposo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lista_profesor
            // 
            this.lista_profesor.FormattingEnabled = true;
            this.lista_profesor.Location = new System.Drawing.Point(22, 208);
            this.lista_profesor.Name = "lista_profesor";
            this.lista_profesor.Size = new System.Drawing.Size(121, 23);
            this.lista_profesor.TabIndex = 1;
            this.lista_profesor.SelectedIndexChanged += new System.EventHandler(this.lista_profesor_SelectedIndexChanged);
            // 
            // out_text1
            // 
            this.out_text1.Enabled = false;
            this.out_text1.Location = new System.Drawing.Point(170, 208);
            this.out_text1.Name = "out_text1";
            this.out_text1.ReadOnly = true;
            this.out_text1.Size = new System.Drawing.Size(100, 23);
            this.out_text1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccionar profesor";
            // 
            // data
            // 
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(330, 55);
            this.data.Name = "data";
            this.data.RowTemplate.Height = 25;
            this.data.Size = new System.Drawing.Size(374, 288);
            this.data.TabIndex = 4;
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // datos_esp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.out_text1);
            this.Controls.Add(this.lista_profesor);
            this.Controls.Add(this.button1);
            this.Name = "datos_esp";
            this.Text = "datos_esp";
            this.Load += new System.EventHandler(this.datos_esp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private ComboBox lista_profesor;
        private TextBox out_text1;
        private Label label1;
        private DataGridView data;
    }
}