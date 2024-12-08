//HintName: G.Models.BetaRateLimitError.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BetaRateLimitError
    {
        /// <summary>
        /// Default Value: rate_limit_error
        /// </summary>
        /// <default>global::G.BetaRateLimitErrorType.RateLimitError</default>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.BetaRateLimitErrorType Type { get; set; } = global::G.BetaRateLimitErrorType.RateLimitError;

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
        /// Initializes a new instance of the <see cref="BetaRateLimitError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: rate_limit_error
        /// </param>
        /// <param name="message">
        /// Default Value: Rate limited
        /// </param>
        public BetaRateLimitError(
            string message,
            global::G.BetaRateLimitErrorType type = global::G.BetaRateLimitErrorType.RateLimitError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaRateLimitError" /> class.
        /// </summary>
        public BetaRateLimitError()
        {
        }
    }
}