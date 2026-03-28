//HintName: G.Models.UnitTestSummaryResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UnitTestSummaryResponseModel
    {
        /// <summary>
        /// The ID of the test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The access information of the test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Creation time of the test in unix seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAtUnixSecs { get; set; }

        /// <summary>
        /// Last update time of the test in unix seconds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_updated_at_unix_secs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LastUpdatedAtUnixSecs { get; set; }

        /// <summary>
        /// Type of the test or entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TestTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.TestType Type { get; set; }

        /// <summary>
        /// The type of entity (test or folder)<br/>
        /// Default Value: test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entity_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentTestEntityTypeJsonConverter))]
        public global::G.AgentTestEntityType? EntityType { get; set; }

        /// <summary>
        /// The ID of the parent folder
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_parent_id")]
        public string? FolderParentId { get; set; }

        /// <summary>
        /// The folder path segments from root to this entity
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_path")]
        public global::System.Collections.Generic.IList<global::G.AgentTestFolderPathSegmentResponseModel>? FolderPath { get; set; }

        /// <summary>
        /// Number of direct children (tests and subfolders) for folders only
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("children_count")]
        public int? ChildrenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestSummaryResponseModel" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the test
        /// </param>
        /// <param name="name">
        /// Name of the test
        /// </param>
        /// <param name="createdAtUnixSecs">
        /// Creation time of the test in unix seconds
        /// </param>
        /// <param name="lastUpdatedAtUnixSecs">
        /// Last update time of the test in unix seconds
        /// </param>
        /// <param name="type">
        /// Type of the test or entity
        /// </param>
        /// <param name="accessInfo">
        /// The access information of the test
        /// </param>
        /// <param name="entityType">
        /// The type of entity (test or folder)<br/>
        /// Default Value: test
        /// </param>
        /// <param name="folderParentId">
        /// The ID of the parent folder
        /// </param>
        /// <param name="folderPath">
        /// The folder path segments from root to this entity
        /// </param>
        /// <param name="childrenCount">
        /// Number of direct children (tests and subfolders) for folders only
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UnitTestSummaryResponseModel(
            string id,
            string name,
            int createdAtUnixSecs,
            int lastUpdatedAtUnixSecs,
            global::G.TestType type,
            global::G.ResourceAccessInfo? accessInfo,
            global::G.AgentTestEntityType? entityType,
            string? folderParentId,
            global::System.Collections.Generic.IList<global::G.AgentTestFolderPathSegmentResponseModel>? folderPath,
            int? childrenCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AccessInfo = accessInfo;
            this.CreatedAtUnixSecs = createdAtUnixSecs;
            this.LastUpdatedAtUnixSecs = lastUpdatedAtUnixSecs;
            this.Type = type;
            this.EntityType = entityType;
            this.FolderParentId = folderParentId;
            this.FolderPath = folderPath;
            this.ChildrenCount = childrenCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitTestSummaryResponseModel" /> class.
        /// </summary>
        public UnitTestSummaryResponseModel()
        {
        }
    }
}