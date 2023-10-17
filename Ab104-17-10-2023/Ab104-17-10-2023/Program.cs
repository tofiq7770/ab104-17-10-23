using Ab104_17_10_2023;

public class Program
{
    static Car car;

    static void Main(string[] args)
    {
        Console.WriteLine("Başlayan kimi");
        Console.Write("Bakda ne qeder benzin var? ");
        double initialFuel = double.Parse(Console.ReadLine());
        Console.Write("Mashinin bakinin hecmi ne qederdi? ");
        double tankCapacity = double.Parse(Console.ReadLine());
        Console.Write("Mashinin 100km-e ne qeder benzin istifade edir? ");
        double fuelConsumption = double.Parse(Console.ReadLine());

        car = new Car(initialFuel, tankCapacity, fuelConsumption);

        while (true)
        {
            Console.WriteLine("\n1. Sür");
            Console.WriteLine("2. Zapravkaya gir");
            Console.WriteLine("3. Benzini göstər");
            Console.WriteLine("4. Getdiyimiz yolu göster");
            Console.Write("Seçim edin (1/2/3/4): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                DriveCar();
            }
            else if (choice == "2")
            {
                RefuelCar();
            }
            else if (choice == "3")
            {
                ShowFuel();
            }
            else if (choice == "4")
            {
                ShowMileage();
            }
            else
            {
                Console.WriteLine("Yanlış seçim! Düzgün seçim edin.");
            }
        }
    }

    static void DriveCar()
    {
        Console.Write("Neçe km yol gedek? ");
        double distance = double.Parse(Console.ReadLine());

        if (car.Drive(distance))
        {
            Console.WriteLine($"Gedilen yol: {car.MileAge} km");
            Console.WriteLine($"Qalan benzin: {car.Fuel} L");
        }
        else
        {
            Console.WriteLine("Bu yolu getmek mumkun deyil");
        }
    }

    static void RefuelCar()
    {
        Console.WriteLine("SOCAR-a xoş gəldiniz");
        Console.Write("Ne qeder dolduraq? (1-10 L): ");
        double amount = double.Parse(Console.ReadLine());

        if (car.Refuel(amount))
        {
            Console.WriteLine("Doldu. Benzin: " + car.Fuel + " L");
        }
        else
        {
            Console.WriteLine("Sehv daxil etmisiniz.");
        }
    }

    static void ShowFuel()
    {
        Console.WriteLine("Benzin: " + car.Fuel + " L");
    }

    static void ShowMileage()
    {
        Console.WriteLine("Getdiyimiz yol: " + car.MileAge + " km");
    }
}
