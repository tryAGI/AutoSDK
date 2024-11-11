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
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.IList<global::G.RepositoryTag>? Tags { get; set; }

        /// <summary>
        /// Total number of tags.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalSize")]
        public int? TotalSize { get; set; }

        /// <summary>
        /// The requested page size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pageSize")]
        public int? PageSize { get; set; }

        /// <summary>
        /// The requested page offset.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page")]
        public int? Page { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoryTagsResponse" /> class.
        /// </summary>
        /// <param name="tags">
        /// A list of repository tags.
        /// </param>
        /// <param name="totalSize">
        /// Total number of tags.
        /// </param>
        /// <param name="pageSize">
        /// The requested page size.
        /// </param>
        /// <param name="page">
        /// The requested page offset.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ListRepositoryTagsResponse(
            global::System.Collections.Generic.IList<global::G.RepositoryTag>? tags,
            int? totalSize,
            int? pageSize,
            int? page)
        {
            this.Tags = tags;
            this.TotalSize = totalSize;
            this.PageSize = pageSize;
            this.Page = page;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListRepositoryTagsResponse" /> class.
        /// </summary>
        public ListRepositoryTagsResponse()
        {
        }
    }
}