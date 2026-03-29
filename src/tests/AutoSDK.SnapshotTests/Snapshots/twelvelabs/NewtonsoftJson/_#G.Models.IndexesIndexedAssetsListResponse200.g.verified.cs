//HintName: G.Models.IndexesIndexedAssetsListResponse200.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexesIndexedAssetsListResponse200
    {
        /// <summary>
        /// An array that contains up to `page_limit` indexed assets.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data")]
        public global::System.Collections.Generic.IList<global::G.IndexedAsset>? Data { get; set; }

        /// <summary>
        /// An object that provides information about pagination.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_info")]
        public global::G.PageInfo? PageInfo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesIndexedAssetsListResponse200" /> class.
        /// </summary>
        /// <param name="data">
        /// An array that contains up to `page_limit` indexed assets.
        /// </param>
        /// <param name="pageInfo">
        /// An object that provides information about pagination.
        /// </param>
        public IndexesIndexedAssetsListResponse200(
            global::System.Collections.Generic.IList<global::G.IndexedAsset>? data,
            global::G.PageInfo? pageInfo)
        {
            this.Data = data;
            this.PageInfo = pageInfo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexesIndexedAssetsListResponse200" /> class.
        /// </summary>
        public IndexesIndexedAssetsListResponse200()
        {
        }
    }
}