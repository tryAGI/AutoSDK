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
        public RateLimitOverviewResources Resources { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("rate", Required = global::Newtonsoft.Json.Required.Always)]
        public RateLimit Rate { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}