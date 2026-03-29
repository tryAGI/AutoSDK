//HintName: G.Models.EmbeddingSuccessResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingSuccessResponse
    {
        /// <summary>
        /// Array of embedding results
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EmbeddingData> Data { get; set; } = default!;

        /// <summary>
        /// Metadata for the media input. Available for image, text_image, audio, video, and multi_input inputs.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::G.EmbeddingMediaMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingSuccessResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// Array of embedding results
        /// </param>
        /// <param name="metadata">
        /// Metadata for the media input. Available for image, text_image, audio, video, and multi_input inputs.
        /// </param>
        public EmbeddingSuccessResponse(
            global::System.Collections.Generic.IList<global::G.EmbeddingData> data,
            global::G.EmbeddingMediaMetadata? metadata)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingSuccessResponse" /> class.
        /// </summary>
        public EmbeddingSuccessResponse()
        {
        }
    }
}