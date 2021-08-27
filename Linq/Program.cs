using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var startingDeck = (from s in Suits().LogQuery("Gerador Suit")
                               from r in Ranks().LogQuery("Gerador Rank")
                                select new { Suit = s, Rank = r }).LogQuery("Start");
            Console.WriteLine("=======INSERIR======");
            foreach (var c in startingDeck)
            {
                Console.WriteLine(c);
            }
            var top = startingDeck.Take(26);
            var bottom = startingDeck.Skip(26);
            var shuffle = top.InterleaveSequenceWith(bottom);


            Console.WriteLine("==========EMBARALHADO==========");
            foreach (var c in shuffle)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("========COMPARAÇÃO=========");

            // Query for building the deck

            // Shuffling using InterleaveSequenceWith<T>();

            var times = 0;
            // We can re-use the shuffle variable from earlier, or you can make a new one
            shuffle = startingDeck;

            do
            {
                /*
                shuffle = shuffle.Take(26).LogQuery("Bottom Half")
                    .InterleaveSequenceWith(shuffle.Skip(26).LogQuery("Top Half")
                    .LogQuery("Shuffle"));
                */
                shuffle = shuffle.Skip(26)
                    .LogQuery("Bottom Half")
                    .InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half"))
                    .LogQuery("Shuffle")
                    .ToArray();
                foreach (var card in shuffle)
                {
                    Console.WriteLine(card);
                }
                Console.WriteLine("=================="+times + "=====================");
                times++;
    
            } while (!startingDeck.SequenceEquals(shuffle));

            Console.WriteLine(times);
        }




        static IEnumerable<string> Suits()
        {
            yield return "clubs";
            yield return "diamonds";
            yield return "hearts";
            yield return "spades";
        }

        static IEnumerable<string> Ranks()
        {
            yield return "two";
            yield return "three";
            yield return "four";
            yield return "five";
            yield return "six";
            yield return "seven";
            yield return "eight";
            yield return "nine";
            yield return "ten";
            yield return "jack";
            yield return "queen";
            yield return "king";
            yield return "ace";
        }
    }
}
