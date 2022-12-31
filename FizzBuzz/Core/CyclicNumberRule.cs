namespace FizzBuzz.Core;

class CyclicNumberRule : IReplaceRule
{

    private int baseNumber;
    private string replacement;

    public CyclicNumberRule(int baseNumber, string replacement)
    {
        this.baseNumber = baseNumber;
        this.replacement = replacement;
    }

    public string apply(string carry, int n)
    {

        return $"{carry}{replacement}";
    }

    public bool match(string carry, int n)
    {
        return n % baseNumber == 0;
    }
}
