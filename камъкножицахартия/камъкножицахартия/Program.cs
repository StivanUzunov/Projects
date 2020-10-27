using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Threading;

namespace КамъкНожицаХартия
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintVersionAndGreet();
            AskToPlay();
            Thread.Sleep(1500);
            Console.WriteLine("Накратко обяснение на правилата:");
            
            ExplainTheRules();
            Count();
            int winsUser = 0;
            int winsPC = 0;
            Game(ref winsUser,ref winsPC);
        }
        static void PrintVersionAndGreet()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Камък Ножица Хартия Версия:0.0.1 Създател:Стивън Узунов");
            Console.ResetColor();
            Console.WriteLine("Моля въведете име: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string name = Console.ReadLine();
            Console.WriteLine($"Здравей, {name}");
            Console.ResetColor();
            Console.WriteLine("Искаш ли да играем прословутата игра Камък,ножица или хартия?");
            Console.WriteLine("Отговори с да или не!");

        }
        static void AskToPlay()
        {

            string answear = Console.ReadLine().ToLower();
            if (answear == "да")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Страхотно! Нека започнем играта тогава!");
                Console.ResetColor();
            }
            else if (answear == "не")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Явно изпитваш страх от провала!");
                Console.ResetColor();
                Console.WriteLine("Така ли е?");
                Console.WriteLine("да или не?");
                string secondAnswear = Console.ReadLine().ToLower();
                while (true)
                {
                    if (secondAnswear == "да")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Страхливец! Отивай да играеш Шах тогава!");
                        Thread.Sleep(8000);
                        Console.ResetColor();
                        Environment.Exit(0);
                    }
                    else if (secondAnswear == "не")
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Тогава нека играта започне!");
                        Console.ResetColor();
                        break;

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Моля отговори с да или не?");
                        Console.ResetColor();
                        secondAnswear = Console.ReadLine().ToLower();
                        if (secondAnswear == "да")
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Страхливец! Отивай да играеш Шах тогава!");
                            Console.ResetColor();
                            Environment.Exit(0);
                        }
                        else if (secondAnswear == "не")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Тогава нека играта започне !");
                            Console.ResetColor();
                            break;

                        }

                    }
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Моля отговорете с да или не !");
                Console.ResetColor();
                AskToPlay();
            }
            Thread.Sleep(1500);
        }
        static void ExplainTheRules()
        {
            Thread.Sleep(3500);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Броя до три и казвам Камък,ножица хартия раз два три.");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("При което двамата избираме между камък,ножица или хартия.");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Камъкът бие ножицата.");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ножицата бие хартията.");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Хартията бие камъка.");
            Thread.Sleep(2500);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("При еднакви се играе наново.");
            Console.ResetColor();
            Thread.Sleep(5000);
            Console.WriteLine("Готов ли си?");
            Console.WriteLine("да или не?");
            string answearReady = Console.ReadLine().ToLower();
            if (answearReady == "не")
            {

                Console.WriteLine("https://globet.games/game/%D0%BA%D0%B0%D0%BC%D1%8A%D0%BA-%D0%BD%D0%BE%D0%B6%D0%B8%D1%86%D0%B0-%D1%85%D0%B0%D1%80%D1%82%D0%B8%D1%8F/");
                Console.WriteLine("Моля прочети правилата тук и когато си готов напиши готов :)");
                Console.ForegroundColor = ConsoleColor.Yellow;
                string ready = Console.ReadLine().ToLower();
                while (ready!="готов")
                {
                    ready = Console.ReadLine().ToLower();
                    if (ready == "готов")
                    {
                        Console.ResetColor();
                        continue;
                    }

                }
            }
            else if (answearReady != "да")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Не мога да ти разбера отговора, би ли отговорил с да или не?");
                Console.ResetColor();
                Console.WriteLine("Готов ли си?");
                Console.WriteLine("да или не?");
                answearReady = Console.ReadLine().ToLower();
                if (answearReady == "не")
                {
                    Console.WriteLine("Разяснявам отново :)");
                    ExplainTheRules();
                }
                else if (answearReady != "да")
               
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Съжалявам, продължавам да не разбирам твоите отговори!");
                    Console.WriteLine("Моля пусни програмата наново и следвай правилата!");
                    Console.ResetColor();
                    Thread.Sleep(8000);
                    Environment.Exit(0);
                }

            }

        }
        static void Count()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("1,");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("2,");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Камък,");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Ножица,");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Хартия");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Раз,");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Два,");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Три!");
            Console.ResetColor();
        }
      
        static void Game(ref int winsUser,ref int winsPC )
        {
            string pickOfUser = Console.ReadLine().ToLower();
            string randomTemp = "";
          
            if (pickOfUser != "камък" && pickOfUser != "ножица" && pickOfUser != "хартия")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Съжалявам, това не е валиден избор, моля опитай отново!");
                Console.ResetColor();
                Thread.Sleep(1000);
                Count();
                Game(ref winsUser, ref winsPC);

            }
            else
            {
                List<string> words = new List<string>
                {"камък","ножица","хартия"};
                int index = new Random().Next(0, 3);
                string random = words[index];
                randomTemp = random;
               
                Console.Write($"Ти избра:");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{pickOfUser}");
                Console.ResetColor();
                Console.Write("           ");
                Console.Write($"Аз избрах:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{random}");
                Console.ResetColor();
            }
            if (pickOfUser == "камък" && randomTemp == "ножица")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Поздравления! Ти спечели!");
                Console.ResetColor();
                winsUser++;
                Console.WriteLine($"Резултат {winsUser}:{winsPC}");
                Console.WriteLine("Реванш?");
                Console.WriteLine("да или не?");
                PlayAgain(ref winsUser, ref winsPC);
            }
            else if (pickOfUser == "камък" && randomTemp == "хартия")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Съжалявам, ти загуби!");
                Console.ResetColor();
                winsPC++;
                Console.WriteLine($"Резултат {winsUser}:{winsPC}");
                Console.WriteLine("Реванш?");
                Console.WriteLine("да или не?");
                PlayAgain(ref winsUser, ref winsPC);
            }
            else if (pickOfUser == "камък" && randomTemp == "камък")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ха, равни!");
                Console.ResetColor();
                Console.WriteLine("Отново?");
                Console.WriteLine("да или не?");
                PlayAgain(ref winsUser, ref winsPC);
            }
            else if (pickOfUser == "ножица" && randomTemp == "камък")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Съжалявам, ти загуби!");
                Console.ResetColor();
                winsPC++;
                Console.WriteLine($"Резултат {winsUser}:{winsPC}");
                Console.WriteLine("Реванш?");
                Console.WriteLine("да или не?");
                PlayAgain(ref winsUser, ref winsPC);
            }
            else if (pickOfUser == "ножица" && randomTemp == "хартия")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Поздравления! Ти спечели!");
                Console.ResetColor();
                winsUser++;
                Console.WriteLine($"Резултат {winsUser}:{winsPC}");
                Console.WriteLine("Реванш?");
                Console.WriteLine("да или не?");
                PlayAgain(ref winsUser, ref winsPC);
            }
            else if (pickOfUser == "ножица" && randomTemp == "ножица")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ха, равни!");
                Console.ResetColor();
                Console.WriteLine("Отново?");
                Console.WriteLine("да или не?");
                PlayAgain(ref winsUser, ref winsPC);
            }
            else if (pickOfUser == "хартия" && randomTemp == "камък")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Поздравления! Ти спечели!");
                Console.ResetColor();
                winsUser++;
                Console.WriteLine($"Резултат {winsUser}:{winsPC}");
                Console.WriteLine("Реванш?");
                Console.WriteLine("да или не?");
                PlayAgain(ref winsUser, ref winsPC);
            }
            else if (pickOfUser == "хартия" && randomTemp == "ножица")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Съжалявам, ти загуби!");
                Console.ResetColor();
                winsPC++;
                Console.WriteLine($"Резултат {winsUser}:{winsPC}");
                Console.WriteLine("Реванш?");
                Console.WriteLine("да или не?");
                PlayAgain(ref winsUser, ref winsPC);
            }
            else if (pickOfUser == "хартия" && randomTemp == "хартия")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Ха, равни!");
                Console.ResetColor();
                Console.WriteLine("Отново?");
                Console.WriteLine("да или не?");
                PlayAgain(ref winsUser, ref winsPC);
            }
        }
        static void PlayAgain(ref int winsUser,ref int winsPC)
        {
            string answear = Console.ReadLine();
            if (answear == "да")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Страхотно! Да играем отново :)");
                Console.ResetColor();
                Count();
                Game(ref winsUser,ref winsPC);
            }
            else if (answear == "не")
            {
                if (winsUser>winsPC)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Другият път няма да имаш толкова късмет да знаеш!");
                    Console.ResetColor();
                    Thread.Sleep(8000);
                    Environment.Exit(0);
                }
                else if (winsUser<winsPC)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ха, аз печеля! Пожелавам ти повече късмет другият път!");
                    Console.ResetColor();
                    Thread.Sleep(8000);
                    Environment.Exit(0);
                }
                else if (winsUser==winsPC)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Равни! Не успяхме да отлъчим победител!");
                    Console.WriteLine("Нищо, другият път :)");
                    Console.ResetColor();
                    Thread.Sleep(8000);
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Моля отговорете с да или не!");
                Console.ResetColor();
                PlayAgain(ref winsUser,ref winsPC);
            }
        }
    }
}


