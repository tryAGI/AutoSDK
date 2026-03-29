//HintName: G.Models.McpIntegrationCapabilitiesListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpIntegrationCapabilitiesListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.McpIntegrationCapabilityItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("counts")]
        public global::G.McpIntegrationCapabilitiesCounts? Counts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="counts"></param>
        /// <param name="total"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public McpIntegrationCapabilitiesListResponse(
            global::System.Collections.Generic.IList<global::G.McpIntegrationCapabilityItem>? data,
            global::G.McpIntegrationCapabilitiesCounts? counts,
            int? total,
            bool? hasMore)
        {
            this.Data = data;
            this.Counts = counts;
            this.Total = total;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpIntegrationCapabilitiesListResponse" /> class.
        /// </summary>
        public McpIntegrationCapabilitiesListResponse()
        {
        }
    }
}