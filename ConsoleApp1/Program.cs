using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Program
  {
    static void Main(string[] args)
    {
      int count = 3;

      List<int> list = new List<int>();
      int[] ints1 = new int[3] { 1, 2, 3 };

      ints1[0] = 1;
      ints1[1] = 2;
      ints1[2] = 3;

      list.Add(1);
      list.Add(2);
      list.Add(5);

      for (int i = 0; i < 3; i++)
      {
        if (i ==0)
        {
          Console.WriteLine("count는 0입니다.");
        }
        if (i == 1)
        {
          Console.WriteLine("count는 1입니다.");
        }
        else
        {
          Console.WriteLine("count는 0이 아닙니다.");
        }
        Console.WriteLine(ints1[i]);
      }

      Console.WriteLine();

      foreach (int x in list)
      {
        Console.WriteLine(x);
      }

      Console.WriteLine();

      while (count != 0)
      {
        Console.WriteLine(count);
        count--;
      }

      count++;
      switch (count)
      {
        case 0: 
          Console.WriteLine("count는 0 입니다");
          break;
        case 1:
          Console.WriteLine("count는 1 입니다.");
          break;
        case 2:
          Console.WriteLine("count는 2 입니다.");
          break;
      }
      Console.ReadLine();
    }
  }

  public class Print
  {
    public void PrintHello()
    {
      string text = "hello world!";
      Console.WriteLine(text);
      Console.ReadLine();
    }
  }

  class Car
  {
    int field = 1; //4바이트 정수
    long field1 = 11; //8바이트 정수
    char field2 = 'a'; //2 바이트 유니코드 문자
    float field3 = 1.1f; //4바이트 실수
    double field4 = 1.1; //8바이트 실수
    string field5 = "aaaa"; //가변 사이즈 문자열
    bool field6 = true;

    private string name;

    public string Name
    {
      get { return name; }
      set { name = value; }
    }

    public int Speed { get; set; }

    public int Speed2 { get; private set; }//get만 허용, 외부에서 set할 수 없도록 함 동일 클래스 안에서만 설정이 가능함
  }

}
