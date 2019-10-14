using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightsimV1
{
	class Fighter
	{
		public int hp = 100;
		
		
		List<string> FighterName = new List<string>();
		 public void NameDecide()
		{
			
			
			
			Console.WriteLine("Välj ett namn på spelare A");
			FighterName.Add(Console.ReadLine());
			string spelareA = FighterName[0];

			Console.WriteLine("Namnet på spelare A: " + FighterName[0]);
			
			
			Console.WriteLine("Välj ett namn på spelare B");
			FighterName.Add(Console.ReadLine());
			string spelareB = FighterName[1];
			Console.WriteLine("Namnet på spelare B: " + FighterName[1]);
			Console.WriteLine(spelareA);
			Console.ReadKey();
		}
		
		public void FightLoop()
		{
			

		}

	}
}
