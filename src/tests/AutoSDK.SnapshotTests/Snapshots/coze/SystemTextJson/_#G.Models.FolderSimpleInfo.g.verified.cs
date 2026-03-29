//HintName: G.Models.FolderSimpleInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FolderSimpleInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FolderTypeJsonConverter))]
        public global::G.FolderType? FolderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderSimpleInfo" /> class.
        /// </summary>
        /// <param name="creatorUserId"></param>
        /// <param name="description"></param>
        /// <param name="folderType"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="parentFolderId"></param>
        /// <param name="workspaceId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FolderSimpleInfo(
            string? creatorUserId,
            string? description,
            global::G.FolderType? folderType,
            string? id,
            string? name,
            string? parentFolderId,
            string? workspaceId)
        {
            this.CreatorUserId = creatorUserId;
            this.Description = description;
            this.FolderType = folderType;
            this.Id = id;
            this.Name = name;
            this.ParentFolderId = parentFolderId;
            this.WorkspaceId = workspaceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderSimpleInfo" /> class.
        /// </summary>
        public FolderSimpleInfo()
        {
        }
    }
}