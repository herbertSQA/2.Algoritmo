using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimilutudDeDatos
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Operacion parte = new Operacion();
			volver:
			Console.WriteLine("1) Misma palabra, case, accent insensitive");
			Console.WriteLine("2) Misma palabras, case, accent insensitive, separators insensitive");
			Console.WriteLine("3) Mostrar datos");
			Console.WriteLine();
			Console.Write("Escribe la letra del ejercicio: ");
			string r;

			r = Convert.ToString(Console.ReadLine());

			switch (r)
			{
				case "1":
					parte.parteA();
					break;
				case "2":
					parte.parteB();
					break;
				case "3":
					parte.mostrar();
					break;
				default:
					Console.Clear();
					Console.WriteLine("Solo Los numeros 1, 2, 3, 4");
					Console.WriteLine();
					goto volver;
			}
			Console.Clear();
			goto volver;

		}

		
	}
	class Operacion
	{
		private string[] DocumentoA = new string[10];
		private string[] DocumentoB = new string[10];
		private static int contadorA;
		private static int contadorB;
		private string valor;
		private bool c = true;
		
		public void parteA(){
			Console.Clear();
			Console.Write("Inserte un nombre: ");
			valor = Console.ReadLine();
			foreach (string datos in DocumentoA){
				if (String.Compare(datos, valor, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase) == 0)
				{
					c = false;
				}
			}
			if (c){
				Console.WriteLine("Se acaba de registrar");
				Console.ReadKey();
				DocumentoA[contadorA] = valor;
				contadorA++;				
			}
			else {
				foreach (string datos in DocumentoA){
					if (String.Compare(datos, valor, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase) == 0)
					{
						Console.WriteLine(valor + " ya esta en la base de datos como: " + datos);
					}
				}
				c = true;
				Console.ReadKey();
			}
		}
		public void parteB()
		{
			Console.Clear();
			Console.Write("Inserte un nombre: ");
			valor = Console.ReadLine();
			foreach (string datos in DocumentoB){
				if (String.Compare(datos, valor, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase | CompareOptions.IgnoreSymbols) == 0)
				{
					c = false;
				}
			}
			if (c){
				Console.WriteLine("Se acaba de registrar");
				Console.ReadKey();
				DocumentoB[contadorB] = valor;
				contadorB++;
			}
			else
			{
				foreach (string datos in DocumentoB)
				{
					if (String.Compare(datos, valor, CultureInfo.CurrentCulture, CompareOptions.IgnoreNonSpace | CompareOptions.IgnoreCase | CompareOptions.IgnoreSymbols) == 0)
					{
						Console.WriteLine(valor + " ya esta en la base de datos como: " + datos);
					}
				}
				c = true;
				Console.ReadKey();
			}
		}
		public void mostrar()
		{
			Console.Clear();
			Console.WriteLine("Parte A:");
			foreach(string datos in DocumentoA){
				if (!(datos is null)){
					if (datos.Length > 0){
						Console.WriteLine(datos + " ");
						Console.WriteLine();
					}
				}
				else{
					break;
				}
			}
			Console.WriteLine();
			Console.WriteLine("Parte B:");
			foreach (string datos in DocumentoB)
			{
				if (!(datos is null))
				{
					if (datos.Length > 0)
					{
						Console.WriteLine(datos + " ");
						Console.WriteLine();
					}
				}
				else
				{
					break;
				}
			}
			Console.ReadKey();
		}
	}
}
/*
C) Articles insensitive: el, un, los, unos, la, una, las, unas, a, de, al, del, lo*/