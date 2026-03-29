//HintName: G.Models.DatasetGroup.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetGroup
    {
        /// <summary>
        /// Dataset group ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Dataset group name
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Associated workspace ID
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id", Required = global::Newtonsoft.Json.Required.Always)]
        public int WorkspaceId { get; set; } = default!;

        /// <summary>
        /// Whether the dataset group is deleted
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_deleted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDeleted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetGroup" /> class.
        /// </summary>
        /// <param name="id">
        /// Dataset group ID
        /// </param>
        /// <param name="name">
        /// Dataset group name
        /// </param>
        /// <param name="workspaceId">
        /// Associated workspace ID
        /// </param>
        /// <param name="isDeleted">
        /// Whether the dataset group is deleted
        /// </param>
        public DatasetGroup(
            int id,
            string name,
            int workspaceId,
            bool isDeleted)
        {
            this.Id = id;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.WorkspaceId = workspaceId;
            this.IsDeleted = isDeleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetGroup" /> class.
        /// </summary>
        public DatasetGroup()
        {
        }
    }
}