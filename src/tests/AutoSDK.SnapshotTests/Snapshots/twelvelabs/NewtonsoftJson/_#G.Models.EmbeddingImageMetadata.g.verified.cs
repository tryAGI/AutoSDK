//HintName: G.Models.EmbeddingImageMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for image embeddings
    /// </summary>
    public sealed partial class EmbeddingImageMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_type")]
        public global::G.EmbeddingImageMetadataInputType InputType { get; set; }

        /// <summary>
        /// The publicly accessible URL for the image
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the image file
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingImageMetadata" /> class.
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="inputUrl">
        /// The publicly accessible URL for the image
        /// </param>
        /// <param name="inputFilename">
        /// The name of the image file
        /// </param>
        public EmbeddingImageMetadata(
            global::G.EmbeddingImageMetadataInputType inputType,
            string? inputUrl,
            string? inputFilename)
        {
            this.InputType = inputType;
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingImageMetadata" /> class.
        /// </summary>
        public EmbeddingImageMetadata()
        {
        }
    }
}