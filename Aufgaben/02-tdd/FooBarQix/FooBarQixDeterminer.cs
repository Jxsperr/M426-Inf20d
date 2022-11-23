namespace FooBarQix
{
    public class FooBarQixDeterminer
    {
        public string Determine(int input)
        {
            string result = "";

            if (input % 3 == 0) result += "Foo";
            if (input % 5 == 0) result += "Bar";
            if (input % 7 == 0) result += "Qix";

            return result;
        }
    }
}