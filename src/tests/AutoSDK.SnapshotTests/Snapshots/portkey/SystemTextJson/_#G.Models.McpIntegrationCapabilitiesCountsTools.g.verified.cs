//HintName: G.Models.McpIntegrationCapabilitiesCountsTools.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationCapabilitiesCountsTools
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public int? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesCountsTools" /> class.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="enabled"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpIntegrationCapabilitiesCountsTools(
            int? total,
            int? enabled)
        {
            this.Total = total;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesCountsTools" /> class.
        /// </summary>
        public McpIntegrationCapabilitiesCountsTools()
        {
        }
    }
}