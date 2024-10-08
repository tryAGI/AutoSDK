//HintName: G.Models.StreamGenerationChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The chunk response from the generation, which may be a partial generation.
    /// </summary>
    public sealed partial class StreamGenerationChunk
    {
        /// <summary>
        /// When the streaming event contains the next chunk of generator output, the<br/>
        /// type will be `generation_chunk`.<br/>
        /// Default Value: generation_chunk
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public string? Type { get; set; } = "generation_chunk";

        /// <summary>
        /// Part of the message from the generator. All summary chunks must be appended together in order<br/>
        /// to get the full summary.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generation_chunk")]
        public string? GenerationChunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}