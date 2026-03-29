//HintName: G.Models.DatasetFile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File stored in a dataset
    /// </summary>
    public sealed partial class DatasetFile
    {
        /// <summary>
        /// Unique identifier for the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Original filename
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filename", Required = global::Newtonsoft.Json.Required.Always)]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// Timestamp when the file was created
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at", Required = global::Newtonsoft.Json.Required.Always)]
        public string CreatedAt { get; set; } = default!;

        /// <summary>
        /// Size of the file in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size", Required = global::Newtonsoft.Json.Required.Always)]
        public long Size { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFile" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the file
        /// </param>
        /// <param name="filename">
        /// Original filename
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the file was created
        /// </param>
        /// <param name="size">
        /// Size of the file in bytes
        /// </param>
        public DatasetFile(
            string id,
            string filename,
            string createdAt,
            long size)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.CreatedAt = createdAt ?? throw new global::System.ArgumentNullException(nameof(createdAt));
            this.Size = size;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetFile" /> class.
        /// </summary>
        public DatasetFile()
        {
        }
    }
}