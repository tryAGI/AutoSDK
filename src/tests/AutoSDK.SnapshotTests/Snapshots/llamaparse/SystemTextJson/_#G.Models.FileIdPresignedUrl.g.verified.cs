//HintName: G.Models.FileIdPresignedUrl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Schema for a presigned URL with a file ID.
    /// </summary>
    public sealed partial class FileIdPresignedUrl
    {
        /// <summary>
        /// A presigned URL for IO operations against a private file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The time at which the presigned URL expires
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Form fields for a presigned POST request
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("form_fields")]
        public global::System.Collections.Generic.Dictionary<string, string>? FormFields { get; set; }

        /// <summary>
        /// The ID of the file associated with the presigned URL
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid FileId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileIdPresignedUrl" /> class.
        /// </summary>
        /// <param name="url">
        /// A presigned URL for IO operations against a private file
        /// </param>
        /// <param name="expiresAt">
        /// The time at which the presigned URL expires
        /// </param>
        /// <param name="fileId">
        /// The ID of the file associated with the presigned URL
        /// </param>
        /// <param name="formFields">
        /// Form fields for a presigned POST request
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileIdPresignedUrl(
            string url,
            global::System.DateTime expiresAt,
            global::System.Guid fileId,
            global::System.Collections.Generic.Dictionary<string, string>? formFields)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ExpiresAt = expiresAt;
            this.FormFields = formFields;
            this.FileId = fileId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileIdPresignedUrl" /> class.
        /// </summary>
        public FileIdPresignedUrl()
        {
        }
    }
}