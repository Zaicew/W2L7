using System;

namespace W2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            W2L7_1();
            W2L7_2();
            W2L7_3();
            W2L7_3();
            W2L7_3();
            W2L7_4();
            W2L7_5();
            W2L7_6();
            W2L7_7();
            W2L7_8();
            W2L7_9();
            W2L7_10();
            W2L7_11();
            W2L7_12();
            W2L7_13();
        }

        //1. Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są
        //one równe czy nie.
        //Dane testowe:
        //a : 5
        //b : 5
        //Rezultat w terminalu :
        //5 i 5 są równe
        public static void W2L7_1()
        {
            Console.WriteLine("Let's compare two numbers!");
            Console.WriteLine("Enter first number...");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("Enter second number...");
            double.TryParse(Console.ReadLine(), out double b);
            if (a == b)
                Console.WriteLine($"Numbers: {a}, {b} are equal!");
            else
                Console.WriteLine($"Numbers: {a}, {b} aren't equal!");
        }

        //2. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
        //jest parzysta czy nieparzysta.
        //Dane testowe : 15
        //Rezultat w terminalu :
        //15 jest liczbą nieparzystą

        public static void W2L7_2()
        {
            Console.WriteLine("Let's check if the given number is even!");
            Console.WriteLine("Enter the number...");
            double.TryParse(Console.ReadLine(), out double a);
            if (a % 2 == 0)
                Console.WriteLine($"Number {a} is even!");
            else
                Console.WriteLine($"Number {a} isn't even!");
        }


        //3. Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba
        //jest dodatnia czy ujemna.
        //Dane testowe : 14
        //Rezultat w terminalu :
        //14 jest liczbą dodatnią
        public static void W2L7_3()
        {
            Console.WriteLine("Let's check if the given number is positive or negative!");
            Console.WriteLine("Enter the number...");
            double.TryParse(Console.ReadLine(), out double a);
            if (a > 0)
                Console.WriteLine($"Number {a} is positive!");
            else if (a == 0 )
                Console.WriteLine($"Number {a} equal 0! What can I say?! :)");            
            else
                Console.WriteLine($"Number {a} is negative!");
        }

        //4. Napisz program w C#, który sprawdzi czy podany przez użytkownika rok
        //jest rokiem przestępnym.
        //Dane testowe : 2016
        //Rezultat w terminalu :
        //2016 jest rokiem przestępnym

        public static void W2L7_4()
        {
            Console.WriteLine("Let's check if the given year is leap!");
            Console.WriteLine("Enter the year...");
            int.TryParse(Console.ReadLine(), out int a);
            if (a % 4 == 0)
                Console.WriteLine($"Year {a} is leap!");
            else
                Console.WriteLine($"Year {a} isn't leap!");
        }

        //5. Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek
        //uprawnia go do ubiegania się o stanowisko posła (21), premiera(?xD), sentarora(30),
        //prezydenta(35).
        //Dane testowe : 21
        //Rezultat w terminalu :
        //Możesz zostać posłem

        public static void W2L7_5()
        {
            Console.WriteLine("Let's see what function you can perform in Poland! Type Your age...");
            int.TryParse(Console.ReadLine(), out int a);
            if (a < 21)
                Console.WriteLine("You cannot perform any function!");
            if (a >= 21)
                Console.WriteLine("You can to be a Member of Parliament and Prime Minister (if they choose You!)");
            if (a >= 30)
                Console.WriteLine("You can to be a Senator as well!");
            if (a >= 30)
                Console.WriteLine("You can to be a President. Now You can be anyone in Polish Government!");
        }

        //6. Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu
        //wymyśloną kategorię wzrostu.
        //Dane testowe : 140
        //Rezultat w terminalu :
        //Jesteś krasnoludem

        public static void W2L7_6()
        {
            Console.WriteLine("Let's check how we can call You! Type Your height...");
            int.TryParse(Console.ReadLine(), out int a);
            if (a > 140)
                Console.WriteLine("You're a dwarf!");
            else if (a > 150)
                Console.WriteLine("You're a little higher dwarf! ;D");
            else if (a > 160)
                Console.WriteLine("You're a halfling!");
            else if (a > 170)
                Console.WriteLine("You're a dwarf + halfling!");
            else if (a > 180)
                Console.WriteLine("Now You can helping dwarfs");
            else if (a > 190)
                Console.WriteLine("You're tall! And You can still helping dwarfs! ;)");
            else if (a > 190)
                Console.WriteLine("You're giant!");
        }
        //7. Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi,
        //która jest największa
        //Dane testowe:
        //25
        //63
        //79
        //Rezultat w terminalu :
        //79 jest największa z podanych

        public static void W2L7_7()
        {
            Console.WriteLine("Let's check which of given three numbers is the largest!");
            Console.WriteLine("Type first number...");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("Type second number...");
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("Type third number...");
            double.TryParse(Console.ReadLine(), out double c);

            if (a > b && a > c)
                Console.WriteLine($"{a} is the largest!");
            else if (b > a && b > c)
                Console.WriteLine($"{b} is the largest!");
            else if (c > b && c > a)
                Console.WriteLine($"{c} is the largest!");
            else 
                Console.WriteLine($"At least two of them are equal!");
        }

        //8. Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
        //na studiach wg. Następujących kryteriów:
        //Wynik z Matury z matematyki powyżej 70
        //Wynik z fizyki powyżej 55
        //Wynik z chemii powyżej 45
        //Łączny wynik z 3 przedmiotów powyżej 180
        //Albo
        //Wynik z matematyki i jednego przedmiotu powyżej 150
        //Dane testowe:
        //Matematyka 80
        //Fizyka 71
        //Chemia 0
        //Rezultat w terminalu :
        //Kandydat dopuszczony do rekrutacji


        public static void W2L7_8()
        {
            Console.WriteLine("Let's see that You can be a student!");
            Console.WriteLine("Type the result of the matura exam in mathematics...");
            double.TryParse(Console.ReadLine(), out double mathMaturaResult);
            Console.WriteLine("Type the result of the matura exam in physics...");
            double.TryParse(Console.ReadLine(), out double physicsMaturaResult);
            Console.WriteLine("Type the result of the matura exam in chemistry...");
            double.TryParse(Console.ReadLine(), out double chemistryMaturaResult);
            if (mathMaturaResult > 70 ||
                mathMaturaResult > 55 ||
                mathMaturaResult > 45 ||
                mathMaturaResult + physicsMaturaResult + chemistryMaturaResult > 180 ||
                mathMaturaResult + physicsMaturaResult > 150 ||
                mathMaturaResult + chemistryMaturaResult > 150)
                Console.WriteLine("You can to be a student!");
            else
                Console.WriteLine("You cannot to be a student!");
        }
        //9. Napisz program, który odczyta temperaturę I zwróci nazwę jak w
        //poniższych kryteriach
        //Temp< 0 – cholernie piździ
        //Temp 0 – 10 – zimno
        //Temp 10 – 20 – chłodno
        //Temp 20 – 30 – w sam raz
        //Temp 30 – 40 – zaczyna być słabo, bo gorąco
        //Temp >= 40 – a weź wyprowadzam się na Alaskę.
        //Dane testowe : 41
        //Rezultat w terminalu :
        //a weź wyprowadzam się na Alaskę.

        public static void W2L7_9()
        {
            Console.WriteLine("How we can call current temperature? Type your's...");
            double.TryParse(Console.ReadLine(), out double currentTemperature);
            switch (currentTemperature)
            {
                case double n when (n < 0):
                    Console.WriteLine("It's cold as fuck!");
                    break;
                case double n when (n >= 0 && n < 10):
                    Console.WriteLine("It's just cold!");
                    break;
                case double n when (n >= 10 && n < 20):
                    Console.WriteLine("It's a little cold!");
                    break;
                case double n when (n >= 20 && n < 30):
                    Console.WriteLine("It's fine!");
                    break;
                case double n when (n >= 30 && n < 40):
                    Console.WriteLine("It's hot! I feel weak!");
                    break;
                case double n when (n >= 40):
                    Console.WriteLine("It's fucking hot! I will move to Alaska!");
                    break;
                default:
                    Console.WriteLine("Type only number!");
                    break;
            }
        }

        //10. Napisz program, który sprawdzi, czy z 3 podanych długości można
        //stworzyć trójkąt
        //Dane testowe : 40 55 65
        //Rezultat w terminalu :
        //Można zbudować trójkąt

        public static void W2L7_10()
        {
            Console.WriteLine("Let's check that from given three section we can build a triangle... // without Pythagorean triangle :(");
            Console.WriteLine("Type first length...");
            double.TryParse(Console.ReadLine(), out double a);
            Console.WriteLine("Type second length...");
            double.TryParse(Console.ReadLine(), out double b);
            Console.WriteLine("Type third length...");
            double.TryParse(Console.ReadLine(), out double c);
            
            if (a == b && a == c)
                Console.WriteLine($"It's possible to build a triangle from sections: {a}, {b} and {c}!");
            else if (a > b + c || b > a + c || c > a + b)
                Console.WriteLine($"It's possible to build a triangle from sections: {a}, {b} and {c}!");
            else
                Console.WriteLine($"It isn't possible to build a triangle from sections: {a}, {b} and {c}!");

        }

        //11. Napisz program, który zmieni ocenę ucznia na jej opis wg podanej tabeli:
        //Ocena Opis
        //6 Celujący
        //5 Bardzo dobry
        //4 Dobry
        //3 Dostateczny
        //2 Dopuszczający
        //1 Niedostateczny
        //Dane testowe : 3
        //Rezultat w terminalu :
        //Dostateczny

        public static void W2L7_11()
        {
            Console.WriteLine("Let's change your digit grade to sentence grade! Type Your grade...");
            int.TryParse(Console.ReadLine(), out int gradeDigit);
            string gradeSentence;
            switch (gradeDigit)
            {
                case 1:
                    gradeSentence = "Nieedostateczny";
                    break;
                case 2:
                    gradeSentence = "Dopuszczający";
                    break;
                case 3:
                    gradeSentence = "Dostateczny";
                    break;
                case 4:
                    gradeSentence = "Dobry";
                    break;
                case 5:
                    gradeSentence = "Bardzo dobry";
                    break;
                case 6:
                    gradeSentence = "Celujący";
                    break;
                default:
                    gradeSentence = "wrongGrade";
                    Console.WriteLine("Did You typed correct grade?");
                    break;
            }
            if (gradeSentence != "wrongGrade") 
                Console.WriteLine($"Digit grade: {gradeDigit}, sentence grade {gradeSentence}");
        }

        //12. Napisz program, który pobierze numer dnia tygodnia i wyświetli jego
        //nazwę
        //Dane testowe : 4
        //Rezultat w terminalu :
        //Czwartek

        public static void W2L7_12()
        {
            Console.WriteLine("Let's check which numbers are assigned to which days of the week");
            Console.WriteLine("Type Your number (1-7)...");
            int.TryParse(Console.ReadLine(), out int dayOfWeekNumber);
            //string dayOfWeekWord;
            //switch (dayOfWeekNumber)
            //{
            //    case 1:
            //        dayOfWeekWord = System.Data.day
            //        break;
            //}
            string dayOfWeekWord = dayOfWeekNumber switch
            {
                var n when (n == 1) => "Monday",
                var n when (n == 2) => "Tuesday",
                var n when (n == 3) => "Wednesday",
                var n when (n == 4) => "Thursday",
                var n when (n == 5) => "Friday",
                var n when (n == 6) => "Saturday",
                var n when (n == 7) => "Sunday",
                _ => "errorDay"
            };
            if (dayOfWeekWord == "errorDay")
                Console.WriteLine("Did You typed correct day?");
            else
            Console.WriteLine($"Name of day {dayOfWeekNumber} is {dayOfWeekWord}");

        }


        //13. Napisz program, który będzie posiadał proste menu (wg.Wzoru poniżej) I
        //będzie prostym kalkulatorem
        //Podaj pierwszą liczbę:
        //…
        //Podaj drugą liczbę:
        //…
        //Podaj numer operacji do wykonania:
        //1. Dodawanie
        //2. Odejmowanie
        //3. Mnożenie
        //4. Dzielenie
        //…
        //Twój wynik to:

        public static void W2L7_13()
        {
            Console.WriteLine("Let's calculate something!");
            Console.WriteLine("Type first number...");
            double.TryParse(Console.ReadLine(), out double var1);
            Console.WriteLine("Type second number...");
            double.TryParse(Console.ReadLine(), out double var2);
            Console.WriteLine("What You want to do? (1) add, (2) substract, (3) multiply, (4) divide...");
            int.TryParse(Console.ReadLine(), out int sign);
            switch (sign)
            {
                case 1:
                    Console.WriteLine($"Result is {var1 + var2}");
                    break;
                case 2:
                    Console.WriteLine($"Result is {var1 - var2}");
                    break;
                case 3:
                    Console.WriteLine($"Result is {var1 * var2}");
                    break;
                case 4:
                    if (var2 == 0)
                    { 
                        Console.WriteLine("Second variable equals 0! Error!"); 
                        break; 
                    }
                    Console.WriteLine($"Result is {var1 / var2}");
                    break;
                default:
                    Console.WriteLine("Something went wrong!");
                    break;
            }
        }
    }
}
