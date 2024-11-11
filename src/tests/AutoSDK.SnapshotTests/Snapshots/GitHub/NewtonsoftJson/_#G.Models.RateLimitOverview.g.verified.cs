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
        [global::Newtonsoft.Json.JsonProperty("resources", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RateLimitOverviewResources Resources { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.RateLimit Rate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitOverview" /> class.
        /// </summary>
        /// <param name="resources"></param>
        /// <param name="rate"></param>
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