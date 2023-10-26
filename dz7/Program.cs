using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    enum Type
    {
        Current,
        Savings
    }
    internal class Program
    {
        public static bool ImplementsIFormattable(object input)
        {
            return input is IFormattable;
        }

        public static string ToReadBackWords (string text)
        {
            char[] chars = text.ToCharArray ();
            Array.Reverse(chars);
            return new string (chars);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("упражнение 8.1");
            Console.WriteLine("введите строку");
            string text = Console.ReadLine();
            text = ToReadBackWords(text);
            Console.WriteLine($"{text}");

            Console.WriteLine("упражнение 8.2");
            Bank account1 = new Bank();
            account1.balance = 4567;
            Bank account2 = new Bank();
            account2.balance = 67565;
            Bank.TransferMoney(account1, account2, 200);
            Console.WriteLine($"баланс счета 1: {account1.balance}");
            Console.WriteLine($"баланс счета 2: {account2.balance}");

            Console.WriteLine("упражнение 8.4");
            int number = 123;
            if (ImplementsIFormattable(number))
            {
                Console.WriteLine("число реализует IFormattable");
            }
            else
            {
                Console.WriteLine("число не реализует IFormattable");
            }

            Console.WriteLine("дз 8.2");
            List<Song> songs = new List<Song>();

            Song song1 = new Song();
            song1.SetName("ya russki");
            song1.SetAuthor("shaman");
            songs.Add(song1);

            Song song2 = new Song();
            song2.SetName("kakaya autmn v lageryah");
            song2.SetAuthor("butyrka");
            songs.Add(song2);

            Song song3 = new Song();
            song3.SetName("бездел");
            song3.SetAuthor("олечка бузова");
            songs.Add(song3);

            Song song4 = new Song();
            song4.SetName("хаюхай");
            song4.SetAuthor("eeoneguy");
            songs.Add(song4);

            foreach (Song song in songs)
            {
                Song s = new Song(); 
                Console.WriteLine($"{s.Print()}"); 
            }
            if (song1.Equals(song2))
            {
                Console.WriteLine("первая песня совпадает со второй песней");
            }
            else
            {
                Console.WriteLine("первая песня не совпадает со второй песней");
            }
            Console.ReadKey();
        }
    }
}
