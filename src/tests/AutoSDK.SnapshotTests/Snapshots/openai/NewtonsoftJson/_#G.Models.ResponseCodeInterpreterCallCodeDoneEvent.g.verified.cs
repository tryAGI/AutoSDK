//HintName: G.Models.ResponseCodeInterpreterCallCodeDoneEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when code snippet output is finalized by the code interpreter.
    /// </summary>
    public sealed partial class ResponseCodeInterpreterCallCodeDoneEvent
    {
        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call_code.done`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseCodeInterpreterCallCodeDoneEventType Type { get; set; }

        /// <summary>
        /// The index of the output item that the code interpreter call is in progress.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The final code snippet output by the code interpreter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

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
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallCodeDoneEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call_code.done`.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the code interpreter call is in progress.
        /// </param>
        /// <param name="code">
        /// The final code snippet output by the code interpreter.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        public ResponseCodeInterpreterCallCodeDoneEvent(
            int outputIndex,
            string code,
            int sequenceNumber,
            global::G.ResponseCodeInterpreterCallCodeDoneEventType type)
        {
            this.OutputIndex = outputIndex;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallCodeDoneEvent" /> class.
        /// </summary>
        public ResponseCodeInterpreterCallCodeDoneEvent()
        {
        }
    }
}