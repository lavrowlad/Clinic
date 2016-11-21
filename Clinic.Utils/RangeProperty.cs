/* ©2016, lavrowlad, NURE */

using System;

namespace Clinic.Utils
{
	public class RangeProperty< T > : AbstractProperty
		where T : IComparable< T >
	{
		public T Value
		{
			get { return currentValue; }

			set
			{
				CheckValue( value );
				currentValue = value;
			}
		}

		public RangeProperty ( string paramName, T minValue, bool includingMin, T maxValue, bool includingMax )
			: base( paramName )
		{
			this.minValue = minValue;
			this.includingMin = includingMin;
			this.maxValue = maxValue;
			this.includingMax = includingMax;
		}


		protected void CheckValue ( T value )
		{
			if ( includingMin && value.CompareTo( minValue ) < 0 ||
				! includingMin && value.CompareTo( minValue ) <= 0 )
			{
				throw new ArgumentException( "Minimal range violated", ParamName );
			}

			if ( includingMax && value.CompareTo( maxValue ) > 0 ||
				! includingMax && value.CompareTo( maxValue ) >= 0 )
			{
				throw new ArgumentException( "Maximal range violated", ParamName );
			}
		}

		private T currentValue;
		private readonly T minValue, maxValue;
		private readonly bool includingMin, includingMax;
	}
}
