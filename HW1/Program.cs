namespace HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             The task:
             1. Get a block of text from the user (here it's hardcoded).
             2. Split this text into sentences.
             3. Store these sentences in a jagged array, where:
                - Each element of the jagged array is an array of words.
                - Each sentence becomes its own array of strings.
             4. Print all words stored inside the jagged array.
            */

            // The source text (normally the user would enter it)
            string textString =
                "Write a program in which you receive a block of text from the user. " +
                "Store this text as a jagged array, where each element is an array of strings. " +
                "Each array of strings should represent the set of words that make up one sentence " +
                "of the input text, where words are separated by spaces. " +
                "Output all words stored inside the jagged array and its inner elements.";

            // Split the text into sentences by ". "
            // Each element of 'text' will contain one sentence
            string[] text = textString.Split(". ");

            // Print how many sentences were found
            Console.WriteLine($"Length of array (number of sentences) = {text.Length}");

            int count = 0;

            // Loop through each sentence and print it
            foreach (var n in text)
            {
                if (n != "") // Ignore empty elements if they appear
                {
                    count++;
                    Console.WriteLine($"{count}: {n.Trim()}");
                }
            }

            // Declare a jagged array:
            // words[i] will be an array of words from sentence i
            string[][] words = new string[text.Length][];

            // Fill the jagged array
            for (int i = 0; i < text.Length; i++)
            {
                // Split each sentence into words (separated by spaces)
                string[] word = text[i].Split(" ");

                // Assign this array of words into the jagged array
                words[i] = word;
            }

            Console.WriteLine("*************************");

            // Print number of words in the last sentence
            Console.WriteLine(words[words.Length - 1].Length);

            // Print every word from the last sentence
            foreach (var w in words[words.Length - 1])
            {
                Console.WriteLine(w);
            }
        }
    }
}
