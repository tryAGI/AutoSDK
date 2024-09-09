//HintName: G.Models.ContentSafetyLabelResult.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContentSafetyLabelResult
    {
        /// <summary>
        /// The transcript of the section flagged by the Content Moderation model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// An array of safety labels, one per sensitive topic that was detected in the section
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.ContentSafetyLabel> Labels { get; set; }

        /// <summary>
        /// The sentence index at which the section begins
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_idx_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentencesIdxStart { get; set; }

        /// <summary>
        /// The sentence index at which the section ends
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sentences_idx_end")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SentencesIdxEnd { get; set; }

        /// <summary>
        /// Timestamp containing a start and end property in milliseconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Timestamp Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}