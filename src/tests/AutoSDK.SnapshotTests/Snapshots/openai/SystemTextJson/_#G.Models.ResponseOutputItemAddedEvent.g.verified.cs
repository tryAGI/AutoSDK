//HintName: G.Models.ResponseOutputItemAddedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a new output item is added.
    /// </summary>
    public sealed partial class ResponseOutputItemAddedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.output_item.added`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputItemAddedEventTypeJsonConverter))]
        public global::G.ResponseOutputItemAddedEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.OutputItemJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.OutputItem Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemAddedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.output_item.added`.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that was added.
        /// </param>
        /// <param name="item"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputItemAddedEvent(
            int outputIndex,
            global::G.OutputItem item,
            global::G.ResponseOutputItemAddedEventType type)
        {
            this.OutputIndex = outputIndex;
            this.Item = item;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemAddedEvent" /> class.
        /// </summary>
        public ResponseOutputItemAddedEvent()
        {
        }
    }
}