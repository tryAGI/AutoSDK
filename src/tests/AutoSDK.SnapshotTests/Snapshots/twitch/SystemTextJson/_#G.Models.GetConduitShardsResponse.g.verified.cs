//HintName: G.Models.GetConduitShardsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConduitShardsResponse
    {
        /// <summary>
        /// List of information about a conduit's shards.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.GetConduitShardsResponseDataItem> Data { get; set; }

        /// <summary>
        /// Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.GetConduitShardsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConduitShardsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// List of information about a conduit's shards.
        /// </param>
        /// <param name="pagination">
        /// Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetConduitShardsResponse(
            global::System.Collections.Generic.IList<global::G.GetConduitShardsResponseDataItem> data,
            global::G.GetConduitShardsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConduitShardsResponse" /> class.
        /// </summary>
        public GetConduitShardsResponse()
        {
        }
    }
}