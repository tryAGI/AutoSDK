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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the test
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The access information of the test
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("access_info")]
        public global::G.ResourceAccessInfo? AccessInfo { get; set; }

        /// <summary>
        /// Creation time of the test in unix seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int CreatedAtUnixSecs { get; set; } = default!;

        /// <summary>
        /// Last update time of the test in unix seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at_unix_secs", Required = global::Newtonsoft.Json.Required.Always)]
        public int LastUpdatedAtUnixSecs { get; set; } = default!;

        /// <summary>
        /// Type of the test or entity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.TestType Type { get; set; } = default!;

        /// <summary>
        /// The type of entity (test or folder)<br/>
        /// Default Value: test
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("entity_type")]
        public global::G.AgentTestEntityType? EntityType { get; set; }

        /// <summary>
        /// The ID of the parent folder
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_parent_id")]
        public string? FolderParentId { get; set; }

        /// <summary>
        /// The folder path segments from root to this entity
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_path")]
        public global::System.Collections.Generic.IList<global::G.AgentTestFolderPathSegmentResponseModel>? FolderPath { get; set; }

        /// <summary>
        /// Number of direct children (tests and subfolders) for folders only
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("children_count")]
        public int? ChildrenCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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