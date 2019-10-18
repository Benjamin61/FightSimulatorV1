using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FightsimV1
{
	class Fighter
	{
		public string name; //Strings för att lagra informationen som körs i metoderna
		private int hp;
		public int SetHp() //Metod som används för att genererar random hp till båda karaktärerna
		{
			Random generator = new Random(); //Random generator
			hp = generator.Next(20, 41); //Sätter in ett random nummer mellan 20 och 40 till inten hp
			return hp; //retunerar värdet från det som körs ovan
		}


		//List<string> FighterName = new List<string>();//
		public string NameDecide() //Metod för att namnge spelarna
		{
			
			name = Console.ReadLine(); // stringen name = spelarens input
			Console.WriteLine("Du namngav spelaren: [" + name + "]" );

			
			return name; //retunerar stringen
		}

		public int Attack() //Metod som avger hur mycket damage man ska göra
		{
			Random generator = new Random();
			int dmg = generator.Next(2, 7); //Skapar en int som får ett värde från generatorn mellan 2 och 6
			return dmg; //Retunerar int dmg med ett värde

		}

		public void Hurt(int dmg) //Metod som tar hp minus dmg från tidigare metoder
		{
			hp = hp - dmg; //Gör om hp till hp - dmg

			if (hp < 0) //Om man tar skada så att ens hp bli under 0 så kommer det bara displaya 0, man kan inte ha negativt hp
			{
				hp = 0;
			}
		}

		public int GetHp() //Metod som skriver ut spelarens hp
		{

			Console.WriteLine(name + " har nu " +  hp + "hp."); //Skriver ut hp man har nu

			return hp; //Retunerar hp
			
		}


		public bool IsAlive() //En bool för att kolla så att spelaren är vid liv
		{
			bool enoughHP = false; //Sätter boolen enoughHP till false som default

			if (hp >= 1) //Om spelarens hp är större eller lika med 1 så är enoughHP true
			{
				enoughHP = true;
			}




			return enoughHP; //Retunerar boolen enoughHP
			
		}

	}
}
