namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FavSubject();
        }

        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite subject?");
            string subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("I am math");
                    break;
                case "science":
                    Console.WriteLine("Science rules!");
                    break;
                case "p.e.":
                case "pe": 
                case "physical education":
                    Console.WriteLine("don't skip leg day");
                    break;
                case "history":
                    Console.WriteLine("History is my favorite too");
                    break;
                case "geography":
                    Console.WriteLine("I love to study the world");
                    break;
                default:
                    Console.WriteLine("I like that too");
                    break;
            }
        }
    }
}