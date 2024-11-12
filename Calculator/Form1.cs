using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
  public partial class Form1 : Form
  {
    //열거형
    enum Operators
    {
      None,
      Add,
      Subtract,
      Multiply,
      Divide,
      Result
    }

    //연산 종류 결정 변수 초기화
    Operators currentOperator = Operators.None;
    //연산 버튼 클릭 여부 변수 초기화
    Boolean operatorChangeFlag = false;

    int firstOperand = 0;
    int secondOperand = 0;

    public Form1()
    {
      InitializeComponent();
    }

    private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
    {

    }

    private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
    {

    }

    private void resultClick(object sender, EventArgs e)
    {
      secondOperand = Int32.Parse(display.Text);
      if(currentOperator == Operators.Add)
      {
        firstOperand += secondOperand;
        display.Text = firstOperand.ToString();
      }
      else if (currentOperator == Operators.Subtract)
      {
        firstOperand -= secondOperand;
        display.Text = firstOperand.ToString(); 
      }
      else if (currentOperator == Operators.Multiply)
      {
        firstOperand *= secondOperand;
        display.Text = firstOperand.ToString();
      }
      else if (currentOperator == Operators.Divide)
      {
        if (secondOperand == 0)
        {
          display.Text = "0으로 나눌 수 없습니다";
        }
        else
        {
          firstOperand /= secondOperand;
          display.Text = firstOperand.ToString();
        }
      }

    }

    private void plusClick(object sender, EventArgs e)
    {
      firstOperand = Int32.Parse(display.Text);
      currentOperator = Operators.Add;
      operatorChangeFlag = true;
    }
    private void minusClick(object sender, EventArgs e)
    {
      firstOperand = Int32.Parse(display.Text);
      currentOperator = Operators.Subtract;
      operatorChangeFlag = true;
    }
    private void multiplyClick(object sender, EventArgs e)
    {
      firstOperand = Int32.Parse(display.Text);
      currentOperator = Operators.Multiply;
      operatorChangeFlag = true;

    }
    private void divideClick(object sender, EventArgs e)
    {
      firstOperand = Int32.Parse(display.Text);
      currentOperator = Operators.Divide;
      operatorChangeFlag = true;
    }

    private void allClear(object sender, EventArgs e)
    {
      firstOperand = 0;
      secondOperand = 0;
      currentOperator = Operators.None;
      display.Text = "0";
    }

    private void zero(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "0";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }

    private void one(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "1";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }

    private void two(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "2";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }

    private void three(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "3";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }
    private void four(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "4";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }

    private void five(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "5";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }

    private void six(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "6";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }

    private void seven(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "7";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }

    private void eight(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "8";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }

    private void nine(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += "9";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }

    private void dot(object sender, EventArgs e)
    {
      if (operatorChangeFlag == true)
      {
        display.Text = "";
        operatorChangeFlag = false;
      }
      string strNumber = display.Text += ".";
      int intNumber = Int32.Parse(strNumber);
      display.Text = intNumber.ToString();
    }


  }
}
