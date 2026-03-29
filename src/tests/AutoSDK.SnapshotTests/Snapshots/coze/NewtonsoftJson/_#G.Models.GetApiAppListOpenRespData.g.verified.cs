//HintName: G.Models.GetApiAppListOpenRespData.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetApiAppListOpenRespData
    {
        /// <summary>
        /// 是否还有更多数据
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("items")]
        public global::System.Collections.Generic.IList<global::G.ApiAppOpenV2>? Items { get; set; }

        /// <summary>
        /// 分页 token, 第一页传空，下一页通过上一个返回的 next_page_token
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiAppListOpenRespData" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// 是否还有更多数据
        /// </param>
        /// <param name="items"></param>
        /// <param name="nextPageToken">
        /// 分页 token, 第一页传空，下一页通过上一个返回的 next_page_token
        /// </param>
        public GetApiAppListOpenRespData(
            bool? hasMore,
            global::System.Collections.Generic.IList<global::G.ApiAppOpenV2>? items,
            string? nextPageToken)
        {
            this.HasMore = hasMore;
            this.Items = items;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetApiAppListOpenRespData" /> class.
        /// </summary>
        public GetApiAppListOpenRespData()
        {
        }
    }
}