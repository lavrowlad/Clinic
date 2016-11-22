/* ©2016, lavrowlad, NURE */

using System;

namespace Clinic.ModelAccount
{
	public class Employee : Account
	{
		public AccountType Type
		{
			get { return _type.Value; }
			set { _type.Value = value; }
		}

		public AccountStatusEmployee Status
		{
			get { return _status.Value; }
			set { _status.Value = value; }
		}


		public Employee ( AccountStatusEmployee status, Guid id, string name, string email, string password )
			: base( id, name, email, password )
		{
			this._type.Value = AccountType.Employee;
			this._status.Value = status;
		}

		public override string ToString ()
		{
			return string.Format(
					"{0} : {1}\n{2}",
					this._type.Value,
					this._status.Value,
					base.ToString()
				);
		}


		private Utils.RequriedProperty< AccountType > _type = new Utils.RequriedProperty< AccountType >( "accountType" );
		private Utils.RequriedProperty< AccountStatusEmployee > _status = new Utils.RequriedProperty< AccountStatusEmployee >("accountStatus");
	}
}
