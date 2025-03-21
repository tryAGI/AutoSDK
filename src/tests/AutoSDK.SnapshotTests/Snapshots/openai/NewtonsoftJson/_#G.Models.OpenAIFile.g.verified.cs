//HintName: G.Models.OpenAIFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `File` object represents a document that has been uploaded to OpenAI.
    /// </summary>
    public sealed partial class OpenAIFile
    {
        /// <summary>
        /// The file identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The size of the file, in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public int Bytes { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the file was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset CreatedAt { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp (in seconds) for when the file will expire.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("expires_at")]
        public global::System.DateTimeOffset? ExpiresAt { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The object type, which is always `file`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("object")]
        public global::G.OpenAIFileObject Object { get; set; }

        /// <summary>
        /// The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results` and `vision`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purpose", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIFilePurpose Purpose { get; set; } = default!;

        /// <summary>
        /// Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.OpenAIFileStatus Status { get; set; } = default!;

        /// <summary>
        /// Deprecated. For details on why a fine-tuning training file failed validation, see the `error` field on `fine_tuning.job`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status_details")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? StatusDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFile" /> class.
        /// </summary>
        /// <param name="id">
        /// The file identifier, which can be referenced in the API endpoints.
        /// </param>
        /// <param name="bytes">
        /// The size of the file, in bytes.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) for when the file was created.
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) for when the file will expire.
        /// </param>
        /// <param name="filename">
        /// The name of the file.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `file`.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the file. Supported values are `assistants`, `assistants_output`, `batch`, `batch_output`, `fine-tune`, `fine-tune-results` and `vision`.
        /// </param>
        /// <param name="status">
        /// Deprecated. The current status of the file, which can be either `uploaded`, `processed`, or `error`.
        /// </param>
        public OpenAIFile(
            string id,
            int bytes,
            global::System.DateTimeOffset createdAt,
            string filename,
            global::G.OpenAIFilePurpose purpose,
            global::G.OpenAIFileStatus status,
            global::System.DateTimeOffset? expiresAt,
            global::G.OpenAIFileObject @object)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Purpose = purpose;
            this.Status = status;
            this.ExpiresAt = expiresAt;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAIFile" /> class.
        /// </summary>
        public OpenAIFile()
        {
        }
    }
}