//HintName: G.Models.MessageDeltaContentTextAnnotationsFilePathObjectFilePath.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentTextAnnotationsFilePathObjectFilePath
    {
        /// <summary>
        /// The ID of the file that was generated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFilePathObjectFilePath" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the file that was generated.
        /// </param>
        public MessageDeltaContentTextAnnotationsFilePathObjectFilePath(
            string? fileId)
        {
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentTextAnnotationsFilePathObjectFilePath" /> class.
        /// </summary>
        public MessageDeltaContentTextAnnotationsFilePathObjectFilePath()
        {
        }
    }
}