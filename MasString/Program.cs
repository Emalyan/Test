using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasString
{
    class Program
    {
        static Random rand = new Random();
        static readonly List<string> letter;
        static string text;
        static int index;
        static int countInLine;
        






        static Program()
        {
            countInLine = 2;
            letter = new List<string>();
            InitLetter(20);
            
        }

        static void Main(string[] args)
        {

            text = CreateString();
            Console.WriteLine("random text: " + text);
            

            
            TrySearch();
            Looping();
            

            Console.ReadKey();
            
        }
        
        static void InitLetter(int listLength)
        {
            //создаем массив в котором значения не могут повторятся
            int i = 0;
            while(i < listLength)
            {
                string s = CreateString();

                if (!letter.Contains(s))
                {
                    letter.Add(s);
                    Console.WriteLine(i + ": " + letter[i]);
                    i = i + 1;
                }
                else
                {
                
                    Console.WriteLine("Значение " + s + " уже существует");
                }
            }
            //создаем массив в котором значения могут повторятся
            /*for(int i = 0; i < listLength; i++)
            {      
                letter.Add(CreateString());
                Console.WriteLine(i + ": " + letter[i]);
                
            }*/
        }
        //создает строку
        static string CreateString()
        {
            
            string s = "";
            for (int k = 0; k < countInLine; k++)
            {
                int random = rand.Next(97, 122);
                char symbol = (char)random;
                s = s + symbol;
            }

            return s;

        }

        static void WriteOutPut()
        {
            if (index == -1)
            {
                Console.WriteLine("Строка не найдено");
            }
            else
            {
                Console.WriteLine($"Строка {text} найдено по индексу {index}");
            }
        }

        static void TrySearch()
        {
           
            index = letter.IndexOf(text);
            WriteOutPut();
        }

        static string AskQuestionsAndGetAnswer()
        {
            Console.WriteLine("Что бы выйти из пробраммы введите exit, что бы продолжить введите символ");
            return Console.ReadLine();
        }

        static void Looping()
        {
            text = AskQuestionsAndGetAnswer();

            while (!text.ToUpper().Equals("EXIT"))
            {
                TrySearch();
                text = AskQuestionsAndGetAnswer();

            }
        }











    }
}
