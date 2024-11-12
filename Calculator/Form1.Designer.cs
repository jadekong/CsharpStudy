namespace Calculator
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.PlusButton = new System.Windows.Forms.Button();
      this.ButtonDot = new System.Windows.Forms.Button();
      this.ButtonZero = new System.Windows.Forms.Button();
      this.AllClearButton = new System.Windows.Forms.Button();
      this.MinusButton = new System.Windows.Forms.Button();
      this.ButtonThree = new System.Windows.Forms.Button();
      this.ButtonTwo = new System.Windows.Forms.Button();
      this.ButtonOne = new System.Windows.Forms.Button();
      this.MultiplyButton = new System.Windows.Forms.Button();
      this.ButtonSix = new System.Windows.Forms.Button();
      this.ButtonFive = new System.Windows.Forms.Button();
      this.ButtonFour = new System.Windows.Forms.Button();
      this.DivideButton = new System.Windows.Forms.Button();
      this.ButtonNine = new System.Windows.Forms.Button();
      this.ButtonEight = new System.Windows.Forms.Button();
      this.ButtonSeven = new System.Windows.Forms.Button();
      this.ResultButton = new System.Windows.Forms.Button();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // display
      // 
      this.display.Dock = System.Windows.Forms.DockStyle.Top;
      this.display.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.display.Location = new System.Drawing.Point(0, 0);
      this.display.Name = "display";
      this.display.Size = new System.Drawing.Size(386, 47);
      this.display.TabIndex = 0;
      this.display.Text = "0";
      this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.PlusButton, 3, 3);
      this.tableLayoutPanel1.Controls.Add(this.ButtonDot, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.ButtonZero, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.AllClearButton, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.MinusButton, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.ButtonThree, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.ButtonTwo, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.ButtonOne, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.MultiplyButton, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.ButtonSix, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.ButtonFive, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.ButtonFour, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.DivideButton, 3, 0);
      this.tableLayoutPanel1.Controls.Add(this.ButtonNine, 2, 0);
      this.tableLayoutPanel1.Controls.Add(this.ButtonEight, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.ButtonSeven, 0, 0);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 50);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(381, 388);
      this.tableLayoutPanel1.TabIndex = 1;
      this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
      // 
      // PlusButton
      // 
      this.PlusButton.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.PlusButton.Location = new System.Drawing.Point(288, 294);
      this.PlusButton.Name = "PlusButton";
      this.PlusButton.Size = new System.Drawing.Size(90, 91);
      this.PlusButton.TabIndex = 15;
      this.PlusButton.Text = "＋";
      this.PlusButton.UseVisualStyleBackColor = true;
      this.PlusButton.Click += new System.EventHandler(this.plusClick);
      // 
      // ButtonDot
      // 
      this.ButtonDot.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonDot.Location = new System.Drawing.Point(193, 294);
      this.ButtonDot.Name = "ButtonDot";
      this.ButtonDot.Size = new System.Drawing.Size(89, 91);
      this.ButtonDot.TabIndex = 14;
      this.ButtonDot.Text = ".";
      this.ButtonDot.UseVisualStyleBackColor = true;
      this.ButtonDot.Click += new System.EventHandler(this.dot);
      // 
      // ButtonZero
      // 
      this.ButtonZero.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonZero.Location = new System.Drawing.Point(98, 294);
      this.ButtonZero.Name = "ButtonZero";
      this.ButtonZero.Size = new System.Drawing.Size(89, 91);
      this.ButtonZero.TabIndex = 13;
      this.ButtonZero.Text = "0";
      this.ButtonZero.UseVisualStyleBackColor = true;
      this.ButtonZero.Click += new System.EventHandler(this.zero);
      // 
      // AllClearButton
      // 
      this.AllClearButton.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.AllClearButton.Location = new System.Drawing.Point(3, 294);
      this.AllClearButton.Name = "AllClearButton";
      this.AllClearButton.Size = new System.Drawing.Size(89, 91);
      this.AllClearButton.TabIndex = 12;
      this.AllClearButton.Text = "AC";
      this.AllClearButton.UseVisualStyleBackColor = true;
      this.AllClearButton.Click += new System.EventHandler(this.allClear);
      // 
      // MinusButton
      // 
      this.MinusButton.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.MinusButton.Location = new System.Drawing.Point(288, 197);
      this.MinusButton.Name = "MinusButton";
      this.MinusButton.Size = new System.Drawing.Size(90, 91);
      this.MinusButton.TabIndex = 11;
      this.MinusButton.Text = "－";
      this.MinusButton.UseVisualStyleBackColor = true;
      this.MinusButton.Click += new System.EventHandler(this.minusClick);
      // 
      // ButtonThree
      // 
      this.ButtonThree.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonThree.Location = new System.Drawing.Point(193, 197);
      this.ButtonThree.Name = "ButtonThree";
      this.ButtonThree.Size = new System.Drawing.Size(89, 91);
      this.ButtonThree.TabIndex = 10;
      this.ButtonThree.Text = "3";
      this.ButtonThree.UseVisualStyleBackColor = true;
      this.ButtonThree.Click += new System.EventHandler(this.three);
      // 
      // ButtonTwo
      // 
      this.ButtonTwo.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonTwo.Location = new System.Drawing.Point(98, 197);
      this.ButtonTwo.Name = "ButtonTwo";
      this.ButtonTwo.Size = new System.Drawing.Size(89, 91);
      this.ButtonTwo.TabIndex = 9;
      this.ButtonTwo.Text = "2";
      this.ButtonTwo.UseVisualStyleBackColor = true;
      this.ButtonTwo.Click += new System.EventHandler(this.two);
      // 
      // ButtonOne
      // 
      this.ButtonOne.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonOne.Location = new System.Drawing.Point(3, 197);
      this.ButtonOne.Name = "ButtonOne";
      this.ButtonOne.Size = new System.Drawing.Size(89, 91);
      this.ButtonOne.TabIndex = 8;
      this.ButtonOne.Text = "1";
      this.ButtonOne.UseVisualStyleBackColor = true;
      this.ButtonOne.Click += new System.EventHandler(this.one);
      // 
      // MultiplyButton
      // 
      this.MultiplyButton.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.MultiplyButton.Location = new System.Drawing.Point(288, 100);
      this.MultiplyButton.Name = "MultiplyButton";
      this.MultiplyButton.Size = new System.Drawing.Size(90, 91);
      this.MultiplyButton.TabIndex = 7;
      this.MultiplyButton.Text = "×";
      this.MultiplyButton.UseVisualStyleBackColor = true;
      this.MultiplyButton.Click += new System.EventHandler(this.multiplyClick);
      // 
      // ButtonSix
      // 
      this.ButtonSix.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonSix.Location = new System.Drawing.Point(193, 100);
      this.ButtonSix.Name = "ButtonSix";
      this.ButtonSix.Size = new System.Drawing.Size(89, 91);
      this.ButtonSix.TabIndex = 6;
      this.ButtonSix.Text = "6";
      this.ButtonSix.UseVisualStyleBackColor = true;
      this.ButtonSix.Click += new System.EventHandler(this.six);
      // 
      // ButtonFive
      // 
      this.ButtonFive.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonFive.Location = new System.Drawing.Point(98, 100);
      this.ButtonFive.Name = "ButtonFive";
      this.ButtonFive.Size = new System.Drawing.Size(89, 91);
      this.ButtonFive.TabIndex = 5;
      this.ButtonFive.Text = "5";
      this.ButtonFive.UseVisualStyleBackColor = true;
      this.ButtonFive.Click += new System.EventHandler(this.five);
      // 
      // ButtonFour
      // 
      this.ButtonFour.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonFour.Location = new System.Drawing.Point(3, 100);
      this.ButtonFour.Name = "ButtonFour";
      this.ButtonFour.Size = new System.Drawing.Size(89, 91);
      this.ButtonFour.TabIndex = 4;
      this.ButtonFour.Text = "4";
      this.ButtonFour.UseVisualStyleBackColor = true;
      this.ButtonFour.Click += new System.EventHandler(this.four);
      // 
      // DivideButton
      // 
      this.DivideButton.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.DivideButton.Location = new System.Drawing.Point(288, 3);
      this.DivideButton.Name = "DivideButton";
      this.DivideButton.Size = new System.Drawing.Size(90, 91);
      this.DivideButton.TabIndex = 3;
      this.DivideButton.Text = "÷";
      this.DivideButton.UseVisualStyleBackColor = true;
      this.DivideButton.Click += new System.EventHandler(this.divideClick);
      // 
      // ButtonNine
      // 
      this.ButtonNine.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonNine.Location = new System.Drawing.Point(193, 3);
      this.ButtonNine.Name = "ButtonNine";
      this.ButtonNine.Size = new System.Drawing.Size(89, 91);
      this.ButtonNine.TabIndex = 2;
      this.ButtonNine.Text = "9";
      this.ButtonNine.UseVisualStyleBackColor = true;
      this.ButtonNine.Click += new System.EventHandler(this.nine);
      // 
      // ButtonEight
      // 
      this.ButtonEight.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonEight.Location = new System.Drawing.Point(98, 3);
      this.ButtonEight.Name = "ButtonEight";
      this.ButtonEight.Size = new System.Drawing.Size(89, 91);
      this.ButtonEight.TabIndex = 1;
      this.ButtonEight.Text = "8";
      this.ButtonEight.UseVisualStyleBackColor = true;
      this.ButtonEight.Click += new System.EventHandler(this.eight);
      // 
      // ButtonSeven
      // 
      this.ButtonSeven.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ButtonSeven.Location = new System.Drawing.Point(3, 3);
      this.ButtonSeven.Name = "ButtonSeven";
      this.ButtonSeven.Size = new System.Drawing.Size(89, 91);
      this.ButtonSeven.TabIndex = 0;
      this.ButtonSeven.Text = "7";
      this.ButtonSeven.UseVisualStyleBackColor = true;
      this.ButtonSeven.Click += new System.EventHandler(this.seven);
      // 
      // ResultButton
      // 
      this.ResultButton.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ResultButton.Font = new System.Drawing.Font("Gulim", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.ResultButton.Location = new System.Drawing.Point(0, 441);
      this.ResultButton.Name = "ResultButton";
      this.ResultButton.Size = new System.Drawing.Size(386, 64);
      this.ResultButton.TabIndex = 2;
      this.ResultButton.Text = "＝";
      this.ResultButton.UseVisualStyleBackColor = true;
      this.ResultButton.Click += new System.EventHandler(this.resultClick);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(386, 505);
      this.Controls.Add(this.ResultButton);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.display);
      this.Name = "Form1";
      this.Text = "Form1";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label display;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Button PlusButton;
    private System.Windows.Forms.Button ButtonDot;
    private System.Windows.Forms.Button ButtonZero;
    private System.Windows.Forms.Button AllClearButton;
    private System.Windows.Forms.Button MinusButton;
    private System.Windows.Forms.Button ButtonThree;
    private System.Windows.Forms.Button ButtonTwo;
    private System.Windows.Forms.Button ButtonOne;
    private System.Windows.Forms.Button MultiplyButton;
    private System.Windows.Forms.Button ButtonSix;
    private System.Windows.Forms.Button ButtonFive;
    private System.Windows.Forms.Button ButtonFour;
    private System.Windows.Forms.Button DivideButton;
    private System.Windows.Forms.Button ButtonNine;
    private System.Windows.Forms.Button ButtonEight;
    private System.Windows.Forms.Button ButtonSeven;
    private System.Windows.Forms.Button ResultButton;
  }
}

