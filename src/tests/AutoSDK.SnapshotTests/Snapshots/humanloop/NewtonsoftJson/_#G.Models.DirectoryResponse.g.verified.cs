//HintName: G.Models.DirectoryResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DirectoryResponse
    {
        /// <summary>
        /// Unique identifier for the directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Path of the directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// Name of the directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// ID of the parent directory.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the directory.
        /// </param>
        /// <param name="path">
        /// Path of the directory.
        /// </param>
        /// <param name="name">
        /// Name of the directory.
        /// </param>
        /// <param name="parentId">
        /// ID of the parent directory.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="updatedAt"></param>
        public DirectoryResponse(
            string id,
            string path,
            string name,
            string? parentId,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ParentId = parentId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DirectoryResponse" /> class.
        /// </summary>
        public DirectoryResponse()
        {
        }
    }
}