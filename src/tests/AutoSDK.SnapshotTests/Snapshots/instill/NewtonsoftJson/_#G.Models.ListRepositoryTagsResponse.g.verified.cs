//HintName: G.Models.ListRepositoryTagsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// ListRepositoryTagsResponse contains a list of container image tags.
    /// </summary>
    public sealed partial class ListRepositoryTagsResponse
    {
        /// <summary>
        /// A list of repository tags.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<global::G.RepositoryTag>? Tags { get; set; }

        /// <summary>
        /// Total number of tags.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The requested page size.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// The requested page offset.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}