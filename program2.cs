using System;
class Program2 {
  static int Main() {
  Console.Write("Enter the number x (at least 3 digits): ");
  string input = Console.ReadLine();

  int resultNumber = 0;
  char firstDigit = input[0];
  char secondDigit = input[1];
  string rest = input.Substring(2);

  string withoutSecond = firstDigit + rest;

  string resultStr = withoutSecond + secondDigit;

  resultNumber = int.Parse(resultStr);

  Console.WriteLine($"n = {resultNumber}");
  return 0;
  }
}