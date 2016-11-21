/* ©2016, lavrowlad, NURE */

using System;

namespace Clinic.Utils
{
	public abstract class NonEmptyString : AbstractProperty
	{
		public string Value
		{
			get { return _value; }

			set
			{
				CheckValue( value );
				_value = value;
			}
		}

		public NonEmptyString ( string paramName )
			: base( paramName )
		{
		}

		protected virtual void CheckValue ( string value )
		{
			if ( value == null )
				throw new ArgumentNullException( ParamName );

			if ( value.Length == 0 )
				throw new ArgumentException( "Empty value not allowed", ParamName );
		}

		private string _value;
	}
}
