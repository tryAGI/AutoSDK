//HintName: G.Models.Metadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Metadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileUid")]
        public string? FileUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileId")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileType")]
        public global::G.FileType? FileType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileSize")]
        public string? FileSize { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileUploadTime")]
        public global::System.DateTime? FileUploadTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("fileProcessStatus")]
        public global::G.FileProcessStatus? FileProcessStatus { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        /// <param name="fileUid"></param>
        /// <param name="fileId"></param>
        /// <param name="fileType"></param>
        /// <param name="fileSize"></param>
        /// <param name="fileUploadTime"></param>
        /// <param name="fileProcessStatus"></param>
        public Metadata(
            string? fileUid,
            string? fileId,
            global::G.FileType? fileType,
            string? fileSize,
            global::System.DateTime? fileUploadTime,
            global::G.FileProcessStatus? fileProcessStatus)
        {
            this.FileUid = fileUid;
            this.FileId = fileId;
            this.FileType = fileType;
            this.FileSize = fileSize;
            this.FileUploadTime = fileUploadTime;
            this.FileProcessStatus = fileProcessStatus;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Metadata" /> class.
        /// </summary>
        public Metadata()
        {
        }
    }
}