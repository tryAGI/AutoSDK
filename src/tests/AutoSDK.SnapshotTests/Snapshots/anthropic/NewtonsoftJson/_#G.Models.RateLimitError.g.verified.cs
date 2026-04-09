//HintName: G.Models.RateLimitError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitError
    {
        /// <summary>
        /// Default Value: rate_limit_error
        /// </summary>
        /// <default>global::G.RateLimitErrorType.RateLimitError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.RateLimitErrorTypeJsonConverter))]
        public global::G.RateLimitErrorType Type { get; set; } = global::G.RateLimitErrorType.RateLimitError;

        /// <summary>
        /// Default Value: Rate limited
        /// </summary>
        /// <default>"Rate limited"</default>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitError" /> class.
        /// </summary>
        /// <param name="message">
        /// Default Value: Rate limited
        /// </param>
        /// <param name="type">
        /// Default Value: rate_limit_error
        /// </param>
        public RateLimitError(
            string message,
            global::G.RateLimitErrorType type = global::G.RateLimitErrorType.RateLimitError)
        {
            this.Type = type;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitError" /> class.
        /// </summary>
        public RateLimitError()
        {
        }
    }
}