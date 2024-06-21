﻿using System;

namespace Basics
{
    class testing_escape_sequence
        { 
        static void Main(string[] args)
        {
            //            Console.WriteLine("Hey!");
            //            //Console.ReadKey();
            //            Console.WriteLine("Hello!");
            //            
            //            
            //            // Variables \\
            //            
            //            int x; //decleration
            //            x = 123; // initialization
            //            
            //            int y = 321; // decleration + initialization
            //            
            //            int z = x + y;
            //            
            //            
            //            
            //            
            //            
            //            
            //            Console.WriteLine(x);
            //            Console.WriteLine(y);
            //            
            //            Console.WriteLine(z);
            //            
            //            int age = 21; // int označava cijele brojeve, sa int ne možemo koristiti decimalne brojeve
            //            double height = 300.5;  // double is really just a decimal number its lika a floating point number but with more precision 
            //            bool alive = true; //true or false
            //            char symbol = '@'; // samo jedan character
            //            string name = "Bro";
            //            
            //            
            //            
            //            Console.WriteLine("Hello " + name);
            //            Console.WriteLine("Your age is " + age);
            //            Console.WriteLine("Your height is " + height + "cm");
            //            Console.WriteLine("Are you alive? " + alive);
            //            Console.WriteLine("Your symbol is: "+ symbol);
            //            
            //            
            //            string userName = symbol + name;
            //            
            //            Console.WriteLine("Your username is: " + userName);
            //            
            //            // Constants \\
            //            
            //            const double pi = 3.14159; // ako dodamo const na početku sadržaj te varijable se ne može mjenjati kasnije u kodu
            //            
            //            Console.WriteLine(pi);
            //            
            //            
            //            // Type casting \\
            //            
            //            double a = 3.14;
            //            int b = Convert.ToInt32(a); // ova komanda je uzela varijablu a i convertala ju u intiger. Pošto je convertala u intiger obrisala je .14 jer je zaokružila na manji broj
            //            
            //            int c = 123;
            //            double d = Convert.ToDouble(c) + 0.1;
            //            
            //            int e = 321;
            //            string f = Convert.ToString(e);
            //            
            //            string g = "$";
            //            char h = Convert.ToChar(g); // za char se koriste jednostruki navodnici a ne dvostruki navodnici
            //            
            //            string i = "true";
            //            bool j = Convert.ToBoolean(i);
            //            
            //            
            //            Console.WriteLine(a.GetType()); // ispiše koji je data type u pitanju npr u ovom slučaju naša varijabla je System.Double
            //            Console.WriteLine(d.GetType());
            //            Console.WriteLine(f.GetType());
            //            Console.WriteLine(h.GetType());
            //            Console.WriteLine(j.GetType());
            //
            //
            //            // User input \\
            //
            //            Console.WriteLine("What's your name?");
            //
            //            string name1 = Console.ReadLine();
            //            Console.WriteLine("Hello " + name1);
            //
            //            Console.WriteLine("What's your age?");
            //            int age1 = Convert.ToInt32(Console.ReadLine());
            //            Console.WriteLine("You are " + age1 + " years old");
            //
            //            // Arithemtic operators \\
            //
            //
            //            int friends = 7;
            //
            //            //friends = friends + 2;
            //            //friends += 2; // ovo je skračena verzija friends = friends +2;
            //            //friends++; // ovo će uvečati vrijednost varijable friends za 1, ovo može biti korisno u loopovima
            //
            //            //friends = friends - 1;
            //            //friends -= 1;
            //            //friends--
            //
            //            //friends = friends * 2; // množenje
            //            //friends *= 2;
            //
            //            //friends = friends / 2; // djeljenje
            //            //Console.WriteLine(friends);
            //
            //            int remainder = friends % 3; // modulo, koristi se za ispis ostatka npr 10 / 3 ostatak je = 1
            //
            //            Console.WriteLine(remainder);
            //
            //
            //            // Math Class \\

            //            double x = 3.14 ;
            //            double y = 5;


            //            double a = Math.Pow(x, 2); // x na kvadrat, npr ovdje bi bio rezultat 9
            //            double b = Math.Sqrt(x); // Korjenovanje X varijable, npr u ovom slučaju 1.7320508075688772
            //            Double c = Math.Abs(x); // apsolutna vrijednost broja X --> ( koliko je neki broj udaljen od nule )
            //            Double d = Math.Round(x); // zaokružuje vrijednost broja npr ako je X = 3.14, rounded number rezultat bi bio 3
            //            double e = Math.Ceiling(x) ;
            //            double f = Math.Floor(x); // if X is 3.99, result is 3
            //            double g = Math.Max(x, y); // uspoređuje 2 broja i ispisuje veći broj
            //            double h = Math.Min(x, y); // uspoređuje 2 broja i ispisuje manji broj

            //             Console.WriteLine(h);


            // Random numbers \\


            //            Random random_number = new Random();

            //            int var_num = random_number.Next(1, 7); // ispisuje random broj između 1 - 6, ne može ispisati 7

            //            int var_num = random_number.Next(1, 7) +100 ; // ispisuje random broj između 101 - 106, ne može ispisati 107

            //            double var_num = random_number.NextDouble(); // ovo bi izgeneriralo nasumični decimalni broj između 0.0 i 1.0

            //            int var_num1 = random_number.Next(1, 7); // random je dovoljno jednom definirati kao u ovom primjeru
            //            int var_num2 = random_number.Next(1, 7); // random je dovoljno jednom definirati kao u ovom primjeru
            //            int var_num3 = random_number.Next(1, 7); // random je dovoljno jednom definirati kao u ovom primjeru
            //            
            //            double var_num = random_number.NextDouble() * 3; // ovo bi izgeneriralo nasumični decimalni broj između 0.0 i 3.0
            //            
            //            Console.WriteLine(var_num1);
            //            Console.WriteLine(var_num2);
            //            Console.WriteLine(var_num3);



            // hypotenuse calculator program \\


            //            // Cilj je dobiti https://prnt.sc/oShFZ87Sno_u


            //            Console.WriteLine("Enter side A: ");
            //            double a = Convert.ToDouble(Console.ReadLine());
            //            
            //            Console.WriteLine("Enter side B: ");
            //            double b = Convert.ToDouble(Console.ReadLine());
            //            
            //            double c = Math.Sqrt((a * a) + (b * b));
            //            
            //            Console.WriteLine("The hypotenuse is: " + c);


            // string methods \\

            //                  string full_name = "Test1 Test2";
            //                  string phone_number = "123-456-7890";

            //                  full_name = full_name.ToUpper(); // ToUpper je dodao varijabli full_name da ispiše sve njegove character u upper case letters

            //                   full_name = full_name.ToLower(); // ToLower smanji sve charactere na lowercase letters

            //                   phone_number = phone_number.Replace("-","/"); // replace zamjeni sve charactere sa nečim drugim npr u ovom slučaju zamjeni sve - sa /

            //                   string userName = full_name.Insert(0, "Mr."); // Insert, inserta nešto na određeno polje, npr u ovom slučaju će insertati string Mr. na polje 0 to je početno polje, na sami početak varijable

            //                   Console.WriteLine(full_name.Length);  // izračunava koliko full_name varijabla ima charactera u sebi // ovo nije method ovo je property // property nema (); na kraju 

            //                   string first_name = full_name.Substring(0, 5); // Substring u ovom slučaju dodjeli novoj varjiabli vrijednost od prvo charactera (0) pa računajući sljedećih 5 charactera
            //                   string last_name = full_name.Substring(6, 5);  // Substring u ovom slučaju dodjeli novoj varjiabli vrijednost od prvo charactera (6) pa računajući sljedećih 5 charactera




            // If stateents \\

            //                        Console.WriteLine("Please enter your age: ");
            //                        int age = Convert.ToInt32(Console.ReadLine()); // convert to int dio se mora odraditi 
            //            
            //                        if(age > 100)
            //                        {
            //                            Console.WriteLine("You are too old to sign up!");
            //                        }
            //                        else if (age >= 18)
            //                        {
            //                            Console.WriteLine("You are now signed up!");
            //                        }
            //                        else if (age < 0)
            //                        {
            //                            Console.WriteLine("You haven't been born yet");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("You must be 18+ to sign up!");
            //                        }


            //            Console.WriteLine("Please enter your name!");
            //            string name = Console.ReadLine();
            //
            //            if (name == "") // == je operator uspoređivanja, dok je = assignment operator, npr varijabla_name = "Pero"
            //            {
            //                Console.WriteLine("You did not enter your name!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Hello " + name);
            //            }



            //            Console.WriteLine("Please enter your name: ");
            //            string name = Console.ReadLine();
            //
            //            if (name != "")
            //            {
            //                Console.WriteLine("Hello " + name);
            //            }
            //            else
            //            {
            //                Console.WriteLine("You did not enter your name!");
            //            }


            // Switches \\

            // Switch je alternativa za pisanje mnogo if statementa

            //            Console.WriteLine("What day is today?");
            //            string day = Console.ReadLine();
            //
            //            if (day == "Monday")
            //            {
            //                Console.WriteLine("It's Monday");
            //            }
            //            else if (day == "Tuesday")
            //            {
            //                Console.WriteLine("It's Tuesday");
            //            }
            //            else if (day == "Wednesday")
            //            {
            //                Console.WriteLine("It's Wednesday");
            //            }
            //            else if (day == "Thursday")
            //            {
            //                Console.WriteLine("It's Thursday");
            //            }
            //            else if (day == "Friday")
            //            {
            //                Console.WriteLine("It's Friday");
            //            }
            //            else if (day == "Saturday ")
            //            {
            //                Console.WriteLine("It's Saturday ");
            //            }
            //            else if (day == "Sunday")
            //            {
            //                Console.WriteLine("It's Sunday");
            //            }
            //            else
            //            {
            //                Console.WriteLine(day + " is not a day");


            //            Console.WriteLine("What day is today?");
            //            string day = Console.ReadLine();
            //
            //            switch (day)
            //            {
            //                case "Monday":
            //                    Console.WriteLine("it's Monday");
            //                    break;
            //                case "Tuesday":
            //                    Console.WriteLine("it's Tuesday");
            //                    break;
            //                case "Wednesday":
            //                    Console.WriteLine("it's Wednesday");
            //                    break;
            //                case "Thursday":
            //                    Console.WriteLine("it's Thursday");
            //                    break;
            //                case "Friday":
            //                    Console.WriteLine("it's Friday");
            //                    break;
            //                case "Saturday":
            //                    Console.WriteLine("it's Saturday");
            //                    break;
            //                case "Sunday":
            //                    Console.WriteLine("it's Sunday");
            //                    break;
            //                default:
            //                    Console.WriteLine(day + " is not a day!");
            //                    break;
            //            }




            // logical operators \\

            //            Console.WriteLine("What's the temperature outside: (C)");
            //            double temp = Convert.ToDouble(Console.ReadLine());
            //
            //            if (temp >= 10 && temp <= 25 ) 
            //             {
            //                Console.WriteLine("It's warm outside!");
            //             }
            //            else if (temp <= -50 || temp >= 50)
            //            {
            //                Console.WriteLine("DO NOT GO OUTSIDE!");
            //            }


            // While loops \\

            // while loop se vrti u loopu sve dok je neki statement istnit, kada više nije istinit izađe iz loopa

            //            string name = "";
            //
            //            while (name == "")
            //            {
            //                Console.WriteLine("Enter your name: ");
            //                name = Console.ReadLine();
            //            }
            //
            //            Console.WriteLine("Hello " + name);



            // for loops \\


            // for loop = repeats some code a FINITE amount of times
            /*
            for (int i = 1; i <= 10; i++) // i+=1 je isto kao i i++
            {
                Console.WriteLine(i);
            }
            */

            //            for (int i = 10; i > 0; i--)
            //            {
            //                Console.WriteLine(i);
            //            }
            //            Console.WriteLine("HAPPY NEW YEAR!");


            // nested loops \\

            // nested loops = loop inside of other loops
            //                Uses vary. Used a lot in sorting algorithms


            // Sorting algorithms --> koristi se kako bi rearrange-ali neki array npr iz ( 2, 7, 4, 1, 9, 5 ) u ( 1, 2, 4, 5, 7, 9 )

            //            Console.Write("How many rows?: ");
            //            int rows = Convert.ToInt32 (Console.ReadLine());
            //
            //            Console.Write("How many columns?: ");
            //            int columns = Convert.ToInt32(Console.ReadLine());
            //
            //
            //            Console.Write("What symbol: ");
            //            String symbol = Console.ReadLine();
            //
            //            for (int i = 0; i < rows; i++) // outer loop in charge of the rows
            //            {
            //                for (int j = 0; j < columns; j++) // inner loop in charge of the columns
            //                {
            //                    Console.Write(symbol);
            //                }
            //                Console.WriteLine();
            //            }


            // number guessing game \\

            Random random = new Random();

            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            string response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1); // max + 1 = 101 ali će generirati random broj od 1 do 100 ( neće generairti 101 )

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else // problem sa ovim dijelom koda što ako napišem bilo šta umjeso Y onda će playAgain biti false ( ne moram napisati N)
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! ... I guess");



        }
    }
}