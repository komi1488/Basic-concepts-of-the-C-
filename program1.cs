using System;

class Program1 {
  static int Main() {
    
    int baseNumber = 0;
    int exponent = 0;
    int index = 0;
    int result = 1;

    Console.Write("a = ");
    baseNumber = int.Parse(Console.ReadLine());

    Console.Write("n = ");
    exponent = int.Parse(Console.ReadLine());

    for (index = 0; index < exponent; ++index) {
      result = result * baseNumber;
    }

    Console.WriteLine(baseNumber + "^" + exponent + " = " + result);
    return 0;
    }
}
