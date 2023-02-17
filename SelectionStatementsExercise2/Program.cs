namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            var subject = Console.ReadLine();
            switch (subject) {
                case "Math": {
                        Console.WriteLine("Math is your favorite subject.");
                        break;
                    }

                case "Reading":
                    {
                        Console.WriteLine("Reading is your favorite subject.");
                        break;
                    }

                case "English":
                    {
                        Console.WriteLine("English is your favorite subject.");
                        break;
                    }

                case "Science":
                    {
                        Console.WriteLine("Science is your favorite subject.");
                        break;
                    }

                case "History":
                    {
                        Console.WriteLine("History is your favorite subject.");
                        break;
                    }

                case "Default":
                    {
                        Console.WriteLine("Nothing is your favorite subject.");
                        break;
                    }
            }
        }
    }
}