//HintName: G.Models.ChatCompletionContentPartFileFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionContentPartFileFile
    {
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
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartFileFile" /> class.
        /// </summary>
        /// <param name="fileData"></param>
        /// <param name="filename"></param>
        /// <param name="fileId"></param>
        public ChatCompletionContentPartFileFile(
            string? fileData,
            string? filename,
            string? fileId)
        {
            this.FileData = fileData;
            this.Filename = filename;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionContentPartFileFile" /> class.
        /// </summary>
        public ChatCompletionContentPartFileFile()
        {
        }
    }
}