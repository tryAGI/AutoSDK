//HintName: G.Models.AutocompleteSuggestion.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A single autocomplete suggestion.
    /// </summary>
    public sealed partial class AutocompleteSuggestion
    {
        /// <summary>
        /// The autocomplete suggestion text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value")]
        public string? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteSuggestion" /> class.
        /// </summary>
        /// <param name="value">
        /// The autocomplete suggestion text.
        /// </param>
        public AutocompleteSuggestion(
            string? value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutocompleteSuggestion" /> class.
        /// </summary>
        public AutocompleteSuggestion()
        {
        }
    }
}