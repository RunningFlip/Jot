namespace Jot {
	public abstract class JValue<T> : IJValue {
		#region STATIC MEMBERS -----------------------------------------------------------

		public static Type ValueType { get; } = typeof(T);

		#endregion
		#region PROPERTIES ---------------------------------------------------------------

		public T Value { get; set; }

		#endregion
		#region CONSTRUCTORS -------------------------------------------------------------

		protected JValue(T value) {
			this.Value = value;
		}

		#endregion
		#region METHODS ------------------------------------------------------------------

		public object GetRawValue() {
			return this.Value;
		}

		public string ToJSON() {
			try {
				return this.ValueToJson(this.Value);
			}
			catch (Exception e) {
				throw new Exception($"Failed parsing the following value of type '{ValueType}' to a valid JSON format!\nValue: {this.Value?.ToString() ?? "null"}", e);
			}
		}

		protected abstract T JsonToValue(string json);

		protected abstract string ValueToJson(T value);

		protected T ToValue(string json) {
			if (string.IsNullOrEmpty(json)) {
				throw new ArgumentException($"Failed parsing an empty JSON to type '{ValueType}'!", json);
			}

			try {
				return this.JsonToValue(json);
			}
			catch (Exception e) {
				throw new Exception($"Failed parsing the following JSON to type '{ValueType}'!\nJSON: {json}", e);
			}
		}

		#endregion
	}
}