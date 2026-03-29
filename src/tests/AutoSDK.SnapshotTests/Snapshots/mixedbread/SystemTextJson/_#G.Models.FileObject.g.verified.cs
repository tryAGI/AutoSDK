//HintName: G.Models.FileObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A model representing a file object in the system.<br/>
    /// This model contains metadata about files stored in the system, including<br/>
    /// identifiers, size information, and timestamps.
    /// </summary>
    public sealed partial class FileObject
    {
        /// <summary>
        /// Unique identifier for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the file including extension
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Filename { get; set; }

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Bytes { get; set; }

        /// <summary>
        /// MIME type of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mime_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MimeType { get; set; }

        /// <summary>
        /// Version of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Version { get; set; }

        /// <summary>
        /// Timestamp when the file was created
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the file was last updated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileObject" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the file
        /// </param>
        /// <param name="filename">
        /// Name of the file including extension
        /// </param>
        /// <param name="bytes">
        /// Size of the file in bytes
        /// </param>
        /// <param name="mimeType">
        /// MIME type of the file
        /// </param>
        /// <param name="version">
        /// Version of the file
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the file was created
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the file was last updated
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FileObject(
            string id,
            string filename,
            long bytes,
            string mimeType,
            int version,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Bytes = bytes;
            this.MimeType = mimeType ?? throw new global::System.ArgumentNullException(nameof(mimeType));
            this.Version = version;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileObject" /> class.
        /// </summary>
        public FileObject()
        {
        }
    }
}