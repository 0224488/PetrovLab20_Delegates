using System;

namespace PetrovLab20_Delegates
{
	class Program
	{
		// В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
		// метод получает входным параметром переменную типа double;
		// метод возвращает значение типа double, которое является результатом вычисления.
		// Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
		// длину окружности по формуле D = 2 * π * R;
		// площадь круга по формуле S = π* R²;
		// объем шара.Формула V = 4 / 3 * π * R³.
		// Методы должны быть объявлены как статические.

		static void Main(string[] args)
		{
			Console.WriteLine("Введите радиус окружности");
			double radius1 = double.Parse(Console.ReadLine());

			Operation operation = CirlceLength; // делегат указывает на метод CirlceLength
			double length = operation(radius1);   // эквивалентно CirlceLength(radius1)
			Console.WriteLine($"длина окружности с радиусом {radius1} равна {length:f2}");

			operation = CircleSquare;	// делегат указывает на метод CircleSquare
			double square = operation(radius1);
			Console.WriteLine($"площадь круга с радиусом {radius1} равна {square:f2}");

			operation = SphereVolume;   // делегат указывает на метод CircleSquare
			double volume = operation(radius1);
			Console.WriteLine($"объем шара с радиусом {radius1} равен {volume:f2}");

			Console.ReadKey();
		}

		delegate double Operation(double value);

		public static double CirlceLength(double radius) => 2 * Math.PI * radius;
		
		public static double CircleSquare(double radius) => Math.PI * radius * radius;

		public static double SphereVolume(double radius) => (4 / 3.0) * Math.PI * Math.Pow(radius, 3);
	}
}
