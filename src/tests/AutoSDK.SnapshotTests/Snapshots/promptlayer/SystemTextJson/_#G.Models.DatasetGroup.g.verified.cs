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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Dataset group name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Associated workspace ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WorkspaceId { get; set; }

        /// <summary>
        /// Whether the dataset group is deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDeleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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