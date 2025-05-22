using System.Globalization;

namespace Jot {
	public class JDouble : JValue<double> {
		#region CONSTRUCTORS -------------------------------------------------------------

		public JDouble(double value) : base(value) { }

		#endregion
		#region METHODS ------------------------------------------------------------------

		protected override double JsonToValue(string json) {
			return double.Parse(json);
		}

		protected override string ValueToJson(double value) {
			return value.ToString(CultureInfo.InvariantCulture);
		}

		#endregion
	}
}