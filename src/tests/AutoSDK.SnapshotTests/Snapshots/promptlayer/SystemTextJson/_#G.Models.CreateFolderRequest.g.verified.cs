//HintName: G.Models.CreateFolderRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateFolderRequest
    {
        /// <summary>
        /// The name of the folder. Must be unique within its parent folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The ID of the parent folder. If null or not provided, the folder will be created at the root level of the workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public int? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the folder. Must be unique within its parent folder.
        /// </param>
        /// <param name="parentId">
        /// The ID of the parent folder. If null or not provided, the folder will be created at the root level of the workspace.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateFolderRequest(
            string name,
            int? parentId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFolderRequest" /> class.
        /// </summary>
        public CreateFolderRequest()
        {
        }
    }
}