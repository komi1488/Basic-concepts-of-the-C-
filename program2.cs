using System;

class Program2 {
  static int Main() {
    Console.Write("Enter the number x (at least 3 digits): ");
    
    string input;
    string digitsFromThird;
    int resultNumber = 0;

    input = Console.ReadLine();
    char firstDigit = input[0];
    char secondDigit = input[1];
    digitsFromThird = input.Substring(2);
    
    string withoutSecond = firstDigit + digitsFromThird;

    string resultStr = withoutSecond + secondDigit;

    resultNumber = int.Parse(resultStr);

    Console.WriteLine($"n = {resultNumber}");
    return 0;
    }
}
