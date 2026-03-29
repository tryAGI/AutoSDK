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
        [global::Newtonsoft.Json.JsonProperty("creator_user_id")]
        public string? CreatorUserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_type")]
        public global::G.FolderType? FolderType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("workspace_id")]
        public string? WorkspaceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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