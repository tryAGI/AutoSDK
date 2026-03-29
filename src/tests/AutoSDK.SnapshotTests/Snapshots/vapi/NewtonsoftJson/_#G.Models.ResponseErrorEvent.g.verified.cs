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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseErrorEventType Type { get; set; } = global::G.ResponseErrorEventType.Error;

        /// <summary>
        /// Error code<br/>
        /// Example: ERR_SOMETHING
        /// </summary>
        /// <example>ERR_SOMETHING</example>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string Code { get; set; } = default!;

        /// <summary>
        /// Error message<br/>
        /// Example: Something went wrong
        /// </summary>
        /// <example>Something went wrong</example>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Parameter that caused the error
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Sequence number of the event<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::Newtonsoft.Json.JsonProperty("sequence_number", Required = global::Newtonsoft.Json.Required.Always)]
        public double SequenceNumber { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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