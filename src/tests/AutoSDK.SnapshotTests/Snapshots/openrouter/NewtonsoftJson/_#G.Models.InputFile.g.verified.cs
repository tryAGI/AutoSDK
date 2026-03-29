//HintName: G.Models.InputFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File input content item
    /// </summary>
    public sealed partial class InputFile
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.InputFileType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFile" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="fileId"></param>
        /// <param name="fileData"></param>
        /// <param name="filename"></param>
        /// <param name="fileUrl"></param>
        public InputFile(
            global::G.InputFileType type,
            string? fileId,
            string? fileData,
            string? filename,
            string? fileUrl)
        {
            this.Type = type;
            this.FileId = fileId;
            this.FileData = fileData;
            this.Filename = filename;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InputFile" /> class.
        /// </summary>
        public InputFile()
        {
        }
    }
}