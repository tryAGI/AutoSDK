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
        [global::Newtonsoft.Json.JsonProperty("rate_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int RateLimit { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOut" /> class.
        /// </summary>
        /// <param name="rateLimit">
        /// Per model rate limit
        /// </param>
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