//HintName: G.Models.DocumentStoreLoaderFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentStoreLoaderFile
    {
        /// <summary>
        /// Unique identifier for the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// MIME prefix of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mimePrefix")]
        public string? MimePrefix { get; set; }

        /// <summary>
        /// Size of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public double? Size { get; set; }

        /// <summary>
        /// Status of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DocumentStoreLoaderFileStatusJsonConverter))]
        public global::G.DocumentStoreLoaderFileStatus? Status { get; set; }

        /// <summary>
        /// Date and time when the file was uploaded
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uploaded")]
        public global::System.DateTime? Uploaded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderFile" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the file
        /// </param>
        /// <param name="name">
        /// Name of the file
        /// </param>
        /// <param name="mimePrefix">
        /// MIME prefix of the file
        /// </param>
        /// <param name="size">
        /// Size of the file
        /// </param>
        /// <param name="status">
        /// Status of the file
        /// </param>
        /// <param name="uploaded">
        /// Date and time when the file was uploaded
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentStoreLoaderFile(
            global::System.Guid? id,
            string? name,
            string? mimePrefix,
            double? size,
            global::G.DocumentStoreLoaderFileStatus? status,
            global::System.DateTime? uploaded)
        {
            this.Id = id;
            this.Name = name;
            this.MimePrefix = mimePrefix;
            this.Size = size;
            this.Status = status;
            this.Uploaded = uploaded;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStoreLoaderFile" /> class.
        /// </summary>
        public DocumentStoreLoaderFile()
        {
        }
    }
}