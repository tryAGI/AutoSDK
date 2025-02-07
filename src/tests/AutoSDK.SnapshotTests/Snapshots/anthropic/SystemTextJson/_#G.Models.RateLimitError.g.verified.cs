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
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RateLimitErrorTypeJsonConverter))]
        public global::G.RateLimitErrorType Type { get; set; } = global::G.RateLimitErrorType.RateLimitError;

        /// <summary>
        /// Default Value: Rate limited
        /// </summary>
        /// <default>"Rate limited"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; } = "Rate limited";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitError" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: rate_limit_error
        /// </param>
        /// <param name="message">
        /// Default Value: Rate limited
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitError(
            string message,
            global::G.RateLimitErrorType type = global::G.RateLimitErrorType.RateLimitError)
        {
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitError" /> class.
        /// </summary>
        public RateLimitError()
        {
        }
    }
}