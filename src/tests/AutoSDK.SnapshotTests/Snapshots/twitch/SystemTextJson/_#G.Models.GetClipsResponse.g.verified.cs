//HintName: G.Models.GetClipsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetClipsResponse
    {
        /// <summary>
        /// The list of video clips. For clips returned by _game\_id_ or _broadcaster\_id_, the list is in descending order by view count. For lists returned by _id_, the list is in the same order as the input IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.Clip> Data { get; set; }

        /// <summary>
        /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.GetClipsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of video clips. For clips returned by _game\_id_ or _broadcaster\_id_, the list is in descending order by view count. For lists returned by _id_, the list is in the same order as the input IDs.
        /// </param>
        /// <param name="pagination">
        /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetClipsResponse(
            global::System.Collections.Generic.IList<global::G.Clip> data,
            global::G.GetClipsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetClipsResponse" /> class.
        /// </summary>
        public GetClipsResponse()
        {
        }
    }
}