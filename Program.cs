using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labwork_28._02._2023
{
    class Word {
        public static Dictionary<string, int> CountWord(string text) {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            string[] words = text.Split(new char[] { ' ', ',' });
            string[] copy = new string[text.Length];
            int count = 0; string word;
            for(int i = 0; i < words.Length; i++) {
                word = Array.Find(copy, str => str == words[i]);
                if (words[i] != word) {
                    for (int j = 0; j < words.Length; j++) {
                    if (words[i] == words[j]) {
                        count++;
                    }
                }
                copy[i] = words[i];
                dic.Add(words[i], count);
                count = 0;
                }
            }
            return dic;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hi my name is name my my";
            Dictionary<string, int> dic = Word.CountWord(str);

            ICollection<string> keys = dic.Keys;

            Console.WriteLine("База данных содержит: ");
            foreach (string j in keys) { 
                Console.WriteLine("ID -> {0}  Amount -> {1}", j, dic[j]); 
            }
                

        }
    }
}
