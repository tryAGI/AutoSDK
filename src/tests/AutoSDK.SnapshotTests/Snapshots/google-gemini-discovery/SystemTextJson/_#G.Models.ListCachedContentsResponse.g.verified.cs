//HintName: G.Models.ListCachedContentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response with CachedContents list.
    /// </summary>
    public sealed partial class ListCachedContentsResponse
    {
        /// <summary>
        /// List of cached contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cachedContents")]
        public global::System.Collections.Generic.IList<global::G.CachedContent>? CachedContents { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no subsequent pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCachedContentsResponse" /> class.
        /// </summary>
        /// <param name="cachedContents">
        /// List of cached contents.
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no subsequent pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCachedContentsResponse(
            global::System.Collections.Generic.IList<global::G.CachedContent>? cachedContents,
            string? nextPageToken)
        {
            this.CachedContents = cachedContents;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCachedContentsResponse" /> class.
        /// </summary>
        public ListCachedContentsResponse()
        {
        }
    }
}