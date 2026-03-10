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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The folder path segments leading to this entity, from root to parent folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("folder_path")]
        public global::System.Collections.Generic.IList<global::G.KnowledgeBaseFolderPathSegmentSummaryResponseModel>? FolderPath { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AddKnowledgeBaseResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="folderPath">
        /// The folder path segments leading to this entity, from root to parent folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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