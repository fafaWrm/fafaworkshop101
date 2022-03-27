using System;
using System.Globalization;

namespace Kata.FissBuzz;

public class FissBuzz
{


    public string PrintFizzBuzz()
    {
        return GetFissBuzz();
    }
    public string PrintFizzBuzz(int number)
    {
        CheckWhenNumberNotInRule(number);
        return GetFissBuzz(number);
    }
    public string CheckWhenNumberNotInRule(int number)
    {
        if (number > 100 || number < 1)
            throw new ArgumentException(
                string.Format(
                    "entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.",
                    number));
        return string.Empty;
    }
    public string GetFissBuzz(int input)
    {
        if ((input % 5 == 0) && (input % 3 == 0)) return "FizzBuzz";
        if (input % 5 == 0) return "Buzz";
        if (input % 3 == 0) return "Fizz";
        return input.ToString();
    }
    public string GetFissBuzz()
    {
        string resultFizzBuzz = string.Empty;
        for (var i = 1; i <= 100; i++)        {
            var printNumber = string.Empty;
             printNumber += GetFissBuzz(i);                  
          
            if (string.IsNullOrEmpty(printNumber))
                printNumber = i.ToString(CultureInfo.InvariantCulture);
            
            resultFizzBuzz += " " + printNumber;
        }
        return resultFizzBuzz.Trim();
    }
}

