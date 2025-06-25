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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.GatewayTimeoutErrorTypeJsonConverter))]
        public global::G.GatewayTimeoutErrorType Type { get; set; } = global::G.GatewayTimeoutErrorType.TimeoutError;

        /// <summary>
        /// Default Value: Request timeout
        /// </summary>
        /// <default>"Request timeout"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Request timeout";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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