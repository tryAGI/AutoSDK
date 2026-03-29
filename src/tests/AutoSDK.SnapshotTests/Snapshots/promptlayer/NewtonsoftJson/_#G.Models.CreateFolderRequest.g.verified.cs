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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The ID of the parent folder. If null or not provided, the folder will be created at the root level of the workspace.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_id")]
        public int? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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