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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the file including extension
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes", Required = global::Newtonsoft.Json.Required.Always)]
        public long Bytes { get; set; } = default!;

        /// <summary>
        /// MIME type of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mime_type", Required = global::Newtonsoft.Json.Required.Always)]
        public string MimeType { get; set; } = default!;

        /// <summary>
        /// Version of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("version", Required = global::Newtonsoft.Json.Required.Always)]
        public int Version { get; set; } = default!;

        /// <summary>
        /// Timestamp when the file was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// Timestamp when the file was last updated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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