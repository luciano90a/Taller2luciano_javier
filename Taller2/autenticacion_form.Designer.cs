namespace Taller2
{
    partial class autenticacion_form
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
            this.n_admin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.c_admin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(262, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // n_admin
            // 
            this.n_admin.Location = new System.Drawing.Point(262, 120);
            this.n_admin.Name = "n_admin";
            this.n_admin.Size = new System.Drawing.Size(293, 24);
            this.n_admin.TabIndex = 1;
            this.n_admin.TextChanged += new System.EventHandler(this.n_admin_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(262, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "contraseña ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // c_admin
            // 
            this.c_admin.Location = new System.Drawing.Point(262, 219);
            this.c_admin.Name = "c_admin";
            this.c_admin.Size = new System.Drawing.Size(293, 24);
            this.c_admin.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(262, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Acceder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // autenticacion_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 401);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.c_admin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_admin);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Name = "autenticacion_form";
            this.Text = " ";
            this.Load += new System.EventHandler(this.autenticacion_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox n_admin;
        private Label label2;
        private TextBox c_admin;
        private Button button1;
    }
}