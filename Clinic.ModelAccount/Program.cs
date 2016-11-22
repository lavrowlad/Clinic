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
			accounts.Add( new Employee( AccountStatusEmployee.Administrator,    Guid.NewGuid(), "Vladyslav",		   "lavrowlad@clinic.com",		      "pas_lavrowlad" ) );
			accounts.Add( new Employee( AccountStatusEmployee.Administrator,    Guid.NewGuid(), "Alexandra",		   "alexandra@clinic.com",		      "pas_alexandra" ) );
			accounts.Add( new Employee( AccountStatusEmployee.Administrator,    Guid.NewGuid(), "Maxim",			   "maxim@clinic.com",		          "pas_maxim"     ) );

			accounts.Add( new Employee( AccountStatusEmployee.Doctor,		    Guid.NewGuid(), "Vasily Andreevich",   "vasily.andreevich@clinic.com",    "pas_doc_vasya" ) );
			accounts.Add( new Employee( AccountStatusEmployee.Doctor,		    Guid.NewGuid(), "Alexandra Sergeevna", "alexandra.sergeevna@clinic.com",  "pas_doc_alexa" ) );

			accounts.Add( new Employee( AccountStatusEmployee.Intern,		    Guid.NewGuid(), "Alexandra",           "alexandra@clinic.com",            "pas_intern_i1" ) );
			accounts.Add( new Employee( AccountStatusEmployee.Intern,		    Guid.NewGuid(), "Viktor",              "viktor@clinic.com",               "pas_intern_i2" ) );

			accounts.Add( new Employee( AccountStatusEmployee.Nurce,		    Guid.NewGuid(), "Anna",                "annechka@clinic.com",             "pas_nurce_ann" ) );

			accounts.Add( new Employee( AccountStatusEmployee.Operator,		    Guid.NewGuid(), "Anatoly",             "anatoly@clinic.com",              "pas_oper_tola" ) );

			accounts.Add( new Patient(	AccountStatusPatient.AuthorlessPatient, Guid.NewGuid(), "Maxin",			   "maxik037@rambler.ru",			  "maxZal06"      ) );
			accounts.Add( new Patient(	AccountStatusPatient.RegisteredPatient, Guid.NewGuid(), "Valera",			   "valerchik037@rambler.ru",		  "v@1er4ik"	  ) );

			Console.WriteLine("=== Accounts ===");
			foreach ( Account account in accounts )
				Console.WriteLine( "\n" + account.ToString() );
			Console.WriteLine();
		}
	}
}
