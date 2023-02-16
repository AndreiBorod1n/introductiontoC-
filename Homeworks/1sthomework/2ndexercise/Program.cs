// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
        Console.WriteLine("Введите первое число: ");
        int numberA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int numberB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите третье число: ");
        int numberC = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Наибольшее число равно:");
        int maximum = Convert.ToInt32("0");
        if (numberA > numberB)
        {
            maximum = numberA;
        }
        else
        {
            maximum = numberB;
        }
            
        if (maximum > numberC)
            {
                Console.WriteLine("Наиболее число равно:");
                Console.WriteLine(maximum);
            }
        else
            {
                maximum = numberC;
                Console.WriteLine("Наиболее число равно:");
                Console.WriteLine(maximum);
            }