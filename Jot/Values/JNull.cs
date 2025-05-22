namespace Jot {
	public class JNull : IJValue {
		#region STATIC MEMBERS -----------------------------------------------------------

		public static JNull Instance = new();

		#endregion
		#region CONSTRUCTORS -------------------------------------------------------------

		private JNull() { }

		#endregion
		#region METHODS ------------------------------------------------------------------

		public object GetRawValue() {
			return null;
		}

		public string ToJSON() {
			return "null";
		}

		#endregion
	}
}