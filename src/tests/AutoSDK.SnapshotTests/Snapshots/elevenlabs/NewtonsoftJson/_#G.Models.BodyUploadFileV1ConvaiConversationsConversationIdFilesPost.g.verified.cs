//HintName: G.Models.BodyUploadFileV1ConvaiConversationsConversationIdFilesPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodyUploadFileV1ConvaiConversationsConversationIdFilesPost
    {
        /// <summary>
        /// Image or PDF file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("file", Required = global::Newtonsoft.Json.Required.Always)]
        public byte[] File { get; set; } = default!;

        /// <summary>
        /// Image or PDF file to upload
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFileV1ConvaiConversationsConversationIdFilesPost" /> class.
        /// </summary>
        /// <param name="file">
        /// Image or PDF file to upload
        /// </param>
        /// <param name="filename">
        /// Image or PDF file to upload
        /// </param>
        public BodyUploadFileV1ConvaiConversationsConversationIdFilesPost(
            byte[] file,
            string filename)
        {
            this.File = file ?? throw new global::System.ArgumentNullException(nameof(file));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodyUploadFileV1ConvaiConversationsConversationIdFilesPost" /> class.
        /// </summary>
        public BodyUploadFileV1ConvaiConversationsConversationIdFilesPost()
        {
        }
    }
}