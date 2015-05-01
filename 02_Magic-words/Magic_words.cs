using System;
using System.Collections.Generic;

class Magic_words
{
    static void Main()
    {
        int numWords = int.Parse(Console.ReadLine());
        var list = new List<string>();
        int maxLen = 0;
        
        //input
        for(int i=0; i<numWords; i++){
            String word = Console.ReadLine();
            maxLen = Math.Max(maxLen, word.Length);
            list.Add(word);
        }
        
        //reorder
        for (int i = 0; i < numWords; i++)
        {
            int oldPosition = i;
            string word = list[oldPosition];
            int newPosition = word.Length % (numWords + 1);
            list.Insert(newPosition, word);
            if(newPosition<=oldPosition){
                oldPosition++;
            }
            list.RemoveAt(oldPosition);
        }
        //print
        for (int j = 0; j < maxLen; j++)
        {
            for (int i = 0; i < numWords; i++)
            {
                if (j < list[i].Length)
                {
                    Console.Write(list[i][j]);
                }
            }
        }
        Console.WriteLine();
    }
}
