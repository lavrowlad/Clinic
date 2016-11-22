/* ©2016, lavrowlad, NURE */

using System;

namespace Clinic.ModelAccount
{
	public class Employee : Account
	{
		public AccountType Status
		{
			get { return _status.Value; }
			set { _status.Value = value; }
		}

		public Employee ( Guid id, string name, string email, string password)
			: base( id, name, email, password )
		{
			this._status.Value = AccountType.Employee;
		}

		public override string ToString ()
		{
			return string.Format(
					"Account status = {0}\n{1}",
					_status.ToString(),
					base.ToString()
				);
		}

		private Utils.RequriedProperty< AccountType > _status = new Utils.RequriedProperty<AccountType>( "accountStatus" );
	}
}
