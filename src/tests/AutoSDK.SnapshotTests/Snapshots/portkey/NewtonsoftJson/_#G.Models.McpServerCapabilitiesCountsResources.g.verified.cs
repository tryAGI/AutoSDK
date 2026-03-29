//HintName: G.Models.McpServerCapabilitiesCountsResources.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerCapabilitiesCountsResources
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public int? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerCapabilitiesCountsResources" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="enabled"></param>
        public McpServerCapabilitiesCountsResources(
            int? total,
            int? enabled)
        {
            this.Total = total;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerCapabilitiesCountsResources" /> class.
        /// </summary>
        public McpServerCapabilitiesCountsResources()
        {
        }
    }
}