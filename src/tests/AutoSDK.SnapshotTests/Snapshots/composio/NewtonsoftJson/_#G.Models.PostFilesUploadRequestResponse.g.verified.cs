//HintName: G.Models.PostFilesUploadRequestResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PostFilesUploadRequestResponse
    {
        /// <summary>
        /// ID of the request file. Example: "req_file_9mZn4qR8sXwT"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Object storage upload location. Example: "projects/prj_xyz789/requests/slack/SLACK_UPLOAD_FILE/document_9mZn4q.docx"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// Presigned URL for upload. Example: "https://storage.composio.dev/projects/prj_xyz789/requests/slack/document_9mZn4q.docx?X-Amz-Algorithm=AWS4-HMAC-SHA256&amp;X-Amz-Expires=3600..."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_presigned_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewPresignedUrl { get; set; } = default!;

        /// <summary>
        /// [DEPRECATED] Use new_presigned_url instead. Presigned URL for upload. Example: "https://storage.composio.dev/projects/prj_xyz789/requests/slack/document_9mZn4q.docx?X-Amz-Algorithm=AWS4-HMAC-SHA256&amp;X-Amz-Expires=3600..."
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("newPresignedUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string NewPresignedUrl2 { get; set; } = default!;

        /// <summary>
        /// [DEPRECATED] Indicates this is a new file that needs to be uploaded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.PostFilesUploadRequestResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PostFilesUploadRequestResponseMetadata Metadata { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFilesUploadRequestResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// ID of the request file. Example: "req_file_9mZn4qR8sXwT"
        /// </param>
        /// <param name="key">
        /// Object storage upload location. Example: "projects/prj_xyz789/requests/slack/SLACK_UPLOAD_FILE/document_9mZn4q.docx"
        /// </param>
        /// <param name="newPresignedUrl">
        /// Presigned URL for upload. Example: "https://storage.composio.dev/projects/prj_xyz789/requests/slack/document_9mZn4q.docx?X-Amz-Algorithm=AWS4-HMAC-SHA256&amp;X-Amz-Expires=3600..."
        /// </param>
        /// <param name="newPresignedUrl2">
        /// [DEPRECATED] Use new_presigned_url instead. Presigned URL for upload. Example: "https://storage.composio.dev/projects/prj_xyz789/requests/slack/document_9mZn4q.docx?X-Amz-Algorithm=AWS4-HMAC-SHA256&amp;X-Amz-Expires=3600..."
        /// </param>
        /// <param name="metadata"></param>
        public PostFilesUploadRequestResponse(
            string id,
            string key,
            string newPresignedUrl,
            string newPresignedUrl2,
            global::G.PostFilesUploadRequestResponseMetadata metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.NewPresignedUrl = newPresignedUrl ?? throw new global::System.ArgumentNullException(nameof(newPresignedUrl));
            this.NewPresignedUrl2 = newPresignedUrl2 ?? throw new global::System.ArgumentNullException(nameof(newPresignedUrl2));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostFilesUploadRequestResponse" /> class.
        /// </summary>
        public PostFilesUploadRequestResponse()
        {
        }
    }
}