//HintName: G.Models.GetUnbanRequestsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetUnbanRequestsResponse
    {
        /// <summary>
        /// A list that contains information about the channel's unban requests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetUnbanRequestsResponseDataItem> Data { get; set; }

        /// <summary>
        /// Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.GetUnbanRequestsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUnbanRequestsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains information about the channel's unban requests.
        /// </param>
        /// <param name="pagination">
        /// Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUnbanRequestsResponse(
            global::System.Collections.Generic.IList<global::G.GetUnbanRequestsResponseDataItem> data,
            global::G.GetUnbanRequestsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUnbanRequestsResponse" /> class.
        /// </summary>
        public GetUnbanRequestsResponse()
        {
        }
    }
}