using System;

class Multiverse_communication
{
    static void Main()
    {
        String[] chunks = {"CHU","TEL","OFT", "IVA", "EMY","VNB", "POQ", "ERI", "CAD", "K-A", "IIA", "YLO", "PLA"};
        String msg = Console.ReadLine().ToUpper();
        ulong result = 0;
        int numChunks = msg.Length / 3;
        for(int i=0; i<numChunks; i++){
            String chunk = msg.Substring(i*3, 3);
            int chunkVal = Array.IndexOf(chunks, chunk);
            result += (ulong)chunkVal* (ulong)Math.Pow(13, numChunks - i - 1);
        }
        Console.WriteLine(result);
    }
}
