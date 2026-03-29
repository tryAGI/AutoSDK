//HintName: G.Models.McpIntegrationCapabilitiesCountsPrompts.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationCapabilitiesCountsPrompts
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
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesCountsPrompts" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="enabled"></param>
        public McpIntegrationCapabilitiesCountsPrompts(
            int? total,
            int? enabled)
        {
            this.Total = total;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesCountsPrompts" /> class.
        /// </summary>
        public McpIntegrationCapabilitiesCountsPrompts()
        {
        }
    }
}