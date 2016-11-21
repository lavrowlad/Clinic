/* ©2016, lavrowlad, NURE */

using System;

namespace Clinic.Utils
{
	public abstract class AbstractProperty
	{
		public string ParamName { get; private set; }

		protected AbstractProperty ( string paramName )
		{
			if ( paramName == null )
				throw new ArgumentNullException( "paramName" );

			this.ParamName = paramName;
		}
	}
}
