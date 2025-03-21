//HintName: G.Models.ResponseErrorEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Emitted when an error occurs.
    /// </summary>
    public sealed partial class ResponseErrorEvent
    {
        /// <summary>
        /// The error code.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("code", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Code { get; set; } = default!;

        /// <summary>
        /// The error message.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// The error parameter.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("param", Required = global::Newtonsoft.Json.Required.Always)]
        public string? Param { get; set; } = default!;

        /// <summary>
        /// The type of the event. Always `error`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.ResponseErrorEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseErrorEvent" /> class.
        /// </summary>
        /// <param name="code">
        /// The error code.
        /// </param>
        /// <param name="message">
        /// The error message.
        /// </param>
        /// <param name="param">
        /// The error parameter.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `error`.
        /// </param>
        public ResponseErrorEvent(
            string? code,
            string message,
            string? param,
            global::G.ResponseErrorEventType type)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param ?? throw new global::System.ArgumentNullException(nameof(param));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseErrorEvent" /> class.
        /// </summary>
        public ResponseErrorEvent()
        {
        }
    }
}