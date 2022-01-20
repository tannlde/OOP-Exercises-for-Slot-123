using System;
using System.Collections.Generic;

namespace Exercise_3
{
    class Program
    {
        static int InputInteger(string var = "a integer")
        {
            Console.Write($"Enter {var}: ");
            int x;
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine($"Must be a integer!");
                Console.Write($"Enter {var}: ");
            }
            return x;
        }
        static void Main(string[] args)
        {
            int numSongs = InputInteger("number of songs");
            List<Song> listSongs = new();
            for (int i = 0; i < numSongs; i++)
            {
                String[] data = Console.ReadLine().Split("_");
                try
                {
                    listSongs.Add(new Song(data[0], data[1], data[2]));

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong format input ({typeList}_{name}_{time})");
                }
            }
            String typeList = Console.ReadLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("Result: ");
            if (typeList == "all")
            {
                foreach (var song in listSongs)
                {
                    Console.WriteLine(song.Name);
                }
                return;
            }
            foreach (var song in listSongs)
            {
                if (song.TypeList == typeList) Console.WriteLine(song.Name);
            }
        }
    }
}
