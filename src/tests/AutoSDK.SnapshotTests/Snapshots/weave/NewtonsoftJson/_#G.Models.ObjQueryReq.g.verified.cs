//HintName: G.Models.ObjQueryReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ObjQueryReq
    {
        /// <summary>
        /// The ID of the project to query
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ProjectId { get; set; } = default!;

        /// <summary>
        /// Filter criteria for the query. See `ObjectVersionFilter`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.ObjectVersionFilter? Filter { get; set; }

        /// <summary>
        /// Maximum number of results to return
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Number of results to skip before returning
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Sorting criteria for the query results. Currently only supports 'object_id' and 'created_at'.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort_by")]
        public global::System.Collections.Generic.IList<global::G.SortBy>? SortBy { get; set; }

        /// <summary>
        /// If true, the `val` column is not read from the database and is empty.All other fields are returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_only")]
        public bool? MetadataOnly { get; set; }

        /// <summary>
        /// If true, the `size_bytes` column is returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_storage_size")]
        public bool? IncludeStorageSize { get; set; }

        /// <summary>
        /// If true, tags and aliases are fetched and included in the response.<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_tags_and_aliases")]
        public bool? IncludeTagsAndAliases { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjQueryReq" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project to query
        /// </param>
        /// <param name="filter">
        /// Filter criteria for the query. See `ObjectVersionFilter`
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return
        /// </param>
        /// <param name="offset">
        /// Number of results to skip before returning
        /// </param>
        /// <param name="sortBy">
        /// Sorting criteria for the query results. Currently only supports 'object_id' and 'created_at'.
        /// </param>
        /// <param name="metadataOnly">
        /// If true, the `val` column is not read from the database and is empty.All other fields are returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeStorageSize">
        /// If true, the `size_bytes` column is returned.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeTagsAndAliases">
        /// If true, tags and aliases are fetched and included in the response.<br/>
        /// Default Value: false
        /// </param>
        public ObjQueryReq(
            string projectId,
            global::G.ObjectVersionFilter? filter,
            int? limit,
            int? offset,
            global::System.Collections.Generic.IList<global::G.SortBy>? sortBy,
            bool? metadataOnly,
            bool? includeStorageSize,
            bool? includeTagsAndAliases)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Filter = filter;
            this.Limit = limit;
            this.Offset = offset;
            this.SortBy = sortBy;
            this.MetadataOnly = metadataOnly;
            this.IncludeStorageSize = includeStorageSize;
            this.IncludeTagsAndAliases = includeTagsAndAliases;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjQueryReq" /> class.
        /// </summary>
        public ObjQueryReq()
        {
        }
    }
}