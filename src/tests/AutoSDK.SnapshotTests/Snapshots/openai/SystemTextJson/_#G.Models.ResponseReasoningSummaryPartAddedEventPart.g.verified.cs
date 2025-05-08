//HintName: G.Models.ResponseReasoningSummaryPartAddedEventPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The summary part that was added.
    /// </summary>
    public sealed partial class ResponseReasoningSummaryPartAddedEventPart
    {
        /// <summary>
        /// The type of the summary part. Always `summary_text`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseReasoningSummaryPartAddedEventPartTypeJsonConverter))]
        public global::G.ResponseReasoningSummaryPartAddedEventPartType Type { get; set; }

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
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartAddedEventPart" /> class.
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
        public ResponseReasoningSummaryPartAddedEventPart(
            string text,
            global::G.ResponseReasoningSummaryPartAddedEventPartType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseReasoningSummaryPartAddedEventPart" /> class.
        /// </summary>
        public ResponseReasoningSummaryPartAddedEventPart()
        {
        }
    }
}