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
			

			Fighter A = new Fighter(); //Skapar 2 fighter från classen som kallas A respektive B
			Fighter B = new Fighter();
			Console.Write("Ge ett namn till spelare A:");
			string Anamn = A.NameDecide(); //Gör en string som kallas Anamn som = Namdecide metoden för fighter A 
			A.SetHp(); //Kör metoden sethp för Fighter A
			bool Aalive = A.IsAlive(); //Skapar en bool som heter  Aalive = metoden IsAlive för A
			Console.Write("Namnge spelare B:");
			string Bnamn = B.NameDecide(); //Samma sak som ovan fast nu applicerars det på spelare B
			B.SetHp();
			bool Balive = B.IsAlive();
			Console.ReadKey();
			while (Balive == true && Aalive == true)  //En loop som körs så länge metoden IsAlive i figter.cs är true
			{
				
				int attackA = A.Attack(); //Skapar en int där information från A.Attack lagras
				B.Hurt(attackA); //Hurt metoden körs för B där attacken från tidigare förs med i en int
				Console.WriteLine(Anamn + " Gjorde " + attackA + " Skada"); //Skriver ut hur mycket dmg man gjorde
				B.GetHp(); //Skriver ut fighters B hp
				Balive = B.IsAlive();
				Console.ReadKey();
				int attackB = B.Attack();
				Console.WriteLine(Bnamn + " Gjorde " + attackB + " Skada");
				A.Hurt(attackB);
				A.GetHp();
				Aalive = A.IsAlive();
				Console.ReadKey();
				Console.Clear();
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
