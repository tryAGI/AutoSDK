//HintName: G.Models.MaxCharsChunkingStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets a chunking strategy that limits the number of maximum characters per chunk.<br/>
    /// The chunks do not cross section boundaries.
    /// </summary>
    public sealed partial class MaxCharsChunkingStrategy
    {
        /// <summary>
        /// When setting the type to max_chars_chunking_strategy, you can control the size of chunks (docparts).<br/>
        /// Default Value: max_chars_chunking_strategy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Specifies the maximum number of characters per chunk.<br/>
        /// The platform adds sentences to a chunk until the total number of characters exceeds the limit.<br/>
        /// If a single sentence exceeds the limit, it splits the sentence across chunks.<br/>
        /// Note: This is the only case where the chunk may not contain a complete sentence.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_chars_per_chunk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxCharsPerChunk { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaxCharsChunkingStrategy" /> class.
        /// </summary>
        /// <param name="type">
        /// When setting the type to max_chars_chunking_strategy, you can control the size of chunks (docparts).<br/>
        /// Default Value: max_chars_chunking_strategy
        /// </param>
        /// <param name="maxCharsPerChunk">
        /// Specifies the maximum number of characters per chunk.<br/>
        /// The platform adds sentences to a chunk until the total number of characters exceeds the limit.<br/>
        /// If a single sentence exceeds the limit, it splits the sentence across chunks.<br/>
        /// Note: This is the only case where the chunk may not contain a complete sentence.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaxCharsChunkingStrategy(
            int maxCharsPerChunk,
            string? type)
        {
            this.MaxCharsPerChunk = maxCharsPerChunk;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaxCharsChunkingStrategy" /> class.
        /// </summary>
        public MaxCharsChunkingStrategy()
        {
        }
    }
}