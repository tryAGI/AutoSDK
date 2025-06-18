﻿//HintName: G.Models.ResponseCodeInterpreterCallInterpretingEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when the code interpreter is actively interpreting the code snippet.
    /// </summary>
    public sealed partial class ResponseCodeInterpreterCallInterpretingEvent
    {
        /// <summary>
        /// The type of the event. Always `response.code_interpreter_call.interpreting`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseCodeInterpreterCallInterpretingEventTypeJsonConverter))]
        public global::G.ResponseCodeInterpreterCallInterpretingEventType Type { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCodeInterpreterCallInterpretingEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.code_interpreter_call.interpreting`.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item that the code interpreter call is in progress.
        /// </param>
        /// <param name="codeInterpreterCall">
        /// A tool call to run code.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCodeInterpreterCallInterpretingEvent(
            int sequenceNumber,
            int outputIndex,
            global::G.CodeInterpreterToolCall codeInterpreterCall,
            global::G.ResponseCodeInterpreterCallInterpretingEventType type)
        {
            this.SequenceNumber = sequenceNumber;
            this.OutputIndex = outputIndex;
            this.CodeInterpreterCall = codeInterpreterCall ?? throw new global::System.ArgumentNullException(nameof(codeInterpreterCall));
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