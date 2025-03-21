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
        /// The final code snippet output by the code interpreter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// The index of the output item that the code interpreter call is in progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call.code.done`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseCodeInterpreterCallCodeDoneEventTypeJsonConverter))]
        public global::G.ResponseCodeInterpreterCallCodeDoneEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallCodeDoneEvent" /> class.
        /// </summary>
        /// <param name="code">
        /// The final code snippet output by the code interpreter.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the code interpreter call is in progress.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call.code.done`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCodeInterpreterCallCodeDoneEvent(
            string code,
            int outputIndex,
            global::G.ResponseCodeInterpreterCallCodeDoneEventType type)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.OutputIndex = outputIndex;
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