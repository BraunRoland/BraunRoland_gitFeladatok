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
			Console.Write("Tömb elemei: ");
			for (int i = 0; i < tomb.Length; i++)
			{
				int szam = rnd.Next(1, 51);
				tomb[i] += szam;
				Console.Write(tomb[i] + ", ");
			};
			Console.WriteLine();
		}

		static int F02(int[] tomb)
		{
			int szamlalo = 0;
			for (int i = 0; i < tomb.Length; i++)
			{
				if (tomb[i] % 2 == 0)
				{
					szamlalo++;
				}
			}
			return szamlalo;
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

		static void F05(int[] tomb)
		{
			Console.WriteLine($"Ennyi páratlan szám van a tömben: {F02(tomb)}");
			Console.WriteLine($"A tömb elemeinek átlaga: {F03(tomb)}");
			Console.Write("A tömbből alkotott páratlan számok: ");
			int[] paratlanok = F04(tomb);
			foreach (int item in paratlanok)
			{
				Console.Write(item + ", ");
			};
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
			int[] szamok = new int[10];
			F01(szamok); 
			F05(szamok);
			Console.ReadLine();
		}
	}
}
