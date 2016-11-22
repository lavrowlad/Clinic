/* ©2016, lavrowlad, NURE */

using System;

namespace Clinic.ModelAccount
{
	public class Patient : Account
	{
		public AccountType Type
		{
			get { return _type.Value; }
			set { _type.Value = value; }
		}

		public AccountStatusPatient Status
		{
			get { return _status.Value; }
			set { _status.Value = value; }
		}
		

		public Patient ( AccountStatusPatient status, Guid id, string name, string email, string password )
			: base( id, name, email, password )
		{
			this._type.Value = AccountType.Patient;
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


		private Utils.RequriedProperty< AccountType > _type = new Utils.RequriedProperty<AccountType>( "accountType" );
		private Utils.RequriedProperty< AccountStatusPatient > _status = new Utils.RequriedProperty<AccountStatusPatient>("accountStatus");
	}
}
