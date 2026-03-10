//HintName: G.Models.MessagesSearchResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessagesSearchResponse
    {
        /// <summary>
        /// Default Value: {}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("meta")]
        public global::G.ListResponseMeta? Meta { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.MessagesSearchResult> Results { get; set; }

        /// <summary>
        /// Cursor for the next page of results
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_cursor")]
        public string? NextCursor { get; set; }

        /// <summary>
        /// Whether there are more results available
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesSearchResponse" /> class.
        /// </summary>
        /// <param name="meta">
        /// Default Value: {}
        /// </param>
        /// <param name="results"></param>
        /// <param name="nextCursor">
        /// Cursor for the next page of results
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more results available
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesSearchResponse(
            global::System.Collections.Generic.IList<global::G.MessagesSearchResult> results,
            bool hasMore,
            global::G.ListResponseMeta? meta,
            string? nextCursor)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.HasMore = hasMore;
            this.Meta = meta;
            this.NextCursor = nextCursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesSearchResponse" /> class.
        /// </summary>
        public MessagesSearchResponse()
        {
        }
    }
}