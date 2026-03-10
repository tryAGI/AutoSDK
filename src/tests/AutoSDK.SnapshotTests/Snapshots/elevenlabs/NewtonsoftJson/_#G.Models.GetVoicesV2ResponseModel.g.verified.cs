//HintName: G.Models.GetVoicesV2ResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetVoicesV2ResponseModel
    {
        /// <summary>
        /// The list of voices matching the query.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.VoiceResponseModel> Voices { get; set; } = default!;

        /// <summary>
        /// Indicates whether there are more voices available in subsequent pages. Use this flag (and next_page_token) for reliable pagination instead of relying on total_count.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_more", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasMore { get; set; } = default!;

        /// <summary>
        /// The total count of voices matching the query. This value is a live snapshot that reflects the current state of the database and may change between requests as users create, modify, or delete voices. For reliable pagination, use the has_more flag instead of relying on this value. Only request this field when you actually need the total count (e.g., for display purposes), as calculating it incurs a performance cost.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// Token to retrieve the next page of results. Pass this value to the next request to continue pagination. Null if there are no more results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesV2ResponseModel" /> class.
        /// </summary>
        /// <param name="voices">
        /// The list of voices matching the query.
        /// </param>
        /// <param name="hasMore">
        /// Indicates whether there are more voices available in subsequent pages. Use this flag (and next_page_token) for reliable pagination instead of relying on total_count.
        /// </param>
        /// <param name="totalCount">
        /// The total count of voices matching the query. This value is a live snapshot that reflects the current state of the database and may change between requests as users create, modify, or delete voices. For reliable pagination, use the has_more flag instead of relying on this value. Only request this field when you actually need the total count (e.g., for display purposes), as calculating it incurs a performance cost.
        /// </param>
        /// <param name="nextPageToken">
        /// Token to retrieve the next page of results. Pass this value to the next request to continue pagination. Null if there are no more results.
        /// </param>
        public GetVoicesV2ResponseModel(
            global::System.Collections.Generic.IList<global::G.VoiceResponseModel> voices,
            bool hasMore,
            int totalCount,
            string? nextPageToken)
        {
            this.Voices = voices ?? throw new global::System.ArgumentNullException(nameof(voices));
            this.HasMore = hasMore;
            this.TotalCount = totalCount;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetVoicesV2ResponseModel" /> class.
        /// </summary>
        public GetVoicesV2ResponseModel()
        {
        }
    }
}