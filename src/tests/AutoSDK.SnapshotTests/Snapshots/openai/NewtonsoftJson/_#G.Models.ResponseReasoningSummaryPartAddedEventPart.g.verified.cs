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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseReasoningSummaryPartAddedEventPartType Type { get; set; }

        /// <summary>
        /// The text of the summary part.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text", Required = global::Newtonsoft.Json.Required.Always)]
        public string Text { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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