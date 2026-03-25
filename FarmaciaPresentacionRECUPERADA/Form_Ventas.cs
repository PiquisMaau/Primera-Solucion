using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;



public class Form_Ventas : Form
{
    private IContainer components = null;

    private Panel panel1;

    private Label label1;

    private GroupBox groupBox1;

    private TextBox textBox3;

    private Label label4;

    private TextBox textBox2;

    private Label label3;

    private TextBox textBox1;

    private Label label2;

    private TextBox textBox6;

    private Label label7;

    private TextBox textBox5;

    private Label label6;

    private TextBox textBox4;

    private Label label5;

    private PictureBox pictureBox1;

    public Form_Ventas()
    {
        InitializeComponent();
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void label4_Click(object sender, EventArgs e)
    {
    }

    private void groupBox1_Enter(object sender, EventArgs e)
    {
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {
    }

    private void label5_Click(object sender, EventArgs e)
    {
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ventas));
        this.panel1 = new System.Windows.Forms.Panel();
        this.label1 = new System.Windows.Forms.Label();
        this.groupBox1 = new System.Windows.Forms.GroupBox();
        this.label2 = new System.Windows.Forms.Label();
        this.textBox1 = new System.Windows.Forms.TextBox();
        this.textBox2 = new System.Windows.Forms.TextBox();
        this.label3 = new System.Windows.Forms.Label();
        this.textBox3 = new System.Windows.Forms.TextBox();
        this.label4 = new System.Windows.Forms.Label();
        this.textBox4 = new System.Windows.Forms.TextBox();
        this.label5 = new System.Windows.Forms.Label();
        this.textBox5 = new System.Windows.Forms.TextBox();
        this.label6 = new System.Windows.Forms.Label();
        this.textBox6 = new System.Windows.Forms.TextBox();
        this.label7 = new System.Windows.Forms.Label();
        this.pictureBox1 = new System.Windows.Forms.PictureBox();
        this.groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
        base.SuspendLayout();
        this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
        this.panel1.Location = new System.Drawing.Point(12, 46);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(1079, 4);
        this.panel1.TabIndex = 0;
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(397, 18);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(144, 15);
        this.label1.TabIndex = 1;
        this.label1.Text = "VENTA DE PRODUCTOS";
        this.label1.Click += new System.EventHandler(label1_Click);
        this.groupBox1.Controls.Add(this.pictureBox1);
        this.groupBox1.Controls.Add(this.textBox6);
        this.groupBox1.Controls.Add(this.label7);
        this.groupBox1.Controls.Add(this.textBox5);
        this.groupBox1.Controls.Add(this.label6);
        this.groupBox1.Controls.Add(this.textBox4);
        this.groupBox1.Controls.Add(this.label5);
        this.groupBox1.Controls.Add(this.textBox3);
        this.groupBox1.Controls.Add(this.label4);
        this.groupBox1.Controls.Add(this.textBox2);
        this.groupBox1.Controls.Add(this.label3);
        this.groupBox1.Controls.Add(this.textBox1);
        this.groupBox1.Controls.Add(this.label2);
        this.groupBox1.Location = new System.Drawing.Point(12, 56);
        this.groupBox1.Name = "groupBox1";
        this.groupBox1.Size = new System.Drawing.Size(1079, 202);
        this.groupBox1.TabIndex = 2;
        this.groupBox1.TabStop = false;
        this.groupBox1.Text = "Datos del Cliente:";
        this.groupBox1.Enter += new System.EventHandler(groupBox1_Enter);
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(77, 41);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(75, 15);
        this.label2.TabIndex = 0;
        this.label2.Text = "Cédula/RUC";
        this.label2.Click += new System.EventHandler(label2_Click);
        this.textBox1.Location = new System.Drawing.Point(171, 41);
        this.textBox1.Name = "textBox1";
        this.textBox1.Size = new System.Drawing.Size(190, 20);
        this.textBox1.TabIndex = 1;
        this.textBox1.TextChanged += new System.EventHandler(textBox1_TextChanged);
        this.textBox2.Location = new System.Drawing.Point(171, 67);
        this.textBox2.Name = "textBox2";
        this.textBox2.Size = new System.Drawing.Size(190, 20);
        this.textBox2.TabIndex = 3;
        this.textBox2.TextChanged += new System.EventHandler(textBox2_TextChanged);
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(77, 67);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(57, 15);
        this.label3.TabIndex = 2;
        this.label3.Text = "Apellidos";
        this.label3.Click += new System.EventHandler(label3_Click);
        this.textBox3.Location = new System.Drawing.Point(171, 93);
        this.textBox3.Name = "textBox3";
        this.textBox3.Size = new System.Drawing.Size(190, 20);
        this.textBox3.TabIndex = 5;
        this.textBox3.TextChanged += new System.EventHandler(textBox3_TextChanged);
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(77, 93);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(61, 15);
        this.label4.TabIndex = 4;
        this.label4.Text = "Nombres:";
        this.label4.Click += new System.EventHandler(label4_Click);
        this.textBox4.Location = new System.Drawing.Point(547, 41);
        this.textBox4.Name = "textBox4";
        this.textBox4.Size = new System.Drawing.Size(190, 20);
        this.textBox4.TabIndex = 7;
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(453, 41);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(58, 15);
        this.label5.TabIndex = 6;
        this.label5.Text = "Teléfono:";
        this.label5.Click += new System.EventHandler(label5_Click);
        this.textBox5.Location = new System.Drawing.Point(547, 67);
        this.textBox5.Name = "textBox5";
        this.textBox5.Size = new System.Drawing.Size(190, 20);
        this.textBox5.TabIndex = 9;
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(453, 67);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(62, 15);
        this.label6.TabIndex = 8;
        this.label6.Text = "Dirección:";
        this.textBox6.Location = new System.Drawing.Point(547, 93);
        this.textBox6.Name = "textBox6";
        this.textBox6.Size = new System.Drawing.Size(190, 20);
        this.textBox6.TabIndex = 11;
        this.label7.AutoSize = true;
        this.label7.Location = new System.Drawing.Point(453, 93);
        this.label7.Name = "label7";
        this.label7.Size = new System.Drawing.Size(50, 15);
        this.label7.TabIndex = 10;
        this.label7.Text = "Correo: ";
     //   this.pictureBox1.Image = Properties.Resources.preview_search_find_locate_1551;
        this.pictureBox1.Location = new System.Drawing.Point(844, 30);
        this.pictureBox1.Name = "pictureBox1";
        this.pictureBox1.Size = new System.Drawing.Size(98, 102);
        this.pictureBox1.TabIndex = 12;
        this.pictureBox1.TabStop = false;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(1103, 624);
        base.Controls.Add(this.groupBox1);
        base.Controls.Add(this.label1);
        base.Controls.Add(this.panel1);
        base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        base.Name = "Form_Ventas";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Formulario Ventas";
        this.groupBox1.ResumeLayout(false);
        this.groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}
