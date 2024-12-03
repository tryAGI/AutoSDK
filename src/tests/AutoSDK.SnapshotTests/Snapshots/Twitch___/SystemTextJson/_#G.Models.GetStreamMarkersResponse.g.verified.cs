//HintName: G.Models.GetStreamMarkersResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetStreamMarkersResponse
    {
        /// <summary>
        /// The list of markers grouped by the user that created the marks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.StreamMarkers> Data { get; set; }

        /// <summary>
        /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.GetStreamMarkersResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamMarkersResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of markers grouped by the user that created the marks.
        /// </param>
        /// <param name="pagination">
        /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GetStreamMarkersResponse(
            global::System.Collections.Generic.IList<global::G.StreamMarkers> data,
            global::G.GetStreamMarkersResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetStreamMarkersResponse" /> class.
        /// </summary>
        public GetStreamMarkersResponse()
        {
        }
    }
}