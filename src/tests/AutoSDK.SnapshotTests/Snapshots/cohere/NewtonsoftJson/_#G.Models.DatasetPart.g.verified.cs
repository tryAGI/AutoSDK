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
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// The index of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("index")]
        public int? Index { get; set; }

        /// <summary>
        /// The name of the dataset part
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The number of rows in the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("num_rows")]
        public int? NumRows { get; set; }

        /// <summary>
        /// The download url of the original file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("original_url")]
        public string? OriginalUrl { get; set; }

        /// <summary>
        /// The first few rows of the parsed file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("samples")]
        public global::System.Collections.Generic.IList<string>? Samples { get; set; }

        /// <summary>
        /// The size of the file in bytes
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("size_bytes")]
        public int? SizeBytes { get; set; }

        /// <summary>
        /// The download url of the file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetPart" /> class.
        /// </summary>
        /// <param name="id">
        /// The dataset part ID
        /// </param>
        /// <param name="index">
        /// The index of the file
        /// </param>
        /// <param name="name">
        /// The name of the dataset part
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
        /// <param name="sizeBytes">
        /// The size of the file in bytes
        /// </param>
        /// <param name="url">
        /// The download url of the file
        /// </param>
        public DatasetPart(
            string id,
            string name,
            int? index,
            int? numRows,
            string? originalUrl,
            global::System.Collections.Generic.IList<string>? samples,
            int? sizeBytes,
            string? url)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Index = index;
            this.NumRows = numRows;
            this.OriginalUrl = originalUrl;
            this.Samples = samples;
            this.SizeBytes = sizeBytes;
            this.Url = url;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DatasetPart" /> class.
        /// </summary>
        public DatasetPart()
        {
        }
    }
}