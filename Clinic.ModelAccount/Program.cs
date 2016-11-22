/* ©2016, lavrowlad, NURE */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.ModelAccount
{
	class Program
	{
		static void Main ( string [ ] args )
		{
			Account ac = new Account(Guid.NewGuid(), "Vlad", "vlad@mail.com", "123456");
			Console.WriteLine( ac.ToString() );
		}
	}
}
