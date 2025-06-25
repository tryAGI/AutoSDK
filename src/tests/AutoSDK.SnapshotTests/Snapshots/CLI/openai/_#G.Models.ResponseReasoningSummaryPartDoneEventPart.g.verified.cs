//HintName: G.Models.ResponseReasoningSummaryPartDoneEventPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The completed summary part.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryPartDoneEventPart
    {
        /// <summary>
        /// The type of the summary part. Always `summary_text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseReasoningSummaryPartDoneEventPartTypeJsonConverter))]
        public global::G.ResponseReasoningSummaryPartDoneEventPartType Type { get; set; }

        /// <summary>
        /// The text of the summary part.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartDoneEventPart" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the summary part. Always `summary_text`.
        /// </param>
        /// <param name="text">
        /// The text of the summary part.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseReasoningSummaryPartDoneEventPart(
            string text,
            global::G.ResponseReasoningSummaryPartDoneEventPartType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartDoneEventPart" /> class.
        /// </summary>
        public ResponseReasoningSummaryPartDoneEventPart()
        {
        }
    }
}