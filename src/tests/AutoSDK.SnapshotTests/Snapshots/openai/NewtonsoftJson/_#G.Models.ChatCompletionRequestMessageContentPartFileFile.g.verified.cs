//HintName: G.Models.ChatCompletionRequestMessageContentPartFileFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatCompletionRequestMessageContentPartFileFile
    {
        /// <summary>
        /// The name of the file, used when passing the file to the model as a <br/>
        /// string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_name")]
        public string? FileName { get; set; }

        /// <summary>
        /// The base64 encoded file data, used when passing the file to the model <br/>
        /// as a string.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// The ID of an uploaded file to use as input.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartFileFile" /> class.
        /// </summary>
        /// <param name="fileName">
        /// The name of the file, used when passing the file to the model as a <br/>
        /// string.
        /// </param>
        /// <param name="fileData">
        /// The base64 encoded file data, used when passing the file to the model <br/>
        /// as a string.
        /// </param>
        /// <param name="fileId">
        /// The ID of an uploaded file to use as input.
        /// </param>
        public ChatCompletionRequestMessageContentPartFileFile(
            string? fileName,
            string? fileData,
            string? fileId)
        {
            this.FileName = fileName;
            this.FileData = fileData;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionRequestMessageContentPartFileFile" /> class.
        /// </summary>
        public ChatCompletionRequestMessageContentPartFileFile()
        {
        }
    }
}