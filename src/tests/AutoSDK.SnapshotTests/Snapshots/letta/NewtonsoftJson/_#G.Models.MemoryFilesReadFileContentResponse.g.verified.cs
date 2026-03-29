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
        [global::Newtonsoft.Json.JsonProperty("path", Required = global::Newtonsoft.Json.Required.Always)]
        public string Path { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content", Required = global::Newtonsoft.Json.Required.Always)]
        public string Content { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ref", Required = global::Newtonsoft.Json.Required.Always)]
        public string Ref { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MemoryFilesReadFileContentResponse" /> class.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="content"></param>
        /// <param name="ref"></param>
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