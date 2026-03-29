//HintName: G.Models.CreateDocumentOpenAPIRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateDocumentOpenAPIRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("chunk_strategy", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ChunkStrategy ChunkStrategy { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dataset_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string DatasetId { get; set; } = default!;

        /// <summary>
        /// 表格类型一次只能创建一个待创建的文档信息
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_bases", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DocumentBase> DocumentBases { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("format_type", Required = global::Newtonsoft.Json.Required.Always)]
        public int FormatType { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentOpenAPIRequest" /> class.
        /// </summary>
        /// <param name="chunkStrategy"></param>
        /// <param name="datasetId"></param>
        /// <param name="documentBases">
        /// 表格类型一次只能创建一个待创建的文档信息
        /// </param>
        /// <param name="formatType"></param>
        public CreateDocumentOpenAPIRequest(
            global::G.ChunkStrategy chunkStrategy,
            string datasetId,
            global::System.Collections.Generic.IList<global::G.DocumentBase> documentBases,
            int formatType)
        {
            this.ChunkStrategy = chunkStrategy ?? throw new global::System.ArgumentNullException(nameof(chunkStrategy));
            this.DatasetId = datasetId ?? throw new global::System.ArgumentNullException(nameof(datasetId));
            this.DocumentBases = documentBases ?? throw new global::System.ArgumentNullException(nameof(documentBases));
            this.FormatType = formatType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDocumentOpenAPIRequest" /> class.
        /// </summary>
        public CreateDocumentOpenAPIRequest()
        {
        }
    }
}