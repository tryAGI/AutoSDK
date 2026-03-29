//HintName: G.Models.StreamStartResponseMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An object containing metadata about the stream.
    /// </summary>
    public sealed partial class StreamStartResponseMetadata
    {
        /// <summary>
        /// A unique identifier for the generation session.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_id")]
        public string? GenerationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamStartResponseMetadata" /> class.
        /// </summary>
        /// <param name="generationId">
        /// A unique identifier for the generation session.
        /// </param>
        public StreamStartResponseMetadata(
            string? generationId)
        {
            this.GenerationId = generationId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamStartResponseMetadata" /> class.
        /// </summary>
        public StreamStartResponseMetadata()
        {
        }
    }
}