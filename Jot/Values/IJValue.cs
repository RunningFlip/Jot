namespace Jot {
	public interface IJValue {
		#region METHODS ------------------------------------------------------------------

		object GetRawValue();

		string ToJSON();

		#endregion
	}
}