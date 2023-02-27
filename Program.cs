// See https://aka.ms/new-console-template for more information
using HashTable;

class Program
{
    static void Main(string[] args)
    {
        string sentence = "To be or not to be";
        string[] words = sentence.ToLower().Split(' ');

        MyLinkedList<string, int> linkedList = new MyLinkedList<string, int>(words.Length);

        foreach (string word in words)
        {
            int frequency = linkedList.Get(word);
            if (frequency == 0)
            {
                linkedList.Add(word, 1);
            }
            else
            {
                linkedList.Add(word, frequency + 1);
            }
        }

        for (int i = 0; i < words.Length; i++)
        {
            int frequency = linkedList.Get(words[i]);
            if (frequency != 0)
            {
                Console.WriteLine($"'{words[i]}' occurs {frequency} times.");
                linkedList.Add(words[i], 0);
            }
        }
    }
}

