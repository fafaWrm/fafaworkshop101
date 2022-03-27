using System;

namespace Kata.FissBuzz;

public class FissBuzz
{

    public string GetFissBuzz(int input)
    {
        if ((input % 5 == 0) && (input % 3 == 0)) return "FizzBuzz";
        if (input % 5 == 0) return "Buzz";
        if (input % 3 == 0) return "Fizz";
        return input.ToString();
    }
    public  string PrintFizzBuzz(int number)
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
}

