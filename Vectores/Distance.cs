using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace Vectores
{
	class Program
	{
		public static void Main()
		{
			int x1, y1, x2, y2;
			double Distance;
			Console.WriteLine("Ingresar coordenada del Punto 1");
			x1 = int.Parse(Console.ReadLine());
			y1 = int.Parse(Console.ReadLine());
			Console.WriteLine("Coordenada: ({0},{1})", x1, y1);

			Console.WriteLine("Ingresar coordenada del Punto 2");
			x2 = int.Parse(Console.ReadLine());
			y2 = int.Parse(Console.ReadLine());
			Console.WriteLine("Coordenada: ({0},{1})", x2, y2);

			Distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
			Console.WriteLine("La distancia entre los dos puntos es: {0}", Distance);

		}

	}
}



