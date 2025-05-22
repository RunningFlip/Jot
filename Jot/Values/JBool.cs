namespace Jot {
	public class JBool : JValue<bool> {
		#region CONSTRUCTORS -------------------------------------------------------------

		public JBool(bool value) : base(value) { }

		#endregion
		#region METHODS ------------------------------------------------------------------

		protected override bool JsonToValue(string json) {
			return bool.Parse(json);
		}

		protected override string ValueToJson(bool value) {
			return value.ToString();
		}

		#endregion
	}
}