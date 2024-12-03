//HintName: G.Models.RateLimitOverview.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Rate Limit Overview
    /// </summary>
    public sealed partial class RateLimitOverview
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resources")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RateLimitOverviewResources Resources { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rate")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.RateLimit Rate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverview" /> class.
        /// </summary>
        /// <param name="resources"></param>
        /// <param name="rate"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RateLimitOverview(
            global::G.RateLimitOverviewResources resources,
            global::G.RateLimit rate)
        {
            this.Resources = resources ?? throw new global::System.ArgumentNullException(nameof(resources));
            this.Rate = rate ?? throw new global::System.ArgumentNullException(nameof(rate));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverview" /> class.
        /// </summary>
        public RateLimitOverview()
        {
        }
    }
}