//HintName: G.Models.CreateVectorStoreFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectorStoreFileRequest
    {
        /// <summary>
        /// A [File](/docs/api-reference/files) ID that the vector store should use. Useful for tools like `file_search` that can access files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FileId { get; set; }

        /// <summary>
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunking_strategy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ChunkingStrategyRequestParamJsonConverter))]
        public global::G.ChunkingStrategyRequestParam? ChunkingStrategy { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectorStoreFileRequest" /> class.
        /// </summary>
        /// <param name="fileId">
        /// A [File](/docs/api-reference/files) ID that the vector store should use. Useful for tools like `file_search` that can access files.
        /// </param>
        /// <param name="chunkingStrategy">
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
        /// </param>
        /// <param name="attributes">
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectorStoreFileRequest(
            string fileId,
            global::G.ChunkingStrategyRequestParam? chunkingStrategy,
            object? attributes)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.ChunkingStrategy = chunkingStrategy;
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectorStoreFileRequest" /> class.
        /// </summary>
        public CreateVectorStoreFileRequest()
        {
        }
    }
}