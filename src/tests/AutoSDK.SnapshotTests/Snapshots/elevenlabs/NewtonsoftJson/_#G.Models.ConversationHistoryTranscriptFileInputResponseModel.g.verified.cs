//HintName: G.Models.ConversationHistoryTranscriptFileInputResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryTranscriptFileInputResponseModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string OriginalFilename { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string FileUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptFileInputResponseModel" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="originalFilename"></param>
        /// <param name="mimeType"></param>
        /// <param name="fileUrl"></param>
        public ConversationHistoryTranscriptFileInputResponseModel(
            string fileId,
            string originalFilename,
            string mimeType,
            string fileUrl)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.OriginalFilename = originalFilename ?? throw new global::System.ArgumentNullException(nameof(originalFilename));
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.FileUrl = fileUrl ?? throw new global::System.ArgumentNullException(nameof(fileUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryTranscriptFileInputResponseModel" /> class.
        /// </summary>
        public ConversationHistoryTranscriptFileInputResponseModel()
        {
        }
    }
}