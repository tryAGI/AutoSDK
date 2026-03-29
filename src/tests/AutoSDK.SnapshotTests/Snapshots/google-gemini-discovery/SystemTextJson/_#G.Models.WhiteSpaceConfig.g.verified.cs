//HintName: G.Models.WhiteSpaceConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration for a white space chunking algorithm [white space delimited].
    /// </summary>
    public sealed partial class WhiteSpaceConfig
    {
        /// <summary>
        /// Maximum number of tokens per chunk. Tokens are defined as words for this chunking algorithm. Note: we are defining tokens as words split by whitespace as opposed to the output of a tokenizer. The context window of the latest gemini embedding model as of 2025-04-17 is currently 8192 tokens. We assume that the average word is 5 characters. Therefore, we set the upper limit to 2**9, which is 512 words, or 2560 tokens, assuming worst case a character per token. This is a conservative estimate meant to prevent context window overflow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxTokensPerChunk")]
        public int? MaxTokensPerChunk { get; set; }

        /// <summary>
        /// Maximum number of overlapping tokens between two adjacent chunks.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxOverlapTokens")]
        public int? MaxOverlapTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WhiteSpaceConfig" /> class.
        /// </summary>
        /// <param name="maxTokensPerChunk">
        /// Maximum number of tokens per chunk. Tokens are defined as words for this chunking algorithm. Note: we are defining tokens as words split by whitespace as opposed to the output of a tokenizer. The context window of the latest gemini embedding model as of 2025-04-17 is currently 8192 tokens. We assume that the average word is 5 characters. Therefore, we set the upper limit to 2**9, which is 512 words, or 2560 tokens, assuming worst case a character per token. This is a conservative estimate meant to prevent context window overflow.
        /// </param>
        /// <param name="maxOverlapTokens">
        /// Maximum number of overlapping tokens between two adjacent chunks.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WhiteSpaceConfig(
            int? maxTokensPerChunk,
            int? maxOverlapTokens)
        {
            this.MaxTokensPerChunk = maxTokensPerChunk;
            this.MaxOverlapTokens = maxOverlapTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WhiteSpaceConfig" /> class.
        /// </summary>
        public WhiteSpaceConfig()
        {
        }
    }
}