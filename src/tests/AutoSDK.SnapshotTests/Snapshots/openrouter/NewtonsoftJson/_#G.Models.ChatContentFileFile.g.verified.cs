//HintName: G.Models.ChatContentFileFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatContentFileFile
    {
        /// <summary>
        /// File content as base64 data URL or URL
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// File ID for previously uploaded files
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Original filename
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentFileFile" /> class.
        /// </summary>
        /// <param name="fileData">
        /// File content as base64 data URL or URL
        /// </param>
        /// <param name="fileId">
        /// File ID for previously uploaded files
        /// </param>
        /// <param name="filename">
        /// Original filename
        /// </param>
        public ChatContentFileFile(
            string? fileData,
            string? fileId,
            string? filename)
        {
            this.FileData = fileData;
            this.FileId = fileId;
            this.Filename = filename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatContentFileFile" /> class.
        /// </summary>
        public ChatContentFileFile()
        {
        }
    }
}