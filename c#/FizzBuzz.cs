using System.Globalization;

namespace FizzBuzz
{
    public static class FizzBuzz
    {
        public static string GetTheFizz(int testValue)
        {
            if (testValue%3 == 0 && testValue%5 == 0)
                return "FizzBuzz";
            if (testValue%3 == 0)
                return "Fizz";
            if (testValue%5 == 0)
                return "Buzz";
            return testValue.ToString(CultureInfo.InvariantCulture);
        }
    }
}
