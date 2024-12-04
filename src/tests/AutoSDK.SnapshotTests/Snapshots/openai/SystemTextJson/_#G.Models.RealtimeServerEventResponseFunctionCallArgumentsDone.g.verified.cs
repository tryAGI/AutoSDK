//HintName: G.Models.RealtimeServerEventResponseFunctionCallArgumentsDone.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Returned when the model-generated function call arguments are done streaming.<br/>
    /// Also emitted when a Response is interrupted, incomplete, or cancelled.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseFunctionCallArgumentsDone
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `response.function_call_arguments.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RealtimeServerEventResponseFunctionCallArgumentsDoneTypeJsonConverter))]
        public global::G.RealtimeServerEventResponseFunctionCallArgumentsDoneType Type { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// The ID of the function call item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// The index of the output item in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The ID of the function call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// The final arguments as a JSON string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseFunctionCallArgumentsDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.function_call_arguments.done`.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="itemId">
        /// The ID of the function call item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="callId">
        /// The ID of the function call.
        /// </param>
        /// <param name="arguments">
        /// The final arguments as a JSON string.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeServerEventResponseFunctionCallArgumentsDone(
            string eventId,
            string responseId,
            string itemId,
            int outputIndex,
            string callId,
            string arguments,
            global::G.RealtimeServerEventResponseFunctionCallArgumentsDoneType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseFunctionCallArgumentsDone" /> class.
        /// </summary>
        public RealtimeServerEventResponseFunctionCallArgumentsDone()
        {
        }
    }
}