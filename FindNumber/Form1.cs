using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindNumber
{
  public partial class Form1 : Form
  {
    private int findNumber = 0;
    private int chance = 0;

    public Form1()
    {
      InitializeComponent();
    }

    private void insertNum(object sender, EventArgs e)
    {
      int inputNumber = Int32.Parse(textBox1.Text);

      if (inputNumber == findNumber)
      {
        hint.Text = ""; //승리해도 이전에 있던 힌트가 계속 나와서 초기화 해줌
        display.Text = "승리했습니다!!";
      } else
      {
        chance--;
        display.Text = "기회는 " + chance + "번 남았습니다.";

        //힌트가 필요할 거 같아서 내가 추가함
        if (inputNumber <= findNumber) 
        {
          hint.Text = "입력한 숫자보다 큽니다.";
        }
        else
        {
          hint.Text = "입력한 숫자보다 작습니다.";
        }
      }

      if (chance <= 0)
      {
        display.Text = "실패했습니다!";
      }
    }

    private void gameStart(object sender, EventArgs e)
    {
      var rand = new Random();

      findNumber = rand.Next(1,21);
      chance = 10;
      display.Text = "맞출 숫자를 입력하세요";

    }
  }
}
