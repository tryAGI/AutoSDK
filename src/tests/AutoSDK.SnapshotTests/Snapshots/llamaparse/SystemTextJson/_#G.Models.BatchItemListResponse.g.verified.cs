//HintName: G.Models.BatchItemListResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Paginated response containing batch job item details.
    /// </summary>
    public sealed partial class BatchItemListResponse
    {
        /// <summary>
        /// List of item details
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::G.BatchItemDetail>? Items { get; set; }

        /// <summary>
        /// A token, which can be sent as page_token to retrieve the next page. If this field is omitted, there are no subsequent pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// The total number of items available. This is only populated when specifically requested. The value may be an estimate and can be used for display purposes only.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_size")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchItemListResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// List of item details
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as page_token to retrieve the next page. If this field is omitted, there are no subsequent pages.
        /// </param>
        /// <param name="totalSize">
        /// The total number of items available. This is only populated when specifically requested. The value may be an estimate and can be used for display purposes only.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchItemListResponse(
            global::System.Collections.Generic.IList<global::G.BatchItemDetail>? items,
            string? nextPageToken,
            int? totalSize)
        {
            this.Items = items;
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchItemListResponse" /> class.
        /// </summary>
        public BatchItemListResponse()
        {
        }
    }
}