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
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Object storage upload location. Example: "projects/prj_xyz789/requests/slack/SLACK_UPLOAD_FILE/document_9mZn4q.docx"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// Presigned URL for upload. Example: "https://storage.composio.dev/projects/prj_xyz789/requests/slack/document_9mZn4q.docx?X-Amz-Algorithm=AWS4-HMAC-SHA256&amp;X-Amz-Expires=3600..."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_presigned_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewPresignedUrl { get; set; }

        /// <summary>
        /// [DEPRECATED] Use new_presigned_url instead. Presigned URL for upload. Example: "https://storage.composio.dev/projects/prj_xyz789/requests/slack/document_9mZn4q.docx?X-Amz-Algorithm=AWS4-HMAC-SHA256&amp;X-Amz-Expires=3600..."
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("newPresignedUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NewPresignedUrl2 { get; set; }

        /// <summary>
        /// [DEPRECATED] Indicates this is a new file that needs to be uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PostFilesUploadRequestResponseTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::G.PostFilesUploadRequestResponseType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PostFilesUploadRequestResponseMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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