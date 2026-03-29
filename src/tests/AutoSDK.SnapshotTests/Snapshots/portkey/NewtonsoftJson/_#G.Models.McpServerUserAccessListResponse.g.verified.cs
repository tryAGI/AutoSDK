//HintName: G.Models.McpServerUserAccessListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class McpServerUserAccessListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.McpServerUserAccessItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("default_user_access")]
        public global::G.McpServerUserAccessListResponseDefaultUserAccess? DefaultUserAccess { get; set; }

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
        /// Initializes a new instance of the <see cref="McpServerUserAccessListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="defaultUserAccess"></param>
        /// <param name="total"></param>
        /// <param name="hasMore"></param>
        public McpServerUserAccessListResponse(
            global::System.Collections.Generic.IList<global::G.McpServerUserAccessItem>? data,
            global::G.McpServerUserAccessListResponseDefaultUserAccess? defaultUserAccess,
            int? total,
            bool? hasMore)
        {
            this.Data = data;
            this.DefaultUserAccess = defaultUserAccess;
            this.Total = total;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="McpServerUserAccessListResponse" /> class.
        /// </summary>
        public McpServerUserAccessListResponse()
        {
        }
    }
}