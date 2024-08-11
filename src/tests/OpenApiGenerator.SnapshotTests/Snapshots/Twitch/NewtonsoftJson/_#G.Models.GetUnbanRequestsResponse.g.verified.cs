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
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.GetUnbanRequestsResponseDataItem> Data { get; set; } = default!;

        /// <summary>
        /// Contains information used to page through a list of results. The object is empty if there are no more pages left to page through.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public global::G.GetUnbanRequestsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}