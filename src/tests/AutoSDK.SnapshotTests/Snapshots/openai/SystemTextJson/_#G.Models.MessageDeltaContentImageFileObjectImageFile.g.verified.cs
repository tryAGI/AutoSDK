//HintName: G.Models.MessageDeltaContentImageFileObjectImageFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MessageDeltaContentImageFileObjectImageFile
    {
        /// <summary>
        /// Specifies the detail level of the image if specified by the user. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageDeltaContentImageFileObjectImageFileDetailJsonConverter))]
        public global::G.MessageDeltaContentImageFileObjectImageFileDetail? Detail { get; set; }

        /// <summary>
        /// The [File](/docs/api-reference/files) ID of the image in the message content. Set `purpose="vision"` when uploading the File if you need to later display the file content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageFileObjectImageFile" /> class.
        /// </summary>
        /// <param name="detail">
        /// Specifies the detail level of the image if specified by the user. `low` uses fewer tokens, you can opt in to high resolution using `high`.<br/>
        /// Default Value: auto
        /// </param>
        /// <param name="fileId">
        /// The [File](/docs/api-reference/files) ID of the image in the message content. Set `purpose="vision"` when uploading the File if you need to later display the file content.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessageDeltaContentImageFileObjectImageFile(
            global::G.MessageDeltaContentImageFileObjectImageFileDetail? detail,
            string? fileId)
        {
            this.Detail = detail;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageDeltaContentImageFileObjectImageFile" /> class.
        /// </summary>
        public MessageDeltaContentImageFileObjectImageFile()
        {
        }
    }
}