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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::G.McpServerUserAccessItem>? Data { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_user_access")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.McpServerUserAccessListResponseDefaultUserAccessJsonConverter))]
        public global::G.McpServerUserAccessListResponseDefaultUserAccess? DefaultUserAccess { get; set; }

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
        /// Initializes a new instance of the <see cref="McpServerUserAccessListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="defaultUserAccess"></param>
        /// <param name="total"></param>
        /// <param name="hasMore"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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