//HintName: G.Models.ResponseErrorEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ResponseErrorEvent
    {
        /// <summary>
        /// Event type<br/>
        /// Default Value: error
        /// </summary>
        /// <default>global::G.ResponseErrorEventType.Error</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ResponseErrorEventTypeJsonConverter))]
        public global::G.ResponseErrorEventType Type { get; set; } = global::G.ResponseErrorEventType.Error;

        /// <summary>
        /// Error code<br/>
        /// Example: ERR_SOMETHING
        /// </summary>
        /// <example>ERR_SOMETHING</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// Error message<br/>
        /// Example: Something went wrong
        /// </summary>
        /// <example>Something went wrong</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Parameter that caused the error
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Sequence number of the event<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseErrorEvent" /> class.
        /// </summary>
        /// <param name="code">
        /// Error code<br/>
        /// Example: ERR_SOMETHING
        /// </param>
        /// <param name="message">
        /// Error message<br/>
        /// Example: Something went wrong
        /// </param>
        /// <param name="sequenceNumber">
        /// Sequence number of the event<br/>
        /// Example: 1
        /// </param>
        /// <param name="param">
        /// Parameter that caused the error
        /// </param>
        /// <param name="type">
        /// Event type<br/>
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseErrorEvent(
            string code,
            string message,
            double sequenceNumber,
            string? param,
            global::G.ResponseErrorEventType type = global::G.ResponseErrorEventType.Error)
        {
            this.Type = type;
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseErrorEvent" /> class.
        /// </summary>
        public ResponseErrorEvent()
        {
        }
    }
}