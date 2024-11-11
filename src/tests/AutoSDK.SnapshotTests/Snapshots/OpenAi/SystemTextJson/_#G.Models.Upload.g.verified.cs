//HintName: G.Models.Upload.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The Upload object can accept byte chunks in the form of Parts.
    /// </summary>
    public sealed partial class Upload
    {
        /// <summary>
        /// The Upload unique identifier, which can be referenced in API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the Upload was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The name of the file to be uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// The intended number of bytes to be uploaded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Bytes { get; set; }

        /// <summary>
        /// The intended purpose of the file. [Please refer here](/docs/api-reference/files/object#files/object-purpose) for acceptable values.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Purpose { get; set; }

        /// <summary>
        /// The status of the Upload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UploadStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.UploadStatus Status { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the Upload was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset ExpiresAt { get; set; }

        /// <summary>
        /// The object type, which is always "upload".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UploadObjectJsonConverter))]
        public global::G.UploadObject? Object { get; set; }

        /// <summary>
        /// The `File` object represents a document that has been uploaded to OpenAI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file")]
        public global::G.OpenAIFile? File { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Upload" /> class.
        /// </summary>
        /// <param name="id">
        /// The Upload unique identifier, which can be referenced in API endpoints.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the Upload was created.
        /// </param>
        /// <param name="filename">
        /// The name of the file to be uploaded.
        /// </param>
        /// <param name="bytes">
        /// The intended number of bytes to be uploaded.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the file. [Please refer here](/docs/api-reference/files/object#files/object-purpose) for acceptable values.
        /// </param>
        /// <param name="status">
        /// The status of the Upload.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the Upload was created.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "upload".
        /// </param>
        /// <param name="file">
        /// The `File` object represents a document that has been uploaded to OpenAI.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Upload(
            string id,
            global::System.DateTimeOffset createdAt,
            string filename,
            int bytes,
            string purpose,
            global::G.UploadStatus status,
            global::System.DateTimeOffset expiresAt,
            global::G.UploadObject? @object,
            global::G.OpenAIFile? file)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Bytes = bytes;
            this.Purpose = purpose ?? throw new global::System.ArgumentNullException(nameof(purpose));
            this.Status = status;
            this.ExpiresAt = expiresAt;
            this.Object = @object;
            this.File = file;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Upload" /> class.
        /// </summary>
        public Upload()
        {
        }
    }
}