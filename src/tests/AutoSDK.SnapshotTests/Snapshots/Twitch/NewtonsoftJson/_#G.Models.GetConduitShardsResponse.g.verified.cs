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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetConduitShardsResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public global::G.GetConduitShardsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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