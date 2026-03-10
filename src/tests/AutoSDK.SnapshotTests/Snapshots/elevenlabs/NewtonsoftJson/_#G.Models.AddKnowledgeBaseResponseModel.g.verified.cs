//HintName: G.Models.AddKnowledgeBaseResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AddKnowledgeBaseResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The folder path segments leading to this entity, from root to parent folder.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("folder_path")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? FolderPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddKnowledgeBaseResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="folderPath">
        /// The folder path segments leading to this entity, from root to parent folder.
        /// </param>
        public AddKnowledgeBaseResponseModel(
            string id,
            string name,
            global::System.Collections.Generic.IList<global::G.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? folderPath)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FolderPath = folderPath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddKnowledgeBaseResponseModel" /> class.
        /// </summary>
        public AddKnowledgeBaseResponseModel()
        {
        }
    }
}