using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FightsimV1
{
	class Fighter
	{
		public string name;
		private int hp;
		public void SetHp()
		{
			Random generator = new Random();
			hp = generator.Next(20, 41);
		}


		//List<string> FighterName = new List<string>();//
		public void NameDecide()
		{
			
			name = Console.ReadLine();
			Console.WriteLine("Du namngav spelaren: [" + name + "]" );

			//Console.WriteLine("Välj ett namn på spelare A");
			//FighterName.Add(Console.ReadLine());
			/*string spelareA = FighterName[0];

			Console.WriteLine("Namnet på spelare A: " + FighterName[0]);


			Console.WriteLine("Välj ett namn på spelare B");
			FighterName.Add(Console.ReadLine());
			string spelareB = FighterName[1];
			Console.WriteLine("Namnet på spelare B: " + FighterName[1]);

			Console.ReadKey();
			Console.Clear();
			Console.WriteLine(spelareA + " VS " + spelareB);
			Console.ReadKey();*/

			//Console.WriteLine("3 2 1 FIGHT!!!!!!");//

		}

		public void Attack()
		{
			Random generator = new Random();
			int dmg = generator.Next(2, 7);

		}

		public void Hurt(int Dmg)
		{
			hp = hp - Dmg;
		}

		public bool IsAlive()
		{
			bool enoughHP = false;

			if (hp > 1)
			{
				enoughHP = true;
			}




			return enoughHP;
			
		}

	}
}
