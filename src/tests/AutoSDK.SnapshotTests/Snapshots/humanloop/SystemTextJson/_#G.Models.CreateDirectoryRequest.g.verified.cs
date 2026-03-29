//HintName: G.Models.CreateDirectoryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDirectoryRequest
    {
        /// <summary>
        /// Path for the directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// ID of the parent directory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDirectoryRequest" /> class.
        /// </summary>
        /// <param name="path">
        /// Path for the directory.
        /// </param>
        /// <param name="parentId">
        /// ID of the parent directory.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateDirectoryRequest(
            string path,
            string? parentId)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDirectoryRequest" /> class.
        /// </summary>
        public CreateDirectoryRequest()
        {
        }
    }
}