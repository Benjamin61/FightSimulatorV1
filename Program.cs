using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightsimV1
{
	class Program
	{
		static void Main(string[] args)
		{
			

			Fighter A = new Fighter();
			Fighter B = new Fighter();
			Console.Write("Ge ett namn till spelare A:");
			string Anamn = A.NameDecide();
			A.SetHp();
			bool Aalive = A.IsAlive();
			Console.Write("Namnge spelare B:");
			string Bnamn = B.NameDecide();
			B.SetHp();
			bool Balive = B.IsAlive();
			Console.ReadKey();
			while (Balive == true && Aalive == true) 
			{
				int attackA = A.Attack();
				B.Hurt(attackA);
				Console.WriteLine(Anamn + " Gjorde " + attackA + " Skada");
				B.GetHp();
				Balive = B.IsAlive();
				Console.ReadKey();
				int attackB = B.Attack();
				Console.WriteLine(Bnamn + " Gjorde " + attackB + " Skada");
				A.Hurt(attackB);
				A.GetHp();
				Aalive = A.IsAlive();
				Console.ReadKey();
			}

			if (Aalive == true && Balive == false)
			{
				Console.WriteLine(Anamn + " vann duellen!");

			}
			else if (Aalive == false && Balive == true)
			{
				Console.WriteLine(Bnamn + " vann duellen!");
			}
			else { Console.WriteLine("oavgjort!"); }

			Console.ReadKey();

		}

	}
}
