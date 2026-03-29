//HintName: G.Models.TextIndexParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TextIndexParams
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TextIndexTypeJsonConverter))]
        public global::G.TextIndexType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tokenizer")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TokenizerTypeJsonConverter))]
        public global::G.TokenizerType? Tokenizer { get; set; }

        /// <summary>
        /// Minimum characters to be tokenized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("min_token_len")]
        public int? MinTokenLen { get; set; }

        /// <summary>
        /// Maximum characters to be tokenized.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_token_len")]
        public int? MaxTokenLen { get; set; }

        /// <summary>
        /// If true, lowercase all tokens. Default: true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lowercase")]
        public bool? Lowercase { get; set; }

        /// <summary>
        /// If true, normalize tokens by folding accented characters to ASCII (e.g., "ação" -&gt; "acao"). Default: false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ascii_folding")]
        public bool? AsciiFolding { get; set; }

        /// <summary>
        /// If true, support phrase matching. Default: false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phrase_matching")]
        public bool? PhraseMatching { get; set; }

        /// <summary>
        /// Ignore this set of tokens. Can select from predefined languages and/or provide a custom set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stopwords")]
        public global::G.StopwordsInterface? Stopwords { get; set; }

        /// <summary>
        /// If true, store the index on disk. Default: false.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_disk")]
        public bool? OnDisk { get; set; }

        /// <summary>
        /// Algorithm for stemming. Default: disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stemmer")]
        public global::G.StemmingAlgorithm? Stemmer { get; set; }

        /// <summary>
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_hnsw")]
        public bool? EnableHnsw { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TextIndexParams" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="tokenizer"></param>
        /// <param name="minTokenLen">
        /// Minimum characters to be tokenized.
        /// </param>
        /// <param name="maxTokenLen">
        /// Maximum characters to be tokenized.
        /// </param>
        /// <param name="lowercase">
        /// If true, lowercase all tokens. Default: true.
        /// </param>
        /// <param name="asciiFolding">
        /// If true, normalize tokens by folding accented characters to ASCII (e.g., "ação" -&gt; "acao"). Default: false.
        /// </param>
        /// <param name="phraseMatching">
        /// If true, support phrase matching. Default: false.
        /// </param>
        /// <param name="stopwords">
        /// Ignore this set of tokens. Can select from predefined languages and/or provide a custom set.
        /// </param>
        /// <param name="onDisk">
        /// If true, store the index on disk. Default: false.
        /// </param>
        /// <param name="stemmer">
        /// Algorithm for stemming. Default: disabled.
        /// </param>
        /// <param name="enableHnsw">
        /// Enable HNSW graph building for this payload field. If true, builds additional HNSW links (Need payload_m &gt; 0). Default: true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TextIndexParams(
            global::G.TextIndexType type,
            global::G.TokenizerType? tokenizer,
            int? minTokenLen,
            int? maxTokenLen,
            bool? lowercase,
            bool? asciiFolding,
            bool? phraseMatching,
            global::G.StopwordsInterface? stopwords,
            bool? onDisk,
            global::G.StemmingAlgorithm? stemmer,
            bool? enableHnsw)
        {
            this.Type = type;
            this.Tokenizer = tokenizer;
            this.MinTokenLen = minTokenLen;
            this.MaxTokenLen = maxTokenLen;
            this.Lowercase = lowercase;
            this.AsciiFolding = asciiFolding;
            this.PhraseMatching = phraseMatching;
            this.Stopwords = stopwords;
            this.OnDisk = onDisk;
            this.Stemmer = stemmer;
            this.EnableHnsw = enableHnsw;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TextIndexParams" /> class.
        /// </summary>
        public TextIndexParams()
        {
        }
    }
}