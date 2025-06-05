//HintName: G.Models.RateLimitRequestIn.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RateLimitRequestIn
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate_limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int RateLimit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reason", Required = global::Newtonsoft.Json.Required.Always)]
        public string Reason { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitRequestIn" /> class.
        /// </summary>
        /// <param name="rateLimit"></param>
        /// <param name="reason"></param>
        public RateLimitRequestIn(
            int rateLimit,
            string reason)
        {
            this.RateLimit = rateLimit;
            this.Reason = reason ?? throw new global::System.ArgumentNullException(nameof(reason));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitRequestIn" /> class.
        /// </summary>
        public RateLimitRequestIn()
        {
        }
    }
}