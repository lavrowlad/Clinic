/* ©2016, lavrowlad, NURE */

using System;

namespace Clinic.Utils
{
	public class RequriedProperty< T > : AbstractProperty
	{
		public T Value
		{
			get { return _value; }
			set
			{
				if ( value == null )
					throw new ArgumentNullException( ParamName );

				_value = value;
			}
		}

		public RequriedProperty ( string paramName )
			: base( paramName )
		{
		}

		private T _value;
	}
}
