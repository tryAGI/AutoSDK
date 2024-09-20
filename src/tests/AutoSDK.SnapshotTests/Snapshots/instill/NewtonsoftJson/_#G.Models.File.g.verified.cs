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
        [global::Newtonsoft.Json.JsonProperty("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// - FILE_PROCESS_STATUS_NOTSTARTED: NOTSTARTED<br/>
        ///  - FILE_PROCESS_STATUS_WAITING: file is waiting for embedding process<br/>
        ///  - FILE_PROCESS_STATUS_CONVERTING: file is converting<br/>
        ///  - FILE_PROCESS_STATUS_CHUNKING: file is chunking<br/>
        ///  - FILE_PROCESS_STATUS_EMBEDDING: file is embedding<br/>
        ///  - FILE_PROCESS_STATUS_COMPLETED: completed<br/>
        ///  - FILE_PROCESS_STATUS_FAILED: failed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processStatus")]
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
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FileType Type { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("processOutcome")]
        public string? ProcessOutcome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("retrievable")]
        public bool? Retrievable { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ownerUid")]
        public string? OwnerUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("creatorUid")]
        public string? CreatorUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("catalogUid")]
        public string? CatalogUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deleteTime")]
        public global::System.DateTime? DeleteTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public string? Size { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalChunks")]
        public int? TotalChunks { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("totalTokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}