//HintName: G.Models.GetDropsEntitlementsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDropsEntitlementsResponse
    {
        /// <summary>
        /// The list of entitlements.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DropsEntitlement> Data { get; set; } = default!;

        /// <summary>
        /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public global::G.GetDropsEntitlementsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDropsEntitlementsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of entitlements.
        /// </param>
        /// <param name="pagination">
        /// The information used to page through the list of results. The object is empty if there are no more pages left to page through. [Read More](https://dev.twitch.tv/docs/api/guide#pagination)
        /// </param>
        public GetDropsEntitlementsResponse(
            global::System.Collections.Generic.IList<global::G.DropsEntitlement> data,
            global::G.GetDropsEntitlementsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDropsEntitlementsResponse" /> class.
        /// </summary>
        public GetDropsEntitlementsResponse()
        {
        }
    }
}