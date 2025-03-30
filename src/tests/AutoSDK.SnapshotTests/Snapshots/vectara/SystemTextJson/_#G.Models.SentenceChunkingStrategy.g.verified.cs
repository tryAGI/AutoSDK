//HintName: G.Models.SentenceChunkingStrategy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Sets a chunking strategy that creates one chunk per sentence.<br/>
    /// This is the default strategy used when no chunking strategy is specified.
    /// </summary>
    public sealed partial class SentenceChunkingStrategy
    {
        /// <summary>
        /// When setting the type to sentence_chunking_strategy, the platform will create one chunk per sentence.<br/>
        /// Default Value: sentence_chunking_strategy
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunkingStrategy" /> class.
        /// </summary>
        /// <param name="type">
        /// When setting the type to sentence_chunking_strategy, the platform will create one chunk per sentence.<br/>
        /// Default Value: sentence_chunking_strategy
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SentenceChunkingStrategy(
            string? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SentenceChunkingStrategy" /> class.
        /// </summary>
        public SentenceChunkingStrategy()
        {
        }
    }
}