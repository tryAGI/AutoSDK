//HintName: G.Models.ResponseRefusalDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is a partial refusal text.
    /// </summary>
    public sealed partial class ResponseRefusalDeltaEvent
    {
        /// <summary>
        /// The index of the content part that the refusal text is added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ContentIndex { get; set; }

        /// <summary>
        /// The refusal text that is added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// The ID of the output item that the refusal text is added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that the refusal text is added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The type of the event. Always `response.refusal.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseRefusalDeltaEventTypeJsonConverter))]
        public global::G.ResponseRefusalDeltaEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRefusalDeltaEvent" /> class.
        /// </summary>
        /// <param name="contentIndex">
        /// The index of the content part that the refusal text is added to.
        /// </param>
        /// <param name="delta">
        /// The refusal text that is added.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the refusal text is added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the refusal text is added to.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.refusal.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseRefusalDeltaEvent(
            int contentIndex,
            string delta,
            string itemId,
            int outputIndex,
            global::G.ResponseRefusalDeltaEventType type)
        {
            this.ContentIndex = contentIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseRefusalDeltaEvent" /> class.
        /// </summary>
        public ResponseRefusalDeltaEvent()
        {
        }
    }
}