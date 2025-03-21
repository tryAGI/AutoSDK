//HintName: G.Models.ResponseFunctionCallArgumentsDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when there is a partial function-call arguments delta.
    /// </summary>
    public sealed partial class ResponseFunctionCallArgumentsDeltaEvent
    {
        /// <summary>
        /// The type of the event. Always `response.function_call_arguments.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseFunctionCallArgumentsDeltaEventTypeJsonConverter))]
        public global::G.ResponseFunctionCallArgumentsDeltaEventType Type { get; set; }

        /// <summary>
        /// The ID of the output item that the function-call arguments delta is added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item that the function-call arguments delta is added to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The function-call arguments delta that is added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFunctionCallArgumentsDeltaEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.function_call_arguments.delta`.
        /// </param>
        /// <param name="itemId">
        /// The ID of the output item that the function-call arguments delta is added to.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the function-call arguments delta is added to.
        /// </param>
        /// <param name="delta">
        /// The function-call arguments delta that is added.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseFunctionCallArgumentsDeltaEvent(
            string itemId,
            int outputIndex,
            string delta,
            global::G.ResponseFunctionCallArgumentsDeltaEventType type)
        {
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseFunctionCallArgumentsDeltaEvent" /> class.
        /// </summary>
        public ResponseFunctionCallArgumentsDeltaEvent()
        {
        }
    }
}