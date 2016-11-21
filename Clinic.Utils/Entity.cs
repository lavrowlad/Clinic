/* ©2016, lavrowlad, NURE */

using System;

namespace Clinic.Utils
{
	public abstract class Entity
	{
		public Guid Id { get; private set; }

		protected Entity ( Guid id )
		{
			if ( id == null )
				throw new ArgumentNullException( "id" );

			this.Id = id;
		}

		public override bool Equals ( object obj )
		{
			if ( this == obj )
				return true;

			if ( obj == null || GetType() != obj.GetType() )
				return false;

			var otherEntity = ( Entity ) obj;
			return Id == otherEntity.Id;
		}

		public override int GetHashCode ()
		{
			return Id.GetHashCode();
		}
	}
}
