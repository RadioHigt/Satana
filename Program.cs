using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Привет, я Клоун, веселая программа");
    Console.WriteLine("Ха-ха-ха");
    Console.WriteLine("Ваш калькулятор");
    Console.WriteLine("Введите первое число");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите второе число");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Укажите функцию");
    string c = Console.ReadLine();
    if (c == "+")
    {
        plus(a,b);
    }
    else if(c == "-")
    {
        minus(a,b);
    }
    else if(c == "/")
    {
        division(a,b);
    }
    else if(c == "*")
    {
        multiplication(a,b);
    }
    else
    {
      Console.WriteLine("Нет такой функции");  
    }
  }
  public static void plus(int a, int b)
  {
      Console.WriteLine( a+b);
  }
  public static void minus(int a,int b)
  {
      Console.WriteLine(a+b);
  }
}
