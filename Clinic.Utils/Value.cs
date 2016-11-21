/* ©2016, lavrowlad, NURE */

using System;
using System.Collections.Generic;
using System.Linq;


namespace Clinic.Utils
{
	public abstract class Value<TValue>
		where TValue : Value<TValue>
	{
		public override bool Equals ( object other )
		{
			return base.Equals( other as TValue );
		}

		public bool Equals ( TValue other )
		{
			if ( other == null )
				return false;

			var sequence1 = GetAttributesToIncludeInEqualityCheck();
			var sequence2 = other.GetAttributesToIncludeInEqualityCheck();
			return sequence1.SequenceEqual( sequence2 );
		}

		public static bool operator == ( Value<TValue> left, Value<TValue> right )
		{
			return Equals( left, right );
		}

		public static bool operator != ( Value<TValue> left, Value<TValue> right )
		{
			return !( left == right );
		}

		public override int GetHashCode ()
		{
			int hash = 17;
			foreach ( var obj in this.GetAttributesToIncludeInEqualityCheck() )
				hash = hash * 31 + ( obj == null ? 0 : obj.GetHashCode() );
			return hash;
		}

		protected abstract IEnumerable<object> GetAttributesToIncludeInEqualityCheck ();
	}
}
