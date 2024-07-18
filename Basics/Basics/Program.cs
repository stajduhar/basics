using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Schema;

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

            //            Random random = new Random();
            //
            //            bool playAgain = true;
            //            int min = 1;
            //            int max = 100;
            //            int guess;
            //            int number;
            //            int guesses;
            //            string response;
            //
            //            while (playAgain)
            //            {
            //                guess = 0;
            //                guesses = 0;
            //                response = "";
            //                number = random.Next(min, max + 1); // max + 1 = 101 ali će generirati random broj od 1 do 100 ( neće generairti 101 )
            //
            //                while (guess != number)
            //                {
            //                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
            //                    guess = Convert.ToInt32(Console.ReadLine());
            //                    Console.WriteLine("Guess: " + guess);
            //
            //                    if (guess > number)
            //                    {
            //                        Console.WriteLine(guess + " is to high!");
            //                    }
            //                    else if (guess < number)
            //                    {
            //                        Console.WriteLine(guess + " is to low!");
            //                    }
            //                    guesses++;
            //                }
            //                Console.WriteLine("Number: " + number);
            //                Console.WriteLine("YOU WIN!");
            //                Console.WriteLine("Guesses: " + guesses);
            //
            //                Console.WriteLine("Would you like to play again (Y/N): ");
            //                response = Console.ReadLine();
            //                response = response.ToUpper();
            //
            //                if (response == "Y")
            //                {
            //                    playAgain = true;
            //                }
            //                else // problem sa ovim dijelom koda što ako napišem bilo šta umjeso Y onda će playAgain biti false ( ne moram napisati N)
            //                {
            //                    playAgain = false;
            //                }
            //            }
            //
            //            Console.WriteLine("Thanks for playing! ... I guess");
            //


            // rock-paper-scissors game \\


            //            Random random = new Random();
            //            bool playAgain = true;
            //            String player;
            //            String computer;
            //            String answer;
            //
            //
            //            while (playAgain)
            //            {
            //                player = "";
            //                computer = "";
            //                answer = "";
            //
            //                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            //                {
            //                    Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
            //                    player = Console.ReadLine();
            //                    player = player.ToUpper();
            //                }
            //
            //                switch (random.Next(1, 4))
            //                {
            //                    case 1:
            //                        computer = "ROCK";
            //                        break;
            //                    case 2:
            //                        computer = "PAPER";
            //                        break;
            //                    case 3:
            //                        computer = "SCISSORS";
            //                        break;
            //                }
            //
            //                Console.WriteLine("Player" + player);
            //                Console.WriteLine("Computer" + computer);
            //
            //                switch (player)
            //                {
            //                    case "ROCK":
            //                        if (computer == "ROCK")
            //                        {
            //                            Console.WriteLine("It's a draw");
            //                        }
            //                        else if (computer == "PAPER")
            //                        {
            //                            Console.WriteLine("You lose!");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("You win!");
            //                        }
            //                        break;
            //                    case "PAPER":
            //                        if (computer == "ROCK")
            //                        {
            //                            Console.WriteLine("You win!");
            //                        }
            //                        else if (computer == "PAPER")
            //                        {
            //                            Console.WriteLine("It's a draw!");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("You lose!");
            //                        }
            //                        break;
            //                    case "SCISSORS":
            //                        if (computer == "ROCK")
            //                        {
            //                            Console.WriteLine("You lose!");
            //                        }
            //                        else if (computer == "PAPER")
            //                        {
            //                            Console.WriteLine("You win!");
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("Its a draw!");
            //                        }
            //                        break;
            //                }
            //                Console.WriteLine("Would you like to play again (Y/N): ");
            //                answer = Console.ReadLine();
            //                answer = answer.ToUpper();
            //
            //                if (answer == "Y")
            //                {
            //                    playAgain = true;
            //                }
            //                else
            //                {
            //                    playAgain = false; // problem sa ovim kodom --> ako napišem bilo šta osim Y varijabla playAgain će biti false
            //                }
            //            }
            //            Console.WriteLine("Thanks for playing!");


            // calculator program \\


            //            do
            //            {
            //                double num1 = 0;
            //                double num2 = 0;
            //                double result = 0;
            //
            //                Console.WriteLine("------------------");
            //                Console.WriteLine("Calculator Program");
            //                Console.WriteLine("------------------");
            //
            //                Console.Write("Enter number 1: ");
            //                num1 = Convert.ToDouble(Console.ReadLine()); // users input is allways a string thats why we have to convert to double
            //
            //                Console.Write("Enter number 2: ");
            //                num2 = Convert.ToDouble(Console.ReadLine());
            //
            //                Console.WriteLine("Enter an option: ");
            //                Console.WriteLine("\t+ : Add");
            //                Console.WriteLine("\t- : Subtract");
            //                Console.WriteLine("\t* : Multiply");
            //                Console.WriteLine("\t/ : Divide");
            //
            //                Console.Write("Enter an option: ");
            //
            //
            //                switch (Console.ReadLine())
            //                {
            //                    case "+":
            //                        result = num1 + num2;
            //                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            //                        break;
            //                    case "-":
            //                        result = num1 - num2;
            //                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            //                        break;
            //                    case "*":
            //                        result = num1 * num2;
            //                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            //                        break;
            //                    case "/":
            //                        result = num1 / num2;
            //                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            //                        break;
            //                    default:
            //                        Console.WriteLine("That was not a valid option");
            //                        break;
            //                }
            //                Console.WriteLine("Would you like to continue? (Y = Yes, N = No): ");
            //            } while (Console.ReadLine().ToUpper() == "Y"); // problem sa ovim kodom --> ako napišem bilo šta osim Y varijabla program će se opet izvršavati ne moram napisati isključivo N
            //
            //            Console.WriteLine("Bye!");


            // arrays \\

            // Arrays have fixed size

            //            String[] cars = new string[4]; 
            //
            //            // string[] cars = { "BMW", "Mustang", "Corvette"};
            //
            //            cars[0] = "Tesla";
            //            cars[1] = "Mustang";
            //            cars[2] = "Corvette";
            //
            //            for (int i = 0; i < cars.Length; i++) // ovaj if statement je napisan kako se nebi pisao Console.WriteLine 3 puta
            //            {
            //                Console.WriteLine(cars[i]);
            //            }

            // foreach loop \\

            //            String[] cars = { "BMW", "Mustang", "Corvette" };
            //
            //
            //            foreach(String car in cars)
            //                {
            //                Console.WriteLine(car);
            //            }


            // methods \\

            //          String name = "Test";
            //          int age = 21;
            //
            //          singHappyBirthday(name, age); //  !!KADA POVEZUJEMO!!
            //
            //
            //        }
            //        static void singHappyBirthday(String ime, int godine) // !!KADA POVEZUJEMO!! bitan je data type i poredak, ali se varijable ne moraju zvati isto
            //        {
            //            Console.WriteLine("Happy birthday to you!");
            //            Console.WriteLine("Happy birthday to you!");
            //            Console.WriteLine("Happy birthday dear " + ime);
            //            Console.WriteLine("You are " + godine + " Years old!");
            //            Console.WriteLine("Happy birthday to you!");
            //            Console.WriteLine();


            // return keyword \\

            //            double x;
            //            double y;
            //            double result;
            //
            //            Console.WriteLine("Enter in number 1: ");
            //            x = Convert.ToDouble(Console.ReadLine());
            //
            //            Console.WriteLine("Enter in number 2: ");
            //            y = Convert.ToDouble(Console.ReadLine());
            //
            //            result = Multiply(x, y);
            //
            //            Console.WriteLine(result);
            //
            //          }
            //        static double Multiply(double x, double y)
            //        {
            //            return x * y;
            //        }

            // method overloading \\

            // name + parametas = signature

            //            double total;
            //
            //            total = Multiply(2.421, 3);
            //
            //            Console.WriteLine(total);
            //
            //
            //
            //
            //        }
            //
            //        static double Multiply(double a, double b)
            //        {
            //            return a * b; 
            //        }
            //        static double Multiply(double a, double b, double c)
            //        {
            //            return a * b * c;
            //        }
            //
            //        static double Multiply(int a, double b)
            //        {
            //            return a - b;
            //        }

            // params keyword \\

            //    // umjesto da koristimo method overloading sa jako puno metoda, možemo koristiti params keyword ( mora biti single dimensional array )


            //            double total = CheckOut(3.99, 5.75, 15, 1.00, 10.25);
            //
            //            Console.WriteLine(total);
            //
            //        }
            //
            //        static double CheckOut(params double[] prices)
            //        {
            //
            //            double total = 0;
            //
            //            foreach (double price in prices)
            //            {
            //
            //                total += price;
            //
            //            }
            //
            //            return total;


            // exception handling \\

            //            double x;
            //            double y;
            //            double result;
            //
            //            // try = stavlja se oko koda za kojeg mislimo da bi mogao puknuti
            //            // catch = uhvati exception i handle-a ga
            //            // finally = uvijek se executa ne vezano jel se javio exception ili nije
            //
            //
            //            try
            //            {
            //                Console.WriteLine("Enter number 1: ");
            //                x = Convert.ToInt32(Console.ReadLine());
            //
            //                Console.WriteLine("Enter number 2: ");
            //                y = Convert.ToInt32(Console.ReadLine());
            //
            //                result = x / y;
            //
            //                Console.WriteLine("result: " + result);
            //            }
            //            catch (FormatException e)
            //            {
            //                Console.WriteLine("Enter ONLY numbers PLEASE!");
            //            }
            //            catch (DivideByZeroException e)
            //            {
            //                Console.WriteLine("You can't divide by zero!");
            //            }
            //            catch (Exception e)
            //            {
            //                Console.WriteLine("Something went wrong!");
            //            }
            //            finally
            //            {
            //                Console.WriteLine("Thanks for visiting!");
            //            }




            // conditional operator \\

            //            // conditinal operator = učini nešto u slučaju da je condition true, uprotivnom učini ovo drugo
            //
            //            // (condition) ? x : y
            //
            //
            //            double temperature = 20;
            //            String message;
            //
            //            message = (temperature >= 15) ? "It's warm outside!" : "It's cold outside!";
            //
            //            Console.WriteLine(message);




            // string interpolation \\

            //            // dodaje varijable u string, potrebno je dodati $ prije znaka ", varijabla se upisuje u {}
            //
            //            string firstName = "test";
            //            string lastName = "toast";
            //            int age = 25;
            //
            //
            //            Console.WriteLine($"Hello {firstName,10} {lastName}."); // 10 obavlja istu funkciju kao da smo ukucali 10 razmaka sa spaceom prije varijable age
            //            Console.WriteLine($"You are {age,-10} years old."); // -10 obavlja istu funkciju kao da smo ukucali 10 razmaka sa spaceom nakon varijable age



            // multidimensional arrays \\


            //            string[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
            //                                     { "Corvette", "Camaro", "Silverado" },
            //                                     { "Corolla", "Camry", "Rav4" } };
            //
            //            parkingLot[0, 2] = "Fusion";
            //
            //            parkingLot[2, 0] = "Tacoma";
            //
            //            /*
            //            foreach (string car in parkingLot)
            //            {
            //                Console.WriteLine(car);
            //            }
            //            */

            //            for (int i = 0; i < parkingLot.GetLength(0); i++) // Get.Length(0)  --> ova 0 predstavlja prvu dimenziju --> npr: kod X Y koordinata 0 predstavlja Y
            //                {
            //                for (int j = 0; j < parkingLot.GetLength(1); j++) // Get.Length(1)  --> ova 1 predstavlja drugu dimenziju --> npr: kod X Y koordinata 1 predstavlja X
            //                {
            //                    Console.Write(parkingLot[i, j] + " ");
            //                }
            //                Console.WriteLine();
            //            }


            // classes \\

            // class = A bundle of relted code.
            //         Can be used as a blueprint to create objects (OOP)

            //            Math.Round(3.14);
            //            Math.Abs(-3.14);
            //            Math.Pow(2, 3); // pre definirana class-a
            //
            //            Messages.Hello(); // mi smo definirali ovu class-u
            //            Messages.Waiting();
            //            Messages.Bye();



            // object \\

            // object = An instance of a class
            //          A class can be used as a blueprint to create objects (OOP)
            //          objects can have fields & methods (characteristics & actions)
            //          fields ( what an objects have ), methods ( what an object can do )


            // constructors \\

            // constructor = A special method in a class
            //               Same name as the class name
            //               Can be used to assign arguments to fields when creating an object


            //           Car car1 = new Car("Ford", "Mustang", 2022, "red"); // kreirana je Car.cs klasa izvan Program.cs
            //           Car car2 = new Car("Chevy", "Corvette", 2021, "blue");
            //
            //           car1.Drive(); // Drive je invoakain iz Car.cs
            //           car2.Drive(); // Drive je invoakain iz Car.cs
            //
            //           Human human1 = new Human("test", 43);
            //           Human human2 = new Human("toast", 25);
            //
            //
            //           human1.Eat();
            //           human1.Sleep();
            //
            //           human2.Eat();
            //           human2.Sleep();
            //
            //
            //       }
            //   }
            //
            //   class Human
            //   {
            //       public string name; // field
            //       public int age;     // field
            //
            //       public Human(string name, int age)  // constructor
            //       {
            //           this.name = name; // prvi name je filed name --> .name // drugi name je ime parametra iz constructora --> name (string name)
            //           this.age = age;
            //       }
            //
            //       public void Eat() // method
            //       {
            //           Console.WriteLine(name + " is eating");
            //       }
            //
            //       public void Sleep() // method
            //       {
            //           Console.WriteLine(name + " is sleeping");
            //       }


            //            // Static \\
            //
            //            // static = modifier that can be applied to field, method or class it self
            //            //          anything thats declared static now belongs to the class
            //            //          and no one object has ownership of it
            //
            //            Tar car1 = new Tar("Mustang"); // ne može se kreirati objekt ako je klasa static ( ovo se veže uz Math primjer )
            //            Tar car2 = new Tar("Corvette");
            //
            //            // Console.WriteLine(car1.numberOfCars); // bez static ovo radi i ispisati će 1
            //            Console.WriteLine(Tar.numberOfCars); // zbog static numberOfCars pripada klasi Tar
            //
            //            Tar.StartRace();
            //
            //            // Math math1 = new Math(); // ovo se veže na car1 komentar
            //            // math1.Round();           // Npr nebi smo kreirali objekt math1 da bi smo Roundali broj
            //                                        // nego direktno pokrenemo round is static klase Math --> Math.Round();
            //
            //        } 
            //    }
            //
            //    class Tar // ( static može biti definiran u klasi )
            //    {
            //        string model;
            //        public static int numberOfCars; // ovdje je definiran static ( static može biti definiran u fieldu )
            //
            //        public Tar(string model) 
            //        {
            //            this.model = model;
            //            numberOfCars++;
            //        }
            //
            //        public static void StartRace() // ( static može biti definiran u metodi )
            //        {
            //            Console.WriteLine("The race has begun!");
            //        }


            // Overloaded constructors \\

            // technique to create multiple constructors,
            // with a different set of parameters.
            // name + parameters = signature

            // unutar iste klase se ne mogu nalaziti 2 constructora sa istim parametrima iz fielda ( nebitno jel se različito zovu)



            //            Pizza pizza = new Pizza("stuffed crust", "red sauce", "mozzarella", "pepperoni"); // we need all 4 (bread, sauce, cheese, topping) to construct a pizza object
            //
            //
            //
            //        }
            //    }
            //
            //    class Pizza
            //    {
            //        string bread;
            //        string sauce;
            //        string cheese;
            //        string topping;
            //
            //        public Pizza(string bread, string sauce, string cheese, string topping)
            //        {
            //            this.bread = bread;
            //            this.sauce = sauce;
            //            this.cheese = cheese;
            //            this.topping = topping;
            //        }
            //
            //        public Pizza(string bread, string sauce, string cheese)
            //        {
            //            this.bread = bread;
            //            this.sauce = sauce;
            //            this.cheese = cheese;
            //        }
            //
            //        public Pizza(string bread, string sauce)
            //        {
            //            this.bread = bread;
            //            this.sauce = sauce;
            //        }
            //
            //        public Pizza(string bread)
            //        {
            //            this.bread = bread;
            //        }

            // Inheritance \\

            // inheritance = 1 or more child classes reciveing fields, methods, etc. from a common parent




            //            Tar tar = new Tar(); // već postoji klasa Car.cs pa sam ovu klasu nazvao Tar
            //            Bicycle bicycle = new Bicycle();
            //            Boat boat = new Boat();
            //            Coat coat = new Coat();
            //
            //            Console.WriteLine(tar.speed);
            //            Console.WriteLine(tar.wheels);
            //            tar.go();
            //
            //            Console.WriteLine(bicycle.speed);
            //            Console.WriteLine(bicycle.wheels);
            //            bicycle.go();
            //
            //            Console.WriteLine(boat.speed);
            //            Console.WriteLine(boat.wheels);
            //            boat.go();
            //
            //            Console.WriteLine(coat.speed);  // Testirano jel može child klasa postati i parent klasa
            //            Console.WriteLine(coat.wheels); // ovim primjerom vidim da Bicycle može postati parent klasa
            //            Console.WriteLine(coat.Bheels); // Bicycle = child klasa --> (Vehicle)
            //            coat.go();                      // Bicycle = parent klasa --> (Coat)
            //        }
            //
            //    }
            //
            //    class Vehicle 
            //    {
            //        public int speed = 0;
            //
            //        public void go()
            //        {
            //            Console.WriteLine("This vehicle is moving!");
            //        }
            //    }
            //
            //        class Tar : Vehicle // Car is child class, Vehicale is parent class
            //    {
            //        public int wheels = 4;
            //    }
            //
            //        class Bicycle : Vehicle // Car is child class, Vehicale is parent class
            //    {
            //        public int wheels = 2;
            //
            //    }
            //
            //    class Boat : Vehicle
            //    {
            //        public int wheels = 0;
            //    }
            //
            //    class Coat : Bicycle // child klasa može postati i parent klasa
            //    {                    // npr Bicycle je child klasa od Vehicle + također je parent klasa od Coat
            //        public int Bheels = 3;
            //    }


            // Abstract classes \\

            //            Person person = new Person();
            //            person.Name = "John";
            //            person.Age = 30;
            //            person.Introduce();
            //
            //
            //        }
            //
            //    }
            //
            //    public class Person
            //    {
            //        // Fields
            //        public string Name;
            //        public int Age;
            //
            //        // Method
            //        public void Introduce()
            //        {
            //            Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
            //        }
            //    }

            // Abstract classes \\

            //            Tar tar = new Tar();
            //            Bicycle bicycle = new Bicycle();
            //            Boat boat = new Boat();
            //           // Vehicle vehicle = new Vehicle(); /* ovaj objekt ne mogu kreirati jer je Vehicle klasa abstraktna klasa */
            //
            //
            //        }
            //
            //    }
            //
            //    abstract class Vehicle
            //    {
            //        public int speed = 0;
            //
            //        public void go()
            //        {
            //            Console.WriteLine("This vehicle is moving!");
            //        }
            //    }
            //    class Tar : Vehicle
            //    {
            //        public int wheels = 4;
            //        int maxSpeed = 500;
            //    }
            //    class Bicycle : Vehicle
            //    {
            //        public int wheels = 2;
            //        int maxSpeed = 50;
            //    }
            //    class Boat : Vehicle
            //    {
            //        public int wheels = 0;
            //        int maxSpeed = 100;
            //    }


            // Array of objects \\


            //            Tar[] garage = new Tar[3];
            //            
            //            Tar car1 = new Tar("Mustang");
            //            Tar car2 = new Tar("Corvette");
            //            Tar car3 = new Tar("Lambo");
            //            
            //            garage[0] = car1;
            //            garage[1] = car2;
            //            garage[2] = car3;
            //
            //
            //            //            Tar[] garage = { new Tar("Mustang"), new Tar("Corvette"), new Tar("Lambo") }; // ovo je način za složiti array sa anonymous objektima
            //            
            //            
            //                        foreach (Tar bluh in garage)
            //                        {
            //                            Console.WriteLine(bluh.model);
            //                        }
            //            
            //                    }
            //                }
            //            
            //                class Tar
            //                {
            //                    public string model;
            //            
            //                    public Tar(string model)
            //                    {
            //                        this.model = model;
            //                    }
            //                }


            // objects as arguments \\




            //            Tar car1 = new Tar("Corvette", "red");
            //
            //            Tar ar = Copy(car1);
            //
            //            /* ChangeColor(car1, "silver"); */
            //
            //            Console.WriteLine(ar.color + " " + ar.model);
            //
            //            //  Console.WriteLine(car1.color + " " + car1.model);
            //
            //
            //        }
            //        // /* */ to pass an object as an argument you have to type data type of the object ( Tar ), followed by the name of the parameter ( in this case its called car) --> ( name in this case doesn't matter, not sure if it matters in any other cases )
            //        // /* */ and then when you invode the method ( ChangeColor ) you have to pass in the name of the object ( car1 )
            //        public static void ChangeColor(Tar car, String color)
            //        {
            //            car.color = color;
            //        }
            //
            //
            //        public static Tar Copy(Tar ar)
            //        {
            //            return new Tar(ar.model, ar.color); // ovdje je dodan objekt kao argument na način da ar 
            //        }
            //
            //    }
            //    public class Tar
            //    {
            //
            //        public String model;
            //        public String color;
            //
            //        public Tar(string model, string color)
            //        {
            //            this.model = model;
            //            this.color = color;
            //        }
            //
            //    }



            // ToString method \\


            //            Tar car = new Tar("Chevy", "Corvette", 2022, "blue");
            //
            //            Console.WriteLine(car);
            //
            //        } 
            //        
            //
            //    }
            //
            //    class  Tar
            //    {
            //        string make;
            //        string model;
            //        int year;
            //        string color;
            //
            //        public Tar(String make, String model, int year, String color)
            //        {
            //            this.make = make;
            //            this.model = model;
            //            this.year = year;
            //            this.color = color;
            //        }
            //        public override string ToString()
            //        {
            //            return "This is a " + make + " " + model;
            //        }
            //
            //
            //    }

            // Polymorphism \\ --> To "have many forms"
            //                     Objects can be identified by more than one type
            //                     Example: Human can be a Son, a Doctor, a husband

    //            Tar car = new Tar();
    //            Bycicle bycicle = new Bycicle();
    //            Boat boat = new Boat();
    //
    //            Vehicle[] vehicles = { car, bycicle, boat };
    //
    //            int[] zum = { 12, 5, 19 };
    //
    //            foreach (double a in zum) // on je sada odradio konvertanje iz int u double
    //            {
    //                Console.WriteLine("test");
    //            }
    //
    //            foreach (Vehicle vehicle in vehicles)
    //            {
    //                vehicle.Go();
    //            }
    //
    //        }
    //    }
    //    class Vehicle
    //    {
    //        public virtual void Go()
    //        {
    //        
    //        }
    //    }
    //
    //    class Tar : Vehicle
    //    {
    //        public override void Go()
    //        {
    //            Console.WriteLine("The tar is moving"); 
    //        }
    //    }
    //    class Bycicle : Vehicle
    //    {
    //        public override void Go()
    //        {
    //            Console.WriteLine("The bycicle is moving");
    //        }
    //    }
    //    class Boat : Vehicle
    //    {
    //        public override void Go()
    //        {
    //            Console.WriteLine("The boat is moving");
    //        }
    //    }

}



