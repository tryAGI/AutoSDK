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
        [global::System.Text.Json.Serialization.JsonPropertyName("chunk_strategy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ChunkStrategy ChunkStrategy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataset_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DatasetId { get; set; }

        /// <summary>
        /// 表格类型一次只能创建一个待创建的文档信息
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_bases")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DocumentBase> DocumentBases { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FormatType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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