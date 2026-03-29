//HintName: G.Models.Folder.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Folder
    {
        /// <summary>
        /// Unique identifier for the folder
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the folder
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Timestamp when the folder was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the folder was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// JSON array representing the folder hierarchy path. Contains the IDs and names of all parent folders. Null for root-level folders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public global::System.Collections.Generic.IList<object>? Path { get; set; }

        /// <summary>
        /// ID of the workspace this folder belongs to
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public int? WorkspaceId { get; set; }

        /// <summary>
        /// ID of the parent folder. Null for root-level folders.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public int? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Folder" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the folder
        /// </param>
        /// <param name="name">
        /// The name of the folder
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the folder was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the folder was last updated
        /// </param>
        /// <param name="path">
        /// JSON array representing the folder hierarchy path. Contains the IDs and names of all parent folders. Null for root-level folders.
        /// </param>
        /// <param name="workspaceId">
        /// ID of the workspace this folder belongs to
        /// </param>
        /// <param name="parentId">
        /// ID of the parent folder. Null for root-level folders.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Folder(
            int? id,
            string? name,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt,
            global::System.Collections.Generic.IList<object>? path,
            int? workspaceId,
            int? parentId)
        {
            this.Id = id;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Path = path;
            this.WorkspaceId = workspaceId;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Folder" /> class.
        /// </summary>
        public Folder()
        {
        }
    }
}