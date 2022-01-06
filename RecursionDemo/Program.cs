namespace RecursionDemo
{
    public class Program
    {
        public static void Main()
        {
            var datetime = DateTime.Now;
            Console.WriteLine(datetime);

            var input = "This is a really really really-really really long string.. :)";
            Console.WriteLine(input);

            Console.WriteLine("Start");

            Recurse(input, 7);

            Console.WriteLine("End");
        }

        public static void Recurse(string input, int length, int position = 0)
        {
            bool exit = false;
            {
                if (position > 0 && position + length >= input.Length)
                {
                    length = input.Length - position;
                    exit = true;
                }
            }

            var processed = input.Substring(position, length);
            position += length;

            Console.WriteLine($"{position:D2} {processed}");

            if (exit)
            {
                return;
            }

            Recurse(input, length, position);
        }
    }
}