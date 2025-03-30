//HintName: G.Models.Highlight.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Highlight
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_chunk_start_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptChunkStartIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_chunk_end_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int PromptChunkEndIndex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_chunk")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PromptChunk { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("highlight_text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HighlightText { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Highlight" /> class.
        /// </summary>
        /// <param name="promptChunkStartIndex"></param>
        /// <param name="promptChunkEndIndex"></param>
        /// <param name="promptChunk"></param>
        /// <param name="highlightText"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Highlight(
            int promptChunkStartIndex,
            int promptChunkEndIndex,
            string promptChunk,
            string highlightText)
        {
            this.PromptChunkStartIndex = promptChunkStartIndex;
            this.PromptChunkEndIndex = promptChunkEndIndex;
            this.PromptChunk = promptChunk ?? throw new global::System.ArgumentNullException(nameof(promptChunk));
            this.HighlightText = highlightText ?? throw new global::System.ArgumentNullException(nameof(highlightText));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Highlight" /> class.
        /// </summary>
        public Highlight()
        {
        }
    }
}