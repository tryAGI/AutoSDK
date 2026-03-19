//HintName: G.Models.RateLimitInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rate limit information.
    /// </summary>
    public sealed partial class RateLimitInfo
    {
        /// <summary>
        /// The name of the rate limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RateLimitInfoNameJsonConverter))]
        public global::G.RateLimitInfoName? Name { get; set; }

        /// <summary>
        /// The maximum allowed value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The remaining value before the limit is reached.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("remaining")]
        public int? Remaining { get; set; }

        /// <summary>
        /// Seconds until the rate limit resets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reset_seconds")]
        public double? ResetSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitInfo" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the rate limit.
        /// </param>
        /// <param name="limit">
        /// The maximum allowed value.
        /// </param>
        /// <param name="remaining">
        /// The remaining value before the limit is reached.
        /// </param>
        /// <param name="resetSeconds">
        /// Seconds until the rate limit resets.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RateLimitInfo(
            global::G.RateLimitInfoName? name,
            int? limit,
            int? remaining,
            double? resetSeconds)
        {
            this.Name = name;
            this.Limit = limit;
            this.Remaining = remaining;
            this.ResetSeconds = resetSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitInfo" /> class.
        /// </summary>
        public RateLimitInfo()
        {
        }
    }
}