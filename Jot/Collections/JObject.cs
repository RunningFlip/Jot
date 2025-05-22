using System.Collections;
using System.Text.Json;

namespace Jot {
	public abstract class JObject : IJCollection, IEnumerable<KeyValuePair<string, IJValue>> {
		#region FIELDS -------------------------------------------------------------------

		private readonly Dictionary<string, IJValue> values = new();

		#endregion
		#region PROPERTIES ---------------------------------------------------------------

		public int Count => this.values.Count;

		public IJValue this[string key] {
			get => this.values[key];
			set => this.values[key] = value;
		}

		public IEnumerable<string> Keys => this.values.Keys;

		public IEnumerable<IJValue> Values => this.values.Values;

		#endregion
		#region METHODS ------------------------------------------------------------------

		public void Add(string key, IJValue value) {
			this.values[key] = value;
		}

		public bool Remove(string key) {
			return this.values.Remove(key);
		}

		public bool Contains(string key) {
			return this.values.ContainsKey(key);
		}

		public object GetRawValue() {
			Dictionary<string, object> rawDict = new();

			foreach (KeyValuePair<string, IJValue> kvp in this.values) {
				rawDict[kvp.Key] = kvp.Value.GetRawValue();
			}

			return rawDict;
		}

		public string ToJSON() {
			List<string> jsonItems = new();

			foreach (KeyValuePair<string, IJValue> kvp in this.values) {
				string keyJson = JsonSerializer.Serialize(kvp.Key);
				string valueJson = kvp.Value.ToJSON();
				jsonItems.Add($"{keyJson}:{valueJson}");
			}

			return "{" + string.Join(",", jsonItems) + "}";
		}

		public IEnumerator<KeyValuePair<string, IJValue>> GetEnumerator() {
			return this.values.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator() {
			return this.GetEnumerator();
		}

		#endregion
	}
}