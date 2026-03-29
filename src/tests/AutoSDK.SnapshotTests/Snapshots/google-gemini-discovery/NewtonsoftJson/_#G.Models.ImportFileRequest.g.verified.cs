//HintName: G.Models.ImportFileRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request for `ImportFile` to import a File API file with a `FileSearchStore`. LINT.IfChange(ImportFileRequest)
    /// </summary>
    public sealed partial class ImportFileRequest
    {
        /// <summary>
        /// Required. The name of the `File` to import. Example: `files/abc-123`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileName")]
        public string? FileName { get; set; }

        /// <summary>
        /// Custom metadata to be associated with the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("customMetadata")]
        public global::System.Collections.Generic.IList<global::G.CustomMetadata>? CustomMetadata { get; set; }

        /// <summary>
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunkingConfig")]
        public global::G.ChunkingConfig? ChunkingConfig { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFileRequest" /> class.
        /// </summary>
        /// <param name="fileName">
        /// Required. The name of the `File` to import. Example: `files/abc-123`
        /// </param>
        /// <param name="customMetadata">
        /// Custom metadata to be associated with the file.
        /// </param>
        /// <param name="chunkingConfig">
        /// Parameters for telling the service how to chunk the file. inspired by google3/cloud/ai/platform/extension/lib/retrieval/config/chunker_config.proto
        /// </param>
        public ImportFileRequest(
            string? fileName,
            global::System.Collections.Generic.IList<global::G.CustomMetadata>? customMetadata,
            global::G.ChunkingConfig? chunkingConfig)
        {
            this.FileName = fileName;
            this.CustomMetadata = customMetadata;
            this.ChunkingConfig = chunkingConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportFileRequest" /> class.
        /// </summary>
        public ImportFileRequest()
        {
        }
    }
}