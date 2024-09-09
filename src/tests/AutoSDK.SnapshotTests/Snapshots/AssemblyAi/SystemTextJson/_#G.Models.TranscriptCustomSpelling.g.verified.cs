//HintName: G.Models.TranscriptCustomSpelling.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object containing words or phrases to replace, and the word or phrase to replace with
    /// </summary>
    public sealed partial class TranscriptCustomSpelling
    {
        /// <summary>
        /// Words or phrases to replace
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> From { get; set; }

        /// <summary>
        /// Word or phrase to replace with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("to")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string To { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}