using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{public  class WordFrequency
    {
      
            public static void Frequency()
            {
                string sentence = "To be or not to be";
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
            }
        }
    }
   
    

