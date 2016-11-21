/* ©2016, lavrowlad, NURE */

using System;
using System.Text.RegularExpressions;

namespace Clinic.Utils
{
	public class RegexString : NonEmptyString
	{
		public RegexString ( string name, string pattern )
			: base( name )
		{
			this.pattern = pattern;
		}

		protected override void CheckValue ( string value )
		{
			base.CheckValue( value );
			if ( !Regex.IsMatch( value, pattern ) )
				throw new ArgumentException( "Invalid format", ParamName );
		}

		private readonly string pattern;
	}
}
