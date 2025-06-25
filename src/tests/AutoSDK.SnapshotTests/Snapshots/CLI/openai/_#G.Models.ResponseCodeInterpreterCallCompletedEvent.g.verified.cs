//HintName: G.Models.ResponseCodeInterpreterCallCompletedEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the code interpreter call is completed.
    /// </summary>
    public sealed partial class ResponseCodeInterpreterCallCompletedEvent
    {
        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call.completed`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseCodeInterpreterCallCompletedEventTypeJsonConverter))]
        public global::G.ResponseCodeInterpreterCallCompletedEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that the code interpreter call is in progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// A tool call to run code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter_call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodeInterpreterToolCall CodeInterpreterCall { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallCompletedEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call.completed`.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the code interpreter call is in progress.
        /// </param>
        /// <param name="codeInterpreterCall">
        /// A tool call to run code.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCodeInterpreterCallCompletedEvent(
            int outputIndex,
            global::G.CodeInterpreterToolCall codeInterpreterCall,
            int sequenceNumber,
            global::G.ResponseCodeInterpreterCallCompletedEventType type)
        {
            this.OutputIndex = outputIndex;
            this.CodeInterpreterCall = codeInterpreterCall ?? throw new global::System.ArgumentNullException(nameof(codeInterpreterCall));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallCompletedEvent" /> class.
        /// </summary>
        public ResponseCodeInterpreterCallCompletedEvent()
        {
        }
    }
}