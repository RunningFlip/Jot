namespace Jot {
	public class JInt : JValue<int> {
		#region CONSTRUCTORS -------------------------------------------------------------

		public JInt(int value) : base(value) { }

		#endregion
		#region METHODS ------------------------------------------------------------------

		protected override int JsonToValue(string json) {
			return int.Parse(json);
		}

		protected override string ValueToJson(int value) {
			return value.ToString();
		}

		#endregion
	}
}