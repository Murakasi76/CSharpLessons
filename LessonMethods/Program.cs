namespace LessonMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 94;

            decimal celceuse = (fahrenheit - 32) * ((decimal)5 / 9);
            Console.WriteLine("Celceuse = " + celceuse);
            string projectName = "ACMA";

            Console.WriteLine($@"C:\User\Projects\{projectName}\project.exe");
            Console.WriteLine("********************************");
            string userName = AskNameUser();
            string text = GreetingUser(userName);
            Console.WriteLine(text);
        }

        /// <summary>
        /// Greeting user by a name
        /// </summary>
        /// <param name="name">Name user</param>
        /// <returns>string with greeting and name</returns>
        static string GreetingUser(string name)
        {
            if (name == "Anonymous")
            {
                return "Hi anonymous.";
            }
            return $"Hello {name}! Have good Day!";
        }


        /// <summary>
        /// Ask name user
        /// </summary>
        /// <returns>string name of user or if amty return Anonymous</returns>
        static string AskNameUser()
        {
            string? name;

            Console.Write("Enter you'r name: ");
            name = Console.ReadLine();
            if (name == "" || name == null)
            {
                name = "Anonymous";
            }

            return name;
        }
    }
}
