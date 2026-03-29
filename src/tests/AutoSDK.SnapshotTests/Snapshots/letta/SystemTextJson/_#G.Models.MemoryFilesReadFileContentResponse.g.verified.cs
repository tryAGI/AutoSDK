//HintName: G.Models.MemoryFilesReadFileContentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MemoryFilesReadFileContentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ref")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Ref { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesReadFileContentResponse" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        /// <param name="ref"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MemoryFilesReadFileContentResponse(
            string path,
            string content,
            string @ref)
        {
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Ref = @ref ?? throw new global::System.ArgumentNullException(nameof(@ref));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesReadFileContentResponse" /> class.
        /// </summary>
        public MemoryFilesReadFileContentResponse()
        {
        }
    }
}