namespace Jot {
	public class JString : JValue<string> {
		#region CONSTRUCTORS -------------------------------------------------------------

		public JString(string value) : base(value) { }

		#endregion
		#region METHODS ------------------------------------------------------------------

		protected override string JsonToValue(string json) {
			return json;
		}

		protected override string ValueToJson(string value) {
			return value;
		}

		#endregion
	}
}