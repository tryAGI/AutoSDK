//HintName: G.Models.Sam3EmbeddingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Sam3EmbeddingResponse
    {
        /// <summary>
        /// Image id embeddings are cached to
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("image_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string ImageId { get; set; } = default!;

        /// <summary>
        /// The time in seconds it took to produce the embeddings including preprocessing
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("time", Required = global::Newtonsoft.Json.Required.Always)]
        public double Time { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3EmbeddingResponse" /> class.
        /// </summary>
        /// <param name="imageId">
        /// Image id embeddings are cached to
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the embeddings including preprocessing
        /// </param>
        public Sam3EmbeddingResponse(
            string imageId,
            double time)
        {
            this.ImageId = imageId ?? throw new global::System.ArgumentNullException(nameof(imageId));
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3EmbeddingResponse" /> class.
        /// </summary>
        public Sam3EmbeddingResponse()
        {
        }
    }
}