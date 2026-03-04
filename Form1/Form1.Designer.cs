namespace Form1
{
    partial class Form1
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
            this.nombre1 = new System.Windows.Forms.Label();
            this.nombre2 = new System.Windows.Forms.Label();
            this.apellido1 = new System.Windows.Forms.Label();
            this.apellido2 = new System.Windows.Forms.Label();
            this.button1_calcular = new System.Windows.Forms.Button();
            this.textBox_Nombre1 = new System.Windows.Forms.TextBox();
            this.textBox_Nombre2 = new System.Windows.Forms.TextBox();
            this.textBox_Apellido1 = new System.Windows.Forms.TextBox();
            this.textBox_Apellido2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nombre1
            // 
            this.nombre1.AutoSize = true;
            this.nombre1.Location = new System.Drawing.Point(73, 46);
            this.nombre1.Name = "nombre1";
            this.nombre1.Size = new System.Drawing.Size(57, 16);
            this.nombre1.TabIndex = 0;
            this.nombre1.Text = "MAURO";
            this.nombre1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nombre2
            // 
            this.nombre2.AutoSize = true;
            this.nombre2.Location = new System.Drawing.Point(73, 94);
            this.nombre2.Name = "nombre2";
            this.nombre2.Size = new System.Drawing.Size(83, 16);
            this.nombre2.TabIndex = 1;
            this.nombre2.Text = "SEBASTIÁN";
            // 
            // apellido1
            // 
            this.apellido1.AutoSize = true;
            this.apellido1.Location = new System.Drawing.Point(73, 140);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(38, 16);
            this.apellido1.TabIndex = 2;
            this.apellido1.Text = "PICO";
            // 
            // apellido2
            // 
            this.apellido2.AutoSize = true;
            this.apellido2.Location = new System.Drawing.Point(73, 190);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(45, 16);
            this.apellido2.TabIndex = 3;
            this.apellido2.Text = "SOLIS";
            this.apellido2.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1_calcular
            // 
            this.button1_calcular.Location = new System.Drawing.Point(300, 123);
            this.button1_calcular.Name = "button1_calcular";
            this.button1_calcular.Size = new System.Drawing.Size(104, 23);
            this.button1_calcular.TabIndex = 4;
            this.button1_calcular.Text = "CALCULAR";
            this.button1_calcular.UseVisualStyleBackColor = true;
            this.button1_calcular.Click += new System.EventHandler(this.button1_calcular_Click);
            // 
            // textBox_Nombre1
            // 
            this.textBox_Nombre1.Location = new System.Drawing.Point(550, 40);
            this.textBox_Nombre1.Name = "textBox_Nombre1";
            this.textBox_Nombre1.Size = new System.Drawing.Size(174, 22);
            this.textBox_Nombre1.TabIndex = 5;
            // 
            // textBox_Nombre2
            // 
            this.textBox_Nombre2.Location = new System.Drawing.Point(550, 88);
            this.textBox_Nombre2.Name = "textBox_Nombre2";
            this.textBox_Nombre2.Size = new System.Drawing.Size(174, 22);
            this.textBox_Nombre2.TabIndex = 6;
            // 
            // textBox_Apellido1
            // 
            this.textBox_Apellido1.Location = new System.Drawing.Point(550, 140);
            this.textBox_Apellido1.Name = "textBox_Apellido1";
            this.textBox_Apellido1.Size = new System.Drawing.Size(174, 22);
            this.textBox_Apellido1.TabIndex = 7;
            // 
            // textBox_Apellido2
            // 
            this.textBox_Apellido2.Location = new System.Drawing.Point(550, 184);
            this.textBox_Apellido2.Name = "textBox_Apellido2";
            this.textBox_Apellido2.Size = new System.Drawing.Size(174, 22);
            this.textBox_Apellido2.TabIndex = 8;
            this.textBox_Apellido2.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 465);
            this.Controls.Add(this.textBox_Apellido2);
            this.Controls.Add(this.textBox_Apellido1);
            this.Controls.Add(this.textBox_Nombre2);
            this.Controls.Add(this.textBox_Nombre1);
            this.Controls.Add(this.button1_calcular);
            this.Controls.Add(this.apellido2);
            this.Controls.Add(this.apellido1);
            this.Controls.Add(this.nombre2);
            this.Controls.Add(this.nombre1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre1;
        private System.Windows.Forms.Label nombre2;
        private System.Windows.Forms.Label apellido1;
        private System.Windows.Forms.Label apellido2;
        private System.Windows.Forms.Button button1_calcular;
        private System.Windows.Forms.TextBox textBox_Nombre1;
        private System.Windows.Forms.TextBox textBox_Nombre2;
        private System.Windows.Forms.TextBox textBox_Apellido1;
        private System.Windows.Forms.TextBox textBox_Apellido2;
    }
}

