namespace FindNumber
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
      this.display = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.hint = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // display
      // 
      this.display.Dock = System.Windows.Forms.DockStyle.Top;
      this.display.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.display.Location = new System.Drawing.Point(0, 0);
      this.display.Name = "display";
      this.display.Size = new System.Drawing.Size(630, 45);
      this.display.TabIndex = 0;
      this.display.Text = "게임을 시작합니다";
      this.display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // textBox1
      // 
      this.textBox1.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.textBox1.Location = new System.Drawing.Point(120, 123);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(183, 39);
      this.textBox1.TabIndex = 1;
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button1.Location = new System.Drawing.Point(342, 123);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(169, 39);
      this.button1.TabIndex = 2;
      this.button1.Text = "입력";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.insertNum);
      // 
      // button2
      // 
      this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.button2.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.button2.Location = new System.Drawing.Point(0, 230);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(630, 50);
      this.button2.TabIndex = 3;
      this.button2.Text = "게임 시작";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.gameStart);
      // 
      // hint
      // 
      this.hint.Dock = System.Windows.Forms.DockStyle.Top;
      this.hint.Font = new System.Drawing.Font("Gulim", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.hint.Location = new System.Drawing.Point(0, 45);
      this.hint.Name = "hint";
      this.hint.Size = new System.Drawing.Size(630, 44);
      this.hint.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(630, 280);
      this.Controls.Add(this.hint);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.display);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label display;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Label hint;
  }
}

