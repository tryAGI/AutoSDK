//HintName: G.Models.RateLimitOut.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitOut
    {
        /// <summary>
        /// Per model rate limit
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RateLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOut" /> class.
        /// </summary>
        /// <param name="rateLimit">
        /// Per model rate limit
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitOut(
            int rateLimit)
        {
            this.RateLimit = rateLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOut" /> class.
        /// </summary>
        public RateLimitOut()
        {
        }
    }
}