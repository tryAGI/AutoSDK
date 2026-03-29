//HintName: G.Models.HybridChunkerOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for the HybridChunker.
    /// </summary>
    public sealed partial class HybridChunkerOptions
    {
        /// <summary>
        /// Default Value: hybrid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chunker")]
        public string? Chunker { get; set; }

        /// <summary>
        /// Use markdown table format instead of triplets for table serialization.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_markdown_tables")]
        public bool? UseMarkdownTables { get; set; }

        /// <summary>
        /// Include both raw_text and text (contextualized) in response. If False, only text is included.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_raw_text")]
        public bool? IncludeRawText { get; set; }

        /// <summary>
        /// Maximum number of tokens per chunk. When left to none, the value is automatically extracted from the tokenizer.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_tokens")]
        public int? MaxTokens { get; set; }

        /// <summary>
        /// HuggingFace model name for custom tokenization. If not specified, uses 'sentence-transformers/all-MiniLM-L6-v2' as default.<br/>
        /// Default Value: sentence-transformers/all-MiniLM-L6-v2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizer")]
        public string? Tokenizer { get; set; }

        /// <summary>
        /// Merge undersized successive chunks with same headings.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("merge_peers")]
        public bool? MergePeers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptions" /> class.
        /// </summary>
        /// <param name="chunker">
        /// Default Value: hybrid
        /// </param>
        /// <param name="useMarkdownTables">
        /// Use markdown table format instead of triplets for table serialization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="includeRawText">
        /// Include both raw_text and text (contextualized) in response. If False, only text is included.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens per chunk. When left to none, the value is automatically extracted from the tokenizer.
        /// </param>
        /// <param name="tokenizer">
        /// HuggingFace model name for custom tokenization. If not specified, uses 'sentence-transformers/all-MiniLM-L6-v2' as default.<br/>
        /// Default Value: sentence-transformers/all-MiniLM-L6-v2
        /// </param>
        /// <param name="mergePeers">
        /// Merge undersized successive chunks with same headings.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HybridChunkerOptions(
            string? chunker,
            bool? useMarkdownTables,
            bool? includeRawText,
            int? maxTokens,
            string? tokenizer,
            bool? mergePeers)
        {
            this.Chunker = chunker;
            this.UseMarkdownTables = useMarkdownTables;
            this.IncludeRawText = includeRawText;
            this.MaxTokens = maxTokens;
            this.Tokenizer = tokenizer;
            this.MergePeers = mergePeers;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridChunkerOptions" /> class.
        /// </summary>
        public HybridChunkerOptions()
        {
        }
    }
}