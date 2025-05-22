namespace Jot {
	public static class JExtension {
		#region STATIC MEMBERS -----------------------------------------------------------

		public static bool IsNull(IJValue value) {
			return value is JNull;
		}

		public static bool IsArray(IJValue value) {
			return value is JArray;
		}

		public static bool IsArray(IJValue value, out JArray? json) {
			if (value is JArray output) {
				json = output;

				return true;
			}

			json = null;

			return false;
		}

		public static bool IsObject(IJValue value) {
			return value is JObject;
		}

		public static bool IsObject(IJValue value, out JObject? json) {
			if (value is JObject output) {
				json = output;

				return true;
			}

			json = null;

			return false;
		}

		public static bool IsBool(IJValue value) {
			return value is JBool;
		}

		public static bool IsBool(IJValue value, out JBool? json) {
			if (value is JBool output) {
				json = output;

				return true;
			}

			json = null;

			return false;
		}

		public static bool IsInt(IJValue value) {
			return value is JInt;
		}

		public static bool IsInt(IJValue value, out JInt? json) {
			if (value is JInt output) {
				json = output;

				return true;
			}

			json = null;

			return false;
		}

		public static bool IsDouble(IJValue value) {
			return value is JDouble;
		}

		public static bool IsDouble(IJValue value, out JDouble? json) {
			if (value is JDouble output) {
				json = output;

				return true;
			}

			json = null;

			return false;
		}

		public static bool IsString(IJValue value) {
			return value is JString;
		}

		public static bool IsString(IJValue value, out JString? json) {
			if (value is JString output) {
				json = output;

				return true;
			}

			json = null;

			return false;
		}

		#endregion
	}
}