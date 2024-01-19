namespace _13._6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int ResultRange = 10;
            var text = File.ReadAllText(@"C:\Users\Роман\Desktop\text.txt");
            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] words = noPunctuationText.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCounter = new Dictionary<string, int>();
            string[] resultWords = new string[ResultRange];
            int[] resultNembers = new int[ResultRange];

            for (int i = 0; i < words.Length; i++)
            {
                if (!wordCounter.ContainsKey(words[i]))
                    wordCounter.Add(words[i], 0);
                else wordCounter[words[i]]++;
            }

            for (int i = 0; i < ResultRange; i++)
            {
                int currentValue = 0;

                foreach (var word in wordCounter)
                {
                    if (word.Value > currentValue)
                    {
                        resultWords[i] = word.Key;
                        resultNembers[i] = word.Value;
                        currentValue = word.Value;
                    }
                }

                wordCounter.Remove(resultWords[i]);
            }

            for (int i = 0; i < ResultRange; i++)
                Console.WriteLine($"{i + 1}. {resultWords[i]} = {resultNembers[i]}");
        }
    }
}

