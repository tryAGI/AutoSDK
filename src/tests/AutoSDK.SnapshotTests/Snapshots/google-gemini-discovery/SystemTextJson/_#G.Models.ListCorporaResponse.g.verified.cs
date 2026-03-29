//HintName: G.Models.ListCorporaResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from `ListCorpora` containing a paginated list of `Corpora`. The results are sorted by ascending `corpus.create_time`.
    /// </summary>
    public sealed partial class ListCorporaResponse
    {
        /// <summary>
        /// The returned corpora.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("corpora")]
        public global::System.Collections.Generic.IList<global::G.Corpus>? Corpora { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCorporaResponse" /> class.
        /// </summary>
        /// <param name="corpora">
        /// The returned corpora.
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListCorporaResponse(
            global::System.Collections.Generic.IList<global::G.Corpus>? corpora,
            string? nextPageToken)
        {
            this.Corpora = corpora;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCorporaResponse" /> class.
        /// </summary>
        public ListCorporaResponse()
        {
        }
    }
}