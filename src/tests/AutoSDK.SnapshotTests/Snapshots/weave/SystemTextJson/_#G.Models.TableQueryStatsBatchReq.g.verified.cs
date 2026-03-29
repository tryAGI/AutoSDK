//HintName: G.Models.TableQueryStatsBatchReq.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TableQueryStatsBatchReq
    {
        /// <summary>
        /// The ID of the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// The digests of the tables to query<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digests")]
        public global::System.Collections.Generic.IList<string>? Digests { get; set; }

        /// <summary>
        /// If true, the `storage_size_bytes` column is returned.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_storage_size")]
        public bool? IncludeStorageSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TableQueryStatsBatchReq" /> class.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the project
        /// </param>
        /// <param name="digests">
        /// The digests of the tables to query<br/>
        /// Default Value: []
        /// </param>
        /// <param name="includeStorageSize">
        /// If true, the `storage_size_bytes` column is returned.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TableQueryStatsBatchReq(
            string projectId,
            global::System.Collections.Generic.IList<string>? digests,
            bool? includeStorageSize)
        {
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Digests = digests;
            this.IncludeStorageSize = includeStorageSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TableQueryStatsBatchReq" /> class.
        /// </summary>
        public TableQueryStatsBatchReq()
        {
        }
    }
}