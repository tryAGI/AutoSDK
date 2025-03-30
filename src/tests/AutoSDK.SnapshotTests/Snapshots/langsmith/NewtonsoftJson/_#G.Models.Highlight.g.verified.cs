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
        [global::Newtonsoft.Json.JsonProperty("prompt_chunk_start_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptChunkStartIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_chunk_end_index", Required = global::Newtonsoft.Json.Required.Always)]
        public int PromptChunkEndIndex { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prompt_chunk", Required = global::Newtonsoft.Json.Required.Always)]
        public string PromptChunk { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("highlight_text", Required = global::Newtonsoft.Json.Required.Always)]
        public string HighlightText { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Highlight" /> class.
        /// </summary>
        /// <param name="promptChunkStartIndex"></param>
        /// <param name="promptChunkEndIndex"></param>
        /// <param name="promptChunk"></param>
        /// <param name="highlightText"></param>
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