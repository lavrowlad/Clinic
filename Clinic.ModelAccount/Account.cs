/* ©2016, lavrowlad, NURE */

using System;
using System.Text.RegularExpressions;

namespace Clinic.ModelAccount
{
	public abstract class Account : Utils.Entity
	{
		public string Name
		{
			get { return _name.Value; }
			set { _name.Value = value; }
		}

		public string Email
		{
			get { return _name.Value; }
			set { _email.Value = value; }
		}


		public Account ( Guid id, string name, string email, string password )
			: base( id )
		{
			this.Name = name;
			this.Email = email;
			ChangePassword( password );
		}

		public override string ToString ()
		{
			return string.Format(
					"ID = {0}\nName = {1}\nEmail = {2}\nPassword = {3}",
					Id,
					Name,
					Email,
					_password.Value
				);
		}

		public bool CheckPassword ( string password )
		{
			if ( password == null )
				throw new ArgumentNullException( "password" );

			return this._password.Value == password;
		}

		public void ChangePassword ( string password )
		{
			this._password.Value = password;
		}

		private Utils.NonEmptyString _name = new Utils.NonEmptyString( "name" );
		private Utils.RegexString _email = new Utils.RegexString( "email", "^\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*$" );
		private Utils.NonEmptyString _password = new Utils.NonEmptyString( "password" );
	}
}
