/* ©2016, lavrowlad, NURE */

using System;

namespace Clinic.ModelAccount
{
	public class Patient : Account
	{
		public AccountType Status
		{
			get { return _status.Value; }
			set { _status.Value = value; }
		}

		public Patient ( Guid id, string name, string email, string password )
			: base( id, name, email, password )
		{
			this._status.Value = AccountType.Patient;
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
