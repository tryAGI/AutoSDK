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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseCodeInterpreterCallCompletedEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that the code interpreter call is in progress.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// A tool call to run code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_interpreter_call", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeInterpreterToolCall CodeInterpreterCall { get; set; } = default!;

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public int SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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