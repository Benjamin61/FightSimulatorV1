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
		public int SetHp()
		{
			Random generator = new Random();
			hp = generator.Next(20, 41);
			return hp;
		}


		//List<string> FighterName = new List<string>();//
		public string NameDecide()
		{
			
			name = Console.ReadLine();
			Console.WriteLine("Du namngav spelaren: [" + name + "]" );

			
			return name;
		}

		public int Attack()
		{
			Random generator = new Random();
			int dmg = generator.Next(2, 7);
			return dmg;

		}

		public void Hurt(int dmg)
		{
			hp = hp - dmg;

			if (hp < 0)
			{
				hp = 0;
			}
		}

		public int GetHp()
		{

			Console.WriteLine(name + " har nu " +  hp + "hp.");

			return hp;
		}


		public bool IsAlive()
		{
			bool enoughHP = false;

			if (hp >= 1)
			{
				enoughHP = true;
			}




			return enoughHP;
			
		}

	}
}
