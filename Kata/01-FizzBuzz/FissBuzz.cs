using System;
using System.Globalization;

namespace Kata.FissBuzz;

public class FissBuzz
{
    
    public const string buzz = "Buzz";
    public const string fizz = "Fizz";
    public readonly string argumentExceptioNumberNotInRule = "entered number is [{0}], which does not meet rule, entered number should be between 1 to 100.";


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
                   argumentExceptioNumberNotInRule,
                    number));
        return string.Empty;
    }
    public string GetFissBuzz(int input)
    {
        string resultFizzBuzz = string.Empty;       
        if (IsFizz(input)) 
                resultFizzBuzz += fizz;
        if (IsBuzz(input))
                resultFizzBuzz += buzz;
        if (string.IsNullOrEmpty(resultFizzBuzz))
            resultFizzBuzz += input.ToString();

       return resultFizzBuzz;
    }
    public string GetFissBuzz()
    {
        string resultFizzBuzz = string.Empty;
        for (var i = 1; i <= 100; i++)
        {
            var printNumber = string.Empty;
            printNumber += GetFissBuzz(i);

            if (string.IsNullOrEmpty(printNumber))
                printNumber = i.ToString(CultureInfo.InvariantCulture);

            resultFizzBuzz += " " + printNumber;
        }
        return resultFizzBuzz.Trim();
    }

    private bool IsBuzz(int i) => i % 5 == 0;

    private bool IsFizz(int i) => i % 3 == 0;


}

