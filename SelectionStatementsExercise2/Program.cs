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
            Console.WriteLine("What is your favorite school subject?");
            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "math":
                    Console.WriteLine("Ooo, that's my favorite subject, too! Along with PE.");
                    break;
                case "science":
                    Console.WriteLine("Science is incredible, learning the materials and processes that make up our reality :).");
                    break;
                case "english":
                    Console.WriteLine("I love English, it challenges and encourages us to nurture our internal narratives, as well as strengthen our skill in communicating them to the world.");
                    break;
                case "history":
                    Console.WriteLine("Such an important subject; we will never learn if we don't know our past, we will doom ourselves to repeat it otherwise.");
                    break;
                case "pe":
                case "physical education":
                case "gym":
                    Console.WriteLine("My favorite subject, too! Along with math. I love the freedom of being physically active and growing stronger!");
                    break;
                default:
                    Console.WriteLine("Cool choice! What makes it your favorite?");
                    break;
            }
        }
    }
}