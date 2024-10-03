//HintName: G.Models.StopwordConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// fine-grained control over stopword list usage
    /// </summary>
    public sealed partial class StopwordConfig
    {
        /// <summary>
        /// pre-existing list of common words by language<br/>
        /// Default Value: en
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.StopwordConfigPresetJsonConverter))]
        public global::G.StopwordConfigPreset? Preset { get; set; } = global::G.StopwordConfigPreset.En;

        /// <summary>
        /// Stopwords to be considered additionally. Can be any array of custom strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("additions")]
        public global::System.Collections.Generic.IList<string>? Additions { get; set; }

        /// <summary>
        /// stopwords to be removed from consideration. Can be any array of custom strings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removals")]
        public global::System.Collections.Generic.IList<string>? Removals { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}