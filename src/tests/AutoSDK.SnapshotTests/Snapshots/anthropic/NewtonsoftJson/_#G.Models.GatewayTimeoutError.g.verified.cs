//HintName: G.Models.GatewayTimeoutError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GatewayTimeoutError
    {
        /// <summary>
        /// Default Value: timeout_error
        /// </summary>
        /// <default>global::G.GatewayTimeoutErrorType.TimeoutError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.GatewayTimeoutErrorType Type { get; set; } = global::G.GatewayTimeoutErrorType.TimeoutError;

        /// <summary>
        /// Default Value: Request timeout
        /// </summary>
        /// <default>"Request timeout"</default>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayTimeoutError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: timeout_error
        /// </param>
        /// <param name="message">
        /// Default Value: Request timeout
        /// </param>
        public GatewayTimeoutError(
            string message,
            global::G.GatewayTimeoutErrorType type = global::G.GatewayTimeoutErrorType.TimeoutError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayTimeoutError" /> class.
        /// </summary>
        public GatewayTimeoutError()
        {
        }
    }
}