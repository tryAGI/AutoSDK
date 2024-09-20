//HintName: G.Models.File.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// - FILE_PROCESS_STATUS_NOTSTARTED: NOTSTARTED<br/>
        ///  - FILE_PROCESS_STATUS_WAITING: file is waiting for embedding process<br/>
        ///  - FILE_PROCESS_STATUS_CONVERTING: file is converting<br/>
        ///  - FILE_PROCESS_STATUS_CHUNKING: file is chunking<br/>
        ///  - FILE_PROCESS_STATUS_EMBEDDING: file is embedding<br/>
        ///  - FILE_PROCESS_STATUS_COMPLETED: completed<br/>
        ///  - FILE_PROCESS_STATUS_FAILED: failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processStatus")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileProcessStatusJsonConverter))]
        public global::G.FileProcessStatus? ProcessStatus { get; set; }

        /// <summary>
        /// - FILE_TYPE_TEXT: text<br/>
        ///  - FILE_TYPE_PDF: PDF<br/>
        ///  - FILE_TYPE_MARKDOWN: MARKDOWN<br/>
        ///  - FILE_TYPE_PNG: PNG(not supported yet)<br/>
        ///  - FILE_TYPE_JPEG: JPEG(not supported yet)<br/>
        ///  - FILE_TYPE_JPG: JPG(not supported yet)<br/>
        ///  - FILE_TYPE_HTML: HTML<br/>
        ///  - FILE_TYPE_DOCX: DOCX<br/>
        ///  - FILE_TYPE_DOC: DOC<br/>
        ///  - FILE_TYPE_PPT: PPT<br/>
        ///  - FILE_TYPE_PPTX: PPTX<br/>
        ///  - FILE_TYPE_XLS: XLS(not supported yet)<br/>
        ///  - FILE_TYPE_XLSX: XLSX
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.FileType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processOutcome")]
        public string? ProcessOutcome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ownerUid")]
        public string? OwnerUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creatorUid")]
        public string? CreatorUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("catalogUid")]
        public string? CatalogUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public string? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalChunks")]
        public int? TotalChunks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalTokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}