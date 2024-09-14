//HintName: G.Models.AutoHighlightsResult2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An array of results for the Key Phrases model, if it is enabled.<br/>
    /// See [Key phrases](https://www.assemblyai.com/docs/models/key-phrases) for more information.
    /// </summary>
    public sealed partial class AutoHighlightsResult2
    {
        /// <summary>
        /// Either success, or unavailable in the rare case that the model failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AudioIntelligenceModelStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AudioIntelligenceModelStatus Status { get; set; }

        /// <summary>
        /// A temporally-sequential array of Key Phrases
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AutoHighlightResult> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}