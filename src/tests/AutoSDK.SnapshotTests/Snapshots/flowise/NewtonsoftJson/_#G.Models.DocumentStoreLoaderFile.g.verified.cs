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
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Name of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// MIME prefix of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mimePrefix")]
        public string? MimePrefix { get; set; }

        /// <summary>
        /// Size of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size")]
        public double? Size { get; set; }

        /// <summary>
        /// Status of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("status")]
        public global::G.DocumentStoreLoaderFileStatus? Status { get; set; }

        /// <summary>
        /// Date and time when the file was uploaded
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uploaded")]
        public global::System.DateTime? Uploaded { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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