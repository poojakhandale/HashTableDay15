using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class WordFrequency
    {
        public static void Frequency()
        {
            string sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            Hashtable wordFreq = new Hashtable();


            string[] words = sentence.Split(' ');


            foreach (string word in words)
            {
                if (wordFreq.ContainsKey(word))
                {
                    int count = (int)wordFreq[word];
                    wordFreq[word] = count + 1;
                }
                else
                {
                    wordFreq.Add(word, 1);
                }
            }

            foreach (string word in wordFreq.Keys)
            {
                Console.WriteLine("{0}: {1}", word, wordFreq[word]);
            }


            Console.WriteLine("---------------------------------");
            Console.WriteLine("New Frequencies after removing the Word avoidable: ");
            wordFreq.Remove("avoidable");

            Console.WriteLine("---------------------------------");


            foreach (string word in wordFreq.Keys)
            {
                Console.WriteLine("{0}: {1}", word, wordFreq[word]);
            }
        }
    }
}