//HintName: G.Models.ChunkDocumentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChunkDocumentResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunks", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ChunkedDocumentResultItem> Chunks { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.ExportResult> Documents { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processing_time", Required = global::Newtonsoft.Json.Required.Always)]
        public double ProcessingTime { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkDocumentResponse" /> class.
        /// </summary>
        /// <param name="chunks"></param>
        /// <param name="documents"></param>
        /// <param name="processingTime"></param>
        public ChunkDocumentResponse(
            global::System.Collections.Generic.IList<global::G.ChunkedDocumentResultItem> chunks,
            global::System.Collections.Generic.IList<global::G.ExportResult> documents,
            double processingTime)
        {
            this.Chunks = chunks ?? throw new global::System.ArgumentNullException(nameof(chunks));
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.ProcessingTime = processingTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChunkDocumentResponse" /> class.
        /// </summary>
        public ChunkDocumentResponse()
        {
        }
    }
}