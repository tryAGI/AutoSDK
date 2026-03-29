//HintName: G.Models.EmbeddingTextImageMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Metadata for text-image embeddings
    /// </summary>
    public sealed partial class EmbeddingTextImageMetadata
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EmbeddingTextImageMetadataInputTypeJsonConverter))]
        public global::G.EmbeddingTextImageMetadataInputType InputType { get; set; }

        /// <summary>
        /// The publicly accessible URL for the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_url")]
        public string? InputUrl { get; set; }

        /// <summary>
        /// The name of the image file
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_filename")]
        public string? InputFilename { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTextImageMetadata" /> class.
        /// </summary>
        /// <param name="inputType"></param>
        /// <param name="inputUrl">
        /// The publicly accessible URL for the image
        /// </param>
        /// <param name="inputFilename">
        /// The name of the image file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingTextImageMetadata(
            global::G.EmbeddingTextImageMetadataInputType inputType,
            string? inputUrl,
            string? inputFilename)
        {
            this.InputType = inputType;
            this.InputUrl = inputUrl;
            this.InputFilename = inputFilename;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingTextImageMetadata" /> class.
        /// </summary>
        public EmbeddingTextImageMetadata()
        {
        }
    }
}