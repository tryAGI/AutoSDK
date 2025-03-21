//HintName: G.Models.ResponseCodeInterpreterCallInterpretingEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the code interpreter is actively interpreting the code snippet.
    /// </summary>
    public sealed partial class ResponseCodeInterpreterCallInterpretingEvent
    {
        /// <summary>
        /// A tool call to run code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code_interpreter_call", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CodeInterpreterToolCall CodeInterpreterCall { get; set; } = default!;

        /// <summary>
        /// The index of the output item that the code interpreter call is in progress.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call.interpreting`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseCodeInterpreterCallInterpretingEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallInterpretingEvent" /> class.
        /// </summary>
        /// <param name="codeInterpreterCall">
        /// A tool call to run code.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the code interpreter call is in progress.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call.interpreting`.
        /// </param>
        public ResponseCodeInterpreterCallInterpretingEvent(
            global::G.CodeInterpreterToolCall codeInterpreterCall,
            int outputIndex,
            global::G.ResponseCodeInterpreterCallInterpretingEventType type)
        {
            this.CodeInterpreterCall = codeInterpreterCall ?? throw new global::System.ArgumentNullException(nameof(codeInterpreterCall));
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallInterpretingEvent" /> class.
        /// </summary>
        public ResponseCodeInterpreterCallInterpretingEvent()
        {
        }
    }
}