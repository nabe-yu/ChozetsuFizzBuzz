namespace FizzBuzz.Core;
class NumberConverter
{
    protected IReplaceRule[] rules;
    public NumberConverter(IReplaceRule[] rules)
    {
        this.rules = rules;
    }
    public string convert(int n)
    {
        var carry = "";
        foreach (var rule in rules)
        {
            if (rule.match(carry, n))
            {
                carry = rule.apply(carry, n);
            }
        }
        return carry;
    }
}