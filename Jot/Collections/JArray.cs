using System.Collections;

namespace Jot {
	public abstract class JArray : IJCollection, IEnumerable<IJValue> {
		#region FIELDS -------------------------------------------------------------------

		private readonly List<IJValue> values = new();

		#endregion
		#region PROPERTIES ---------------------------------------------------------------

		public int Count => this.values.Count;

		public IJValue this[int index] {
			get => this.values[index];
			set => this.values[index] = value;
		}

		#endregion
		#region METHODS ------------------------------------------------------------------

		public void Add(IJValue value) {
			this.values.Add(value);
		}

		public bool Remove(IJValue value) {
			return this.values.Remove(value);
		}

		public bool Contains(IJValue value) {
			return this.values.Contains(value);
		}

		public object GetRawValue() {
			object[] rawValues = new object[this.values.Count];

			for (int i = 0; i < this.values.Count; i++) {
				rawValues[i] = this.values[i].GetRawValue();
			}

			return rawValues;
		}

		public string ToJSON() {
			List<string> jsonList = new();

			foreach (IJValue item in this.values) {
				jsonList.Add(item.ToJSON());
			}

			return "[" + string.Join(",", jsonList) + "]";
		}

		public IEnumerator<IJValue> GetEnumerator() {
			return this.values.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return this.GetEnumerator();
		}

		#endregion
	}
}