/* ©2016, lavrowlad, NURE */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Clinic.ModelAccount
{
	class Program
	{
		static List< Account > accounts = new List< Account >();

		static void Main ( string [ ] args )
		{
			accounts.Add( new Employee( AccountStatusEmployee.Administrator,    Guid.NewGuid(), "Vladyslav", "lavrowlad@gmail.com",		    "lavrowlad" ) );
			accounts.Add( new Employee( AccountStatusEmployee.Doctor,		    Guid.NewGuid(), "Alexandra", "alexandra.bublic@clinic.com", "alexandra" ) );
			accounts.Add( new Patient(	AccountStatusPatient.AuthorlessPatient, Guid.NewGuid(), "Maxin",	 "maxik037@rambler.ru",			"maxZal06"  ) );

			Console.WriteLine("=== Accounts ===");
			foreach ( Account account in accounts )
				Console.WriteLine( "\n" + account.ToString() );
			Console.WriteLine();
		}
	}
}
