//HintName: G.Models.DirectoryQueryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API query response schema for directories.
    /// </summary>
    public sealed partial class DirectoryQueryResponse
    {
        /// <summary>
        /// The list of items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DirectoryResponse> Items { get; set; }

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
        /// Initializes a new instance of the <see cref="DirectoryQueryResponse" /> class.
        /// </summary>
        /// <param name="items">
        /// The list of items.
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
        public DirectoryQueryResponse(
            global::System.Collections.Generic.IList<global::G.DirectoryResponse> items,
            string? nextPageToken,
            int? totalSize)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.NextPageToken = nextPageToken;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryQueryResponse" /> class.
        /// </summary>
        public DirectoryQueryResponse()
        {
        }
    }
}