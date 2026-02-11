using System;

class Program2 {
  static int Main() {
    
    string input;
    Console.Write("Enter the number x (at least 3 digits): ");
    input = Console.ReadLine();
    
    string digitsFromThird;
    int resultNumber;

    digitsFromThird = input.Substring(2);

    char firstDigit = input[0];
    char secondDigit = input[1];
    string withoutSecond;
    string resultStr;
    
    withoutSecond = firstDigit + digitsFromThird;
    resultStr = withoutSecond + secondDigit;
    
    resultNumber = int.Parse(resultStr);
    Console.WriteLine($"n = {resultNumber}");
    return 0;
  }
}
