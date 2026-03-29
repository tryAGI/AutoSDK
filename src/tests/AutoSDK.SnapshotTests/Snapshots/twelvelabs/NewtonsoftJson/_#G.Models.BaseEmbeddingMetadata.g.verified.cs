//HintName: G.Models.BaseEmbeddingMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata about the embedding.
    /// </summary>
    public sealed partial class BaseEmbeddingMetadata
    {
        /// <summary>
        /// The URL of the media file used to generate the embedding. Present if a URL was provided in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the media file used to generate the embedding. Present if a file was provided in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEmbeddingMetadata" /> class.
        /// </summary>
        /// <param name="inputUrl">
        /// The URL of the media file used to generate the embedding. Present if a URL was provided in the request.
        /// </param>
        /// <param name="inputFilename">
        /// The name of the media file used to generate the embedding. Present if a file was provided in the request.
        /// </param>
        public BaseEmbeddingMetadata(
            string? inputUrl,
            string? inputFilename)
        {
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseEmbeddingMetadata" /> class.
        /// </summary>
        public BaseEmbeddingMetadata()
        {
        }
    }
}