namespace String_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = new string[6];
            Console.WriteLine("enter strings");
            for (int i = 0; i < words.Length; i++)
            {

                words[i] = Console.ReadLine();

            }
            string shortest = words[0];
            for(int i=0; i<words.Length; i++)
            {
                if (words[i].Length < shortest.Length)
                {
                    shortest = words[i];
                }
            }
            Console.WriteLine($"the shortest word is {shortest} ");
            Console.WriteLine("enter another word");
            string str2 = Console.ReadLine();
            bool found = false;
            for (int i = 0; i < words.Length; i++)
            {
                if (str2 == words[i])
                {
                    found = true;
                    break;
                }

            }
            if (found)
            {
                Console.WriteLine($"the word {str2} present in the list");
            }
            else { Console.WriteLine($"the word {str2} is not present in list"); }
            Console.WriteLine("the alphabetical order is:");

            Array.Sort(words);
            foreach(string word in words)
            {
                Console.WriteLine( word);
            }

            int pc = 0;
            string palindromes = "";
            for (int i = 0; i < words.Length; i++)
            {
                string revwords = "";
                for (int j = words[i].Length - 1; j >= 0; j--)
                {
                    revwords += words[i][j];
                }
                if (words[i] == revwords)
                {
                    pc++;
                    palindromes += words[i];
                }
            }
            if (pc > 0)
            {
                Console.WriteLine("the number palindromes in the list " + pc);
                Console.WriteLine(palindromes);
            }
            else
            {
                Console.WriteLine("there are no palindromes in the list");
            }
        }
    }
}