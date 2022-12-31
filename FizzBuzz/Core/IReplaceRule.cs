namespace FizzBuzz.Core;

interface IReplaceRule
{
    public string apply(string carry, int n);
    public bool match(string carry, int n);
}