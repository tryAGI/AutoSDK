//HintName: G.Models.BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost
    {
        /// <summary>
        /// A custom, human-readable name for the document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// If set, the created document or folder will be placed inside the given folder.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_folder_id")]
        public string? ParentFolderId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost" /> class.
        /// </summary>
        /// <param name="name">
        /// A custom, human-readable name for the document.
        /// </param>
        /// <param name="parentFolderId">
        /// If set, the created document or folder will be placed inside the given folder.
        /// </param>
        public BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost(
            string name,
            string? parentFolderId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentFolderId = parentFolderId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost" /> class.
        /// </summary>
        public BodyCreateFolderV1ConvaiKnowledgeBaseFolderPost()
        {
        }
    }
}