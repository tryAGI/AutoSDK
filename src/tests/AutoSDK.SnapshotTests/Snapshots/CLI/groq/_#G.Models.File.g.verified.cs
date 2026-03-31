//HintName: G.Models.File.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The `File` object represents a document that has been uploaded.
    /// </summary>
    public sealed partial class File
    {
        /// <summary>
        /// The file identifier, which can be referenced in the API endpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The size of the file, in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        public long? Bytes { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) for when the file was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The object type, which is always `file`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FileObjectJsonConverter))]
        public global::G.FileObject? Object { get; set; }

        /// <summary>
        /// The intended purpose of the file. Supported values are `batch`, and `batch_output`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purpose")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.FilePurposeJsonConverter))]
        public global::G.FilePurpose? Purpose { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
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
        /// <param name="filename">
        /// The name of the file.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `file`.
        /// </param>
        /// <param name="purpose">
        /// The intended purpose of the file. Supported values are `batch`, and `batch_output`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public File(
            string? id,
            long? bytes,
            global::System.DateTimeOffset? createdAt,
            string? filename,
            global::G.FileObject? @object,
            global::G.FilePurpose? purpose)
        {
            this.Id = id;
            this.Bytes = bytes;
            this.CreatedAt = createdAt;
            this.Filename = filename;
            this.Object = @object;
            this.Purpose = purpose;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File" /> class.
        /// </summary>
        public File()
        {
        }
    }
}