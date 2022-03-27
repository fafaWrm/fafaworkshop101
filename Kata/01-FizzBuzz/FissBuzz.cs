namespace Kata.FissBuzz;

public class FissBuzz
{

    public string GetFissBuzz(int input)
    {
        if (input % 5 == 0) return "Buzz";
        if (input % 3 == 0) return "Fizz";
        return input.ToString();
    }
}

