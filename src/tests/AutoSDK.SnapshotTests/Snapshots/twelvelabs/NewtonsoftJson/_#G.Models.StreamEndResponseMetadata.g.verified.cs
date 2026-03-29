//HintName: G.Models.StreamEndResponseMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing metadata about the stream.
    /// </summary>
    public sealed partial class StreamEndResponseMetadata
    {
        /// <summary>
        /// The same unique identifier provided in the `stream_start` event.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// The number of tokens used in the generation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usage")]
        public global::G.TokenUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEndResponseMetadata" /> class.
        /// </summary>
        /// <param name="generationId">
        /// The same unique identifier provided in the `stream_start` event.
        /// </param>
        /// <param name="usage">
        /// The number of tokens used in the generation.
        /// </param>
        public StreamEndResponseMetadata(
            string? generationId,
            global::G.TokenUsage? usage)
        {
            this.GenerationId = generationId;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamEndResponseMetadata" /> class.
        /// </summary>
        public StreamEndResponseMetadata()
        {
        }
    }
}