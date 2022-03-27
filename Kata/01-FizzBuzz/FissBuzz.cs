namespace Kata.FissBuzz;

public class FissBuzz
{

    public string GetFissBuzz(int input)
    {
        if (input % 3 == 0) return "Fizz";
        return input.ToString();
    }
}

