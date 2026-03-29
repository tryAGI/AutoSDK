//HintName: G.Models.FullTextSearchConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configuration options for full-text search.
    /// </summary>
    public sealed partial class FullTextSearchConfig
    {
        /// <summary>
        /// The `k1` term saturation parameter for BM25. Defaults to `1.2`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("k1")]
        public double? K1 { get; set; }

        /// <summary>
        /// The `b` document length normalization parameter for BM25. Defaults to `0.75`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("b")]
        public double? B { get; set; }

        /// <summary>
        /// Describes the language of a text attribute. Defaults to `english`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("language")]
        public global::G.Language? Language { get; set; }

        /// <summary>
        /// Language-specific stemming for the text. Defaults to `false` (i.e., do not stem).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stemming")]
        public bool? Stemming { get; set; }

        /// <summary>
        /// Removes common words from the text based on language. Defaults to `true` (i.e. remove common words).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("remove_stopwords")]
        public bool? RemoveStopwords { get; set; }

        /// <summary>
        /// Whether to convert each non-ASCII character in a token to its ASCII equivalent, if one exists (e.g., à -&gt; a). Defaults to `false` (i.e., no folding).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("ascii_folding")]
        public bool? AsciiFolding { get; set; }

        /// <summary>
        /// Whether searching is case-sensitive. Defaults to `false` (i.e. case-insensitive).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("case_sensitive")]
        public bool? CaseSensitive { get; set; }

        /// <summary>
        /// Maximum length of a token in bytes. Tokens larger than this value during tokenization will be filtered out. Has to be between `1` and `254` (inclusive). Defaults to `39`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_token_length")]
        public long? MaxTokenLength { get; set; }

        /// <summary>
        /// The tokenizer to use for full-text search on an attribute. Defaults to `word_v3`.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tokenizer")]
        public global::G.Tokenizer? Tokenizer { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FullTextSearchConfig" /> class.
        /// </summary>
        /// <param name="k1">
        /// The `k1` term saturation parameter for BM25. Defaults to `1.2`.
        /// </param>
        /// <param name="b">
        /// The `b` document length normalization parameter for BM25. Defaults to `0.75`.
        /// </param>
        /// <param name="language">
        /// Describes the language of a text attribute. Defaults to `english`.
        /// </param>
        /// <param name="stemming">
        /// Language-specific stemming for the text. Defaults to `false` (i.e., do not stem).
        /// </param>
        /// <param name="removeStopwords">
        /// Removes common words from the text based on language. Defaults to `true` (i.e. remove common words).
        /// </param>
        /// <param name="asciiFolding">
        /// Whether to convert each non-ASCII character in a token to its ASCII equivalent, if one exists (e.g., à -&gt; a). Defaults to `false` (i.e., no folding).
        /// </param>
        /// <param name="caseSensitive">
        /// Whether searching is case-sensitive. Defaults to `false` (i.e. case-insensitive).
        /// </param>
        /// <param name="maxTokenLength">
        /// Maximum length of a token in bytes. Tokens larger than this value during tokenization will be filtered out. Has to be between `1` and `254` (inclusive). Defaults to `39`.
        /// </param>
        /// <param name="tokenizer">
        /// The tokenizer to use for full-text search on an attribute. Defaults to `word_v3`.
        /// </param>
        public FullTextSearchConfig(
            double? k1,
            double? b,
            global::G.Language? language,
            bool? stemming,
            bool? removeStopwords,
            bool? asciiFolding,
            bool? caseSensitive,
            long? maxTokenLength,
            global::G.Tokenizer? tokenizer)
        {
            this.K1 = k1;
            this.B = b;
            this.Language = language;
            this.Stemming = stemming;
            this.RemoveStopwords = removeStopwords;
            this.AsciiFolding = asciiFolding;
            this.CaseSensitive = caseSensitive;
            this.MaxTokenLength = maxTokenLength;
            this.Tokenizer = tokenizer;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FullTextSearchConfig" /> class.
        /// </summary>
        public FullTextSearchConfig()
        {
        }
    }
}