//HintName: G.Models.DatasetPart.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DatasetPart
    {
        /// <summary>
        /// The dataset part ID
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the dataset part
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The download url of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The index of the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The size of the file in bytes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public int? SizeBytes { get; set; }

        /// <summary>
        /// The number of rows in the file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_rows")]
        public int? NumRows { get; set; }

        /// <summary>
        /// The download url of the original file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_url")]
        public string? OriginalUrl { get; set; }

        /// <summary>
        /// The first few rows of the parsed file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samples")]
        public global::System.Collections.Generic.IList<string>? Samples { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetPart" /> class.
        /// </summary>
        /// <param name="id">
        /// The dataset part ID
        /// </param>
        /// <param name="name">
        /// The name of the dataset part
        /// </param>
        /// <param name="url">
        /// The download url of the file
        /// </param>
        /// <param name="index">
        /// The index of the file
        /// </param>
        /// <param name="sizeBytes">
        /// The size of the file in bytes
        /// </param>
        /// <param name="numRows">
        /// The number of rows in the file
        /// </param>
        /// <param name="originalUrl">
        /// The download url of the original file
        /// </param>
        /// <param name="samples">
        /// The first few rows of the parsed file
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public DatasetPart(
            string id,
            string name,
            string? url,
            int? index,
            int? sizeBytes,
            int? numRows,
            string? originalUrl,
            global::System.Collections.Generic.IList<string>? samples)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url;
            this.Index = index;
            this.SizeBytes = sizeBytes;
            this.NumRows = numRows;
            this.OriginalUrl = originalUrl;
            this.Samples = samples;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetPart" /> class.
        /// </summary>
        public DatasetPart()
        {
        }
    }
}