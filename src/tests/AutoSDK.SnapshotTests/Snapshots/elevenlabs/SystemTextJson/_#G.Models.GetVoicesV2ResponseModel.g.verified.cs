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
        [global::System.Text.Json.Serialization.JsonPropertyName("voices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.VoiceResponseModel> Voices { get; set; }

        /// <summary>
        /// Indicates whether there are more voices available in subsequent pages. Use this flag (and next_page_token) for reliable pagination instead of relying on total_count.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The total count of voices matching the query. This value is a live snapshot that reflects the current state of the database and may change between requests as users create, modify, or delete voices. For reliable pagination, use the has_more flag instead of relying on this value. Only request this field when you actually need the total count (e.g., for display purposes), as calculating it incurs a performance cost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Token to retrieve the next page of results. Pass this value to the next request to continue pagination. Null if there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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