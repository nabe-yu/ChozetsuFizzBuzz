using System;
using System.Linq;
using System.Collections.Generic;
using FizzBuzz.Core;

var fizzbuzz = new NumberConverter(new IReplaceRule[] {
    new CyclicNumberRule(3, "Fizz"),
    new CyclicNumberRule(5, "Buzz"),
    new PassThroughRule()
});

foreach (var i in Enumerable.Range(1, 16))
{
    Console.WriteLine(fizzbuzz.convert(i));
}
