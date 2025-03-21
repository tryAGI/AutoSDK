//HintName: G.Models.ResponseCodeInterpreterCallCodeDeltaEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when a partial code snippet is added by the code interpreter.
    /// </summary>
    public sealed partial class ResponseCodeInterpreterCallCodeDeltaEvent
    {
        /// <summary>
        /// The partial code snippet added by the code interpreter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// The index of the output item that the code interpreter call is in progress.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call.code.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseCodeInterpreterCallCodeDeltaEventTypeJsonConverter))]
        public global::G.ResponseCodeInterpreterCallCodeDeltaEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallCodeDeltaEvent" /> class.
        /// </summary>
        /// <param name="delta">
        /// The partial code snippet added by the code interpreter.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the code interpreter call is in progress.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call.code.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCodeInterpreterCallCodeDeltaEvent(
            string delta,
            int outputIndex,
            global::G.ResponseCodeInterpreterCallCodeDeltaEventType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.OutputIndex = outputIndex;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallCodeDeltaEvent" /> class.
        /// </summary>
        public ResponseCodeInterpreterCallCodeDeltaEvent()
        {
        }
    }
}