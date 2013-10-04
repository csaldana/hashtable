
using System;
using System.Collections;

namespace Practica4
{
	class Program
	{
		public static void Main (string[] args)
		{
			Directorio d = new Directorio ();
			d.capturar();
            Console.Clear();
            d.imprimir();
			d.editar();
            d.imprimir();
			d.eliminar();
			d.imprimir();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}