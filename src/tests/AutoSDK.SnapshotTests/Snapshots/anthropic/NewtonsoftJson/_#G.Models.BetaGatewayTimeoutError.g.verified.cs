//HintName: G.Models.BetaGatewayTimeoutError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaGatewayTimeoutError
    {
        /// <summary>
        /// Default Value: timeout_error
        /// </summary>
        /// <default>global::G.BetaGatewayTimeoutErrorType.TimeoutError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaGatewayTimeoutErrorType Type { get; set; } = global::G.BetaGatewayTimeoutErrorType.TimeoutError;

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
        /// Initializes a new instance of the <see cref="BetaGatewayTimeoutError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: timeout_error
        /// </param>
        /// <param name="message">
        /// Default Value: Request timeout
        /// </param>
        public BetaGatewayTimeoutError(
            string message,
            global::G.BetaGatewayTimeoutErrorType type = global::G.BetaGatewayTimeoutErrorType.TimeoutError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaGatewayTimeoutError" /> class.
        /// </summary>
        public BetaGatewayTimeoutError()
        {
        }
    }
}