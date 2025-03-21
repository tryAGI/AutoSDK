//HintName: G.Models.ResponseOutputItemDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when an output item is marked done.
    /// </summary>
    public sealed partial class ResponseOutputItemDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.output_item.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseOutputItemDoneEventTypeJsonConverter))]
        public global::G.ResponseOutputItemDoneEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that was marked done.
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
        /// Initializes a new instance of the <see cref="ResponseOutputItemDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.output_item.done`.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that was marked done.
        /// </param>
        /// <param name="item"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseOutputItemDoneEvent(
            int outputIndex,
            global::G.OutputItem item,
            global::G.ResponseOutputItemDoneEventType type)
        {
            this.OutputIndex = outputIndex;
            this.Item = item;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseOutputItemDoneEvent" /> class.
        /// </summary>
        public ResponseOutputItemDoneEvent()
        {
        }
    }
}