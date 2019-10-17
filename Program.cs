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
			Console.WriteLine("Ge ett namn till spelare A:");
			A.NameDecide();
			Console.WriteLine("Namnge spelare B:");
			B.NameDecide();
			

			Console.ReadKey();
			
		}
		
	}
}
