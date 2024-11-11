//HintName: G.Models.FileReference.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// FileReference represents metadata for a file.
    /// </summary>
    public sealed partial class FileReference
    {
        /// <summary>
        /// Name of the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Format of the file (e.g., PDF, TXT, JPG).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Size of the file in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Size { get; set; }

        /// <summary>
        /// URL of the file (e.g., S3 URL).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileReference" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the file.
        /// </param>
        /// <param name="type">
        /// Format of the file (e.g., PDF, TXT, JPG).
        /// </param>
        /// <param name="size">
        /// Size of the file in bytes.
        /// </param>
        /// <param name="url">
        /// URL of the file (e.g., S3 URL).
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public FileReference(
            string name,
            string type,
            string size,
            string url)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Size = size ?? throw new global::System.ArgumentNullException(nameof(size));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileReference" /> class.
        /// </summary>
        public FileReference()
        {
        }
    }
}