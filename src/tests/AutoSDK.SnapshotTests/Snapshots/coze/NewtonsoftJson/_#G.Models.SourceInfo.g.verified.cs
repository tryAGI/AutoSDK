//HintName: G.Models.SourceInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SourceInfo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_source")]
        public int? DocumentSource { get; set; }

        /// <summary>
        /// document_source 本地: 如果不传 tos 地址, 则需要传文件 base64, 类型文件经过 base64 后的字符串
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_base64")]
        public string? FileBase64 { get; set; }

        /// <summary>
        /// 文件类型, 比如 pdf
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_type")]
        public string? FileType { get; set; }

        /// <summary>
        /// document_source google, notion: 三方源文件 id<br/>
        ///  document_source openapi: openapi上传的文件 id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("source_file_id")]
        public string? SourceFileId { get; set; }

        /// <summary>
        /// document_source weburl: 如果不传 web_id, 则需要传 weburl
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("web_url")]
        public string? WebUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceInfo" /> class.
        /// </summary>
        /// <param name="documentSource"></param>
        /// <param name="fileBase64">
        /// document_source 本地: 如果不传 tos 地址, 则需要传文件 base64, 类型文件经过 base64 后的字符串
        /// </param>
        /// <param name="fileType">
        /// 文件类型, 比如 pdf
        /// </param>
        /// <param name="sourceFileId">
        /// document_source google, notion: 三方源文件 id<br/>
        ///  document_source openapi: openapi上传的文件 id
        /// </param>
        /// <param name="webUrl">
        /// document_source weburl: 如果不传 web_id, 则需要传 weburl
        /// </param>
        public SourceInfo(
            int? documentSource,
            string? fileBase64,
            string? fileType,
            string? sourceFileId,
            string? webUrl)
        {
            this.DocumentSource = documentSource;
            this.FileBase64 = fileBase64;
            this.FileType = fileType;
            this.SourceFileId = sourceFileId;
            this.WebUrl = webUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceInfo" /> class.
        /// </summary>
        public SourceInfo()
        {
        }
    }
}