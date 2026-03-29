//HintName: G.Models.UpdateDirectoryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDirectoryRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parentId")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDirectoryRequest" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="parentId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateDirectoryRequest(
            string? path,
            string? parentId)
        {
            this.Path = path;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDirectoryRequest" /> class.
        /// </summary>
        public UpdateDirectoryRequest()
        {
        }
    }
}