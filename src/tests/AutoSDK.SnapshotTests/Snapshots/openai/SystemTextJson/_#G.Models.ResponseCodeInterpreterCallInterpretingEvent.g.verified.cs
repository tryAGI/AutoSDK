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
        [global::System.Text.Json.Serialization.JsonPropertyName("code_interpreter_call")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CodeInterpreterToolCall CodeInterpreterCall { get; set; }

        /// <summary>
        /// The index of the output item that the code interpreter call is in progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call.interpreting`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter))]
        public global::G.ResponseCodeInterpreterCallInterpretingEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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