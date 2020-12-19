namespace Insercion2._0
{
  partial class Form1
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.Pos1 = new System.Windows.Forms.TextBox();
      this.Pos2 = new System.Windows.Forms.TextBox();
      this.Pos3 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // Pos1
      // 
      this.Pos1.Location = new System.Drawing.Point(32, 129);
      this.Pos1.Margin = new System.Windows.Forms.Padding(2);
      this.Pos1.Name = "Pos1";
      this.Pos1.Size = new System.Drawing.Size(83, 26);
      this.Pos1.TabIndex = 0;
      // 
      // Pos2
      // 
      this.Pos2.Location = new System.Drawing.Point(32, 199);
      this.Pos2.Margin = new System.Windows.Forms.Padding(2);
      this.Pos2.Name = "Pos2";
      this.Pos2.Size = new System.Drawing.Size(83, 26);
      this.Pos2.TabIndex = 1;
      // 
      // Pos3
      // 
      this.Pos3.Location = new System.Drawing.Point(32, 263);
      this.Pos3.Margin = new System.Windows.Forms.Padding(2);
      this.Pos3.Name = "Pos3";
      this.Pos3.Size = new System.Drawing.Size(83, 26);
      this.Pos3.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(32, 106);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 20);
      this.label1.TabIndex = 4;
      this.label1.Text = "Elementos";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(32, 168);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(59, 20);
      this.label2.TabIndex = 5;
      this.label2.Text = "Minimo";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(32, 239);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(63, 20);
      this.label3.TabIndex = 6;
      this.label3.Text = "Maximo";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(270, 85);
      this.button1.Margin = new System.Windows.Forms.Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(195, 156);
      this.button1.TabIndex = 8;
      this.button1.Text = "GENERAR Y ORDENAR";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(609, 28);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(172, 20);
      this.label5.TabIndex = 10;
      this.label5.Text = "DATOS ORDENADOS";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(507, 393);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(85, 20);
      this.label6.TabIndex = 11;
      this.label6.Text = "Posicion 1 ";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(507, 433);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(85, 20);
      this.label7.TabIndex = 12;
      this.label7.Text = "Posicion 1 ";
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.ItemHeight = 20;
      this.listBox1.Location = new System.Drawing.Point(630, 68);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(190, 264);
      this.listBox1.TabIndex = 15;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1069, 509);
      this.Controls.Add(this.listBox1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.Pos3);
      this.Controls.Add(this.Pos2);
      this.Controls.Add(this.Pos1);
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox Pos1;
    private System.Windows.Forms.TextBox Pos2;
    private System.Windows.Forms.TextBox Pos3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.ListBox listBox1;
  }
}

