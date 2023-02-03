namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorie subject?");
            { var reply = 0;
                do
                {
                    reply++;
                    string subject = Console.ReadLine();

                    switch (subject.ToLower())
                    {
                        case "math":
                        case "calculus":
                        case "algebra":
                            Console.WriteLine("I hate Math!");
                            break;
                        case "science":
                        case "biology":
                        case "chemestry":
                            Console.WriteLine("I love Science!");
                            break;
                        case "gym":
                        case "pe":
                        case "phys ed":
                            Console.WriteLine("Gym is for meat heads");
                            break;
                        case "History":
                        case "Social Studies":
                            Console.WriteLine("History is in the past");
                            break;
                        case "english":
                            Console.WriteLine("Si,me Gusta English!");
                            break;
                        default:
                            Console.WriteLine("I am lucky and never needed to worry about that subject");
                            break;
                    }
                    if (reply != 3)
                    {
                        Console.WriteLine("Were there any others that you liked?");
                    }
                    else
                    {
                        Console.WriteLine();
                    }

                } while (reply != 3);
                Console.WriteLine("It was nice hearing about your classes.  Have a great day!");

             }
        }
    }
}