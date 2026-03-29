//HintName: G.Models.Error429.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rate limit exceeded response. When this error is returned, the response includes headers<br/>
    /// to help you implement proper retry logic:<br/>
    /// - `Retry-After`: Number of seconds to wait before retrying<br/>
    /// - `X-RateLimit-Remaining`: Requests remaining in current window<br/>
    /// - `X-RateLimit-Consumed`: Requests consumed in current window
    /// </summary>
    public sealed partial class Error429
    {
        /// <summary>
        /// Error code indicating rate limit was exceeded<br/>
        /// Example: rate_limit_exceeded
        /// </summary>
        /// <example>rate_limit_exceeded</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Error { get; set; }

        /// <summary>
        /// Human-readable error message<br/>
        /// Example: Too many requests
        /// </summary>
        /// <example>Too many requests</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Error429" /> class.
        /// </summary>
        /// <param name="error">
        /// Error code indicating rate limit was exceeded<br/>
        /// Example: rate_limit_exceeded
        /// </param>
        /// <param name="message">
        /// Human-readable error message<br/>
        /// Example: Too many requests
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error429(
            string error,
            string message)
        {
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error429" /> class.
        /// </summary>
        public Error429()
        {
        }
    }
}