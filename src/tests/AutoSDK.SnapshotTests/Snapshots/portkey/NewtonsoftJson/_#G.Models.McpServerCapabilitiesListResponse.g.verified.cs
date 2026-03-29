//HintName: G.Models.McpServerCapabilitiesListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerCapabilitiesListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.McpServerCapabilityItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("counts")]
        public global::G.McpServerCapabilitiesCounts? Counts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total")]
        public int? Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerCapabilitiesListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="counts"></param>
        /// <param name="total"></param>
        /// <param name="hasMore"></param>
        public McpServerCapabilitiesListResponse(
            global::System.Collections.Generic.IList<global::G.McpServerCapabilityItem>? data,
            global::G.McpServerCapabilitiesCounts? counts,
            int? total,
            bool? hasMore)
        {
            this.Data = data;
            this.Counts = counts;
            this.Total = total;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerCapabilitiesListResponse" /> class.
        /// </summary>
        public McpServerCapabilitiesListResponse()
        {
        }
    }
}