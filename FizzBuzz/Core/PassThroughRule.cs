namespace FizzBuzz.Core;

class PassThroughRule : IReplaceRule
{
    public string apply(string carry, int n)
    {
        return n.ToString();
    }

    public bool match(string carry, int n)
    {
        return carry == "";
    }
}