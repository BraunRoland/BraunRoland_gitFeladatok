using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
	internal class Program
	{

		static void F01(int[] tomb)
		{
			Random rnd = new Random();
			for (int i = 0; i < tomb.Length; i++)
			{
				int szam = rnd.Next(1, 51);
				Console.Write(tomb[i] + " + " + szam + " = ");
				tomb[i] += szam;
				Console.WriteLine(tomb[i]);
			};
		}

		static void F02(int[] tomb)
		{
			int szamlalo = 0;
			for (int i = 0; i < tomb.Length; i++)
			{
				if (tomb[i] % 2 == 0)
				{
					szamlalo++;
				}
			}
			Console.WriteLine($"ennyi páros szám van a tömbben: {szamlalo} ");
		}

		static double F03(int[] tomb)
		{
			double atlag = 0;
			for (int i = 0; i < tomb.Length; i++)
			{
				atlag += tomb[i];	
			}
			atlag = atlag / tomb.Length;
			return atlag;
		}

		static int[] F04(int[] tomb)
		{
			int[] paratlanok = new int[10];
			for (int i = 0; i < tomb.Length; i++)
			{
				if (tomb[i]%2==0)
				{
					paratlanok[i] = tomb[i]+1;
				}
				else
				{
					paratlanok[i] = tomb[i];
				}
			}
			return paratlanok;
		}

		static void Main(string[] args)
		{
			int[] tomb = {2, 12, 56};
			F01(tomb); 
			F02(tomb);
			Console.WriteLine($"Átlag: {F03(tomb)}");
			Console.ReadLine();
		}
	}
}
